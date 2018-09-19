using Grpc.Core;
using GRPCServer.Method;
using GRPCServer.Model;
using System;

namespace GRPCServer
{
    class Program
    {
        const int Port = 9007;

        public static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { GrpcServer.TestEF.BindService(new ServerFacade()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
