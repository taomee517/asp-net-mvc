using log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace asp_net_mvc
{
    public class Program
    {
        //.net core项目配置log4net日志： https://www.jianshu.com/p/d371c98c2def
        //type 是指你当前使用log的对象的类，例如需要在HomeController中使用，参数就为typeof(HomeController)
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseUrls("http://localhost:8111")
                        .UseStartup<Startup>();
                });
    }
}