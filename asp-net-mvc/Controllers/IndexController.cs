// 创建人：李鸢
// 创建时间：2020/05/15 18:13

using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace asp_net_mvc.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /rest/
        [HttpGet("rest/index")]
        public string  Index()
        {
            Console.WriteLine("进入controller!");
            return "this is first asp net msg!";
        }
    }
}