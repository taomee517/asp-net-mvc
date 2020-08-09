using log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace asp_net_mvc
{
    public class Program
    {
        //.net core项目配置log4net日志： https://www.jianshu.com/p/d371c98c2def
        // asp.netcore Log4Net连接kafka的方法: https://www.cnblogs.com/puzi0315/p/11429817.html
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