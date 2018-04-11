using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service = CSTJR.RPC.Message.Contracts.MessageService;

namespace CSTJR.RPC.Message.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("localhost:9099", ChannelCredentials.Insecure);

            var client = new Service.MessageServiceClient(channel);
            Contracts.SendMessageRequest request = new Contracts.SendMessageRequest
            {
                Category = 212,
                FromUser = "13567179275",
                ToUser = "13567179275",
            };
            request.ActionList.Add("212");
            request.MessageList.Add("张能杰");
            var reply = client.SendMessage(request);

            Console.WriteLine("来自" + reply.Flag);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
