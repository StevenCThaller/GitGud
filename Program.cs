using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GitGud
{
    public class DingDongDitch
    {
        public string Ding { get; set; }
        public string Dong { get; set; }
        public string Ditch { get; set; }

        public DingDongDitch(string din, string don, string dit)
        {
            Ding = din;
            Dong = don;
            Ditch = dit;
        }

        public string DoTheThing()
        {
            string toPrint = Ding + Dong + Ditch;
            System.Console.WriteLine(toPrint);
            return toPrint;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DingDongDitch theThing = new DingDongDitch("Ding", "Dong", "The witch is dead!");

            theThing.DoTheThing();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
