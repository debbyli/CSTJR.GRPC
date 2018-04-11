using CSTJR.RPC.Message.Contracts;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using TYSystem.BaseFramework.Common.Helper;
using TYSystem.BaseFramework.Common.Log;

namespace CSTJR.RPC.Message.WinServer
{
    partial class Service : ServiceBase
    {
        int Port = int.Parse(ConfigHelper.GetValue("Port", "8090"));
        string ServerIP = ConfigHelper.GetValue("Server", "localhost");
        Server server;
        public Service()
        {
            InitializeComponent();
            server = new Server
            {
                Services = { CSTJR.RPC.Message.Contracts.MessageService.BindService(new CSTJR.RPC.Message.MessageService()) },
                Ports = { new ServerPort(ServerIP, Port, ServerCredentials.Insecure) }
            };
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            server.Start();
            Logger.Info("gRPC server listening on port " + Port);
 
        }

        protected override void OnStop()
        {
            server.ShutdownAsync().Wait();
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
