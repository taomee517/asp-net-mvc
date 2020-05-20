// 创建人：李鸢
// 创建时间：2020/05/19 17:53

using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcLib.Grpc;

namespace iot_grpc_server.service
{
    public class CtrlServiceImpl : CtrlService.CtrlServiceBase
    {
        public CtrlServiceImpl()
        {
        }

        public override Task<SettingResponse> SendSettingCmd(SettingRequest request, ServerCallContext context)
        {
            var grpcEntity = request.Entity;
            Console.WriteLine($"接收到请求对象：{grpcEntity}");
            Console.WriteLine("组装TCP命令并下发给设备");
            Console.WriteLine("接收设备返回消息");
            var resp = new SettingResponse();
            resp.Result = true;
            return Task.FromResult(resp);
        }
    }
}