using System;
using Grpc.Core;
using GrpcLib.Grpc;
using iot_grpc_server.service;

namespace iot_grpc_server
{
    class Program
    {
        private const int Port = 50051;
        
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { CtrlService.BindService(new CtrlServiceImpl()) },
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