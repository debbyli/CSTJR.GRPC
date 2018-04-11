using CSTJR.Enum;
using CSTJR.Message.Entity.DBEntity;
using CSTJR.Message.JPush;
using CSTJR.Message.JPush.JPushEntity;
using CSTJR.Message.MQ.RabbitMQ;
using CSTJR.Message.MQ.RabbitMQ.Entity;
using CSTJR.RPC.Message.Contracts;
using DMSFrame;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TYSystem.BaseFramework.Common.Helper;
using TYSystem.BaseFramework.Common.Log;
using Activity = CSTJR.Message.MQ.RabbitMQ.Entity.ActivityMessageParam;
using Notice = CSTJR.Message.MQ.RabbitMQ.Entity.NoticeMessageParam;

namespace CSTJR.RPC.Message
{
    public class MessageService : CSTJR.RPC.Message.Contracts.MessageService.MessageServiceBase
    {

        /// <summary>
        /// 消息模版
        /// </summary>
        public MessageTemplate Template { get; set; }

        public MessageService()
        {
            Template = new MessageTemplate(Path.Combine(ConfigHelper.GetConfigPath, "MessageTemplate.xml"));
        }

        public override Task<SendMessageReply> SendMessage(SendMessageRequest request, ServerCallContext context)
        {
            SendMessageReply reply = new SendMessageReply();
            var reslute = SavePushMessage(request, request.MessageList.ToArray());
            try
            {
                string IOS = Template.GetActionString(request.Category, GetObject(request.ActionList.ToList()), "IOS");
                string Android = Template.GetActionString(request.Category, GetObject(request.ActionList.ToList()), "Android");
                string type = Template.GetTemplateType(request.Category);
                if (Template.IsSendPush)
                {
                    //推送实体
                    PushEntity entity = new PushEntity()
                    {
                        Title = Template.GetPushMessage(request.Category),
                        Alert = Template.GetTemplateString(request.Category, request.MessageList.ToArray()),
                        Badge = 1,
                        ByAlias = request.ToUser.ToString(),
                        ByRegistration = null,
                        Android = Android,
                        IOS = IOS,
                    };
                    JPushMessage push = new JPushMessage();
                    push.PushMessage(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                reply.Flag = false;
            }
            reply.Flag = true;
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 保存推送消息记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool SavePushMessage(SendMessageRequest model, params object[] objs)
        {
            //保存记录
            try
            {
                string errMsg = string.Empty;
                DMSTransactionScopeEntity tsEntity = new DMSTransactionScopeEntity();
                foreach (string to in model.ToUser.Split(','))
                {
                    MessagePush entity = new MessagePush();
                    entity.Category = model.Category;
                    entity.MessageBody = Template.GetTemplateString(model.Category, objs);
                    entity.MessageType = Template.GetMessageType(model.Category);
                    entity.Title = Template.Title;
                    entity.FromUser = model.FromUser;
                    entity.ToUser = to;
                    entity.IOS = Template.GetActionString(model.Category, GetObject(model.ActionList.ToList()), "IOS");
                    entity.Android = Template.GetActionString(model.Category, GetObject(model.ActionList.ToList()), "Android");
                    entity.BelongTo = 0;
                    entity.CreateTime = DateTime.Now;
                    tsEntity.AddTS(entity);
                }
                if (Template.IsSendPush)
                {
                    if (!new DMSTransactionScopeHandler().Update(tsEntity, ref errMsg))
                    {
                        Logger.Error(errMsg, "MessageTemplate.SavePushMessage");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, "MessageTemplate.SavePushMessage");
                return false;
            }

        }

        public List<object> GetObject(List<string> list)
        {
            List<object> objs = new List<object>();
            list.ForEach(p => { objs.Add(p); });
            return objs;
        }

        /// <summary>
        /// 定时任务
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<SendTaskReply> SendTaskMessage(SendTaskRequest request, ServerCallContext context)
        {
            SendTaskReply result = new SendTaskReply();

            List<TaskMessage> listTasks = DMS.Create<TaskMessage>().Where(p => p.SendStatu == 0 && p.SendTime <= DateTime.Now && p.DeleteFlag == false).ToList();
            int success = 0, err = 0;
            string msg = string.Empty;
            RabbitMQHelper help = new RabbitMQHelper();

            listTasks.ForEach(p =>
            {
                try
                {
                    if (p.TaskMessageType == EnumTaskMessageType.Notice)
                    {
                        Notice notice = new Notice()
                        {
                            SendMessage = p.SendMessage,
                            Users = p.Users,
                            TagMessage = p.TagMessage,
                            Title = p.Title,
                            Body = p.Body,
                            TaskMessageType = p.TaskMessageType,
                            UserType = p.UserType,
                            TaskMessageID = p.TaskMessageID
                        };
                        help.Send<Notice>("Notice", notice);
                    }
                    else
                    {
                        Activity activity = new Activity()
                        {
                            SendMessage = p.SendMessage,
                            Users = p.Users,
                            TagMessage = p.TagMessage,
                            CurrentType = p.CurrentType,
                            Relation = p.RelationID,
                            TaskMessageType = p.TaskMessageType,
                            UserType = p.UserType,
                            TaskMessageID = p.TaskMessageID
                        };
                        help.Send<Activity>("Activity", activity);
                    }

                    success++;
                }
                catch (Exception ex)
                {
                    err++;
                    msg = ex.Message;

                }
            });
            //更新状态
            DMS.Create<TaskMessage>().Edit(new TaskMessage() { SendStatu = 1 }, p => p.SendStatu == 0 && p.SendTime <= DateTime.Now && p.DeleteFlag == false);
            result.SuccessCount = success;
            result.ErrCount = err;
            result.ErrMsg = msg;
            return Task.FromResult<SendTaskReply>(result);
        }

    }
}
