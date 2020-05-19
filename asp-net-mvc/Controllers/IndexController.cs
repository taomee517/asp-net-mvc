// 创建人：李鸢
// 创建时间：2020/05/15 18:13

using System;
using AspNetMvc.Grpc;
using AspNetMvc.Grpc.beans;
using AspNetMvc.Grpc.utils;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc.Controllers
{
    [Route("api")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [HttpGet("action")]
        public IActionResult Index()
        {
            Console.WriteLine("进入Index");
            return Content("first asp.net msg");
        }
        
        [HttpGet("string")]
        public string Msg()
        {
            Console.WriteLine("进入Msg");
            return "String msg";
        }
        
        
        [HttpPost("setting")]
        public bool Setting(CmdModel model)
        {
            Console.WriteLine("进入Setting方法!");
            var mac = model.Mac;
            var clientBase = GrpcClientUtil.GetGrpcClient(mac);
            var client = clientBase as CtrlService.CtrlServiceClient;
            var cmd = new CmdEntity();
            cmd.DeviceMac = mac;
            cmd.BusinessCode = 0;
            cmd.FunctionCode = 0xC05;
            cmd.ParamsJson = "{'laser_cycle_time':15}";
            var request = new SettingRequest();
            request.Entity = cmd;
            var response = client.SendSettingCmd(request);
            return response.Result;
        }
    }
}