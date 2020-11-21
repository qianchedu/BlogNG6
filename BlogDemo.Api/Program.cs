using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BlogDemo.Api
{
    /// <summary>
    /// 进行基础设施的配置，很少发生变化
    /// HTTP Server
    /// 集成IIS
    /// 配置信息来源
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseStartup<Startup>();
                .UseStartup(typeof(StartupDevelopment).GetTypeInfo().Assembly.FullName);
    }
}
