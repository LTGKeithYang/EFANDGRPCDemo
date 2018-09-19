using Grpc.Core;
using GrpcServer;
using GRPCServer.Model;
using System;

namespace GRPCServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:9007", ChannelCredentials.Insecure);

            var client = new TestEF.TestEFClient(channel);
            var reply = client.AddUsers(new AddUserRequest());
            Console.WriteLine("来自" + reply.UserName);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
