using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYSystem.BaseFramework.Common.Helper;
using TYSystem.BaseFramework.Common.Log;
using Service = CSTJR.RPC.Message.Contracts.MessageService;

namespace CSTJR.RPC.Message.Console
{
    public class Program
    {

        static void Main(string[] args)
        {
            int Port = int.Parse(ConfigHelper.GetValue("Port", "8090"));
            string ServerIP = ConfigHelper.GetValue("Server", "localhost");

            Server server = new Server
            {
                Services = { CSTJR.RPC.Message.Contracts.MessageService.BindService(new MessageService()) },
                Ports = { new ServerPort(ServerIP, Port, ServerCredentials.Insecure) }
            };
            server.Start();
            Logger.Info("gRPC server listening on port " + Port);
            System.Console.WriteLine("gRPC server listening on port " + Port);
            System.Console.WriteLine("任意键退出...");
            System.Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
