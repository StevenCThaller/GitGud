using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GitGud
{
    public class Startup
    // Leave some comments because I need to do things here for whatever reason balh balh blahbasdlfjhklasdklfhklasdklfjaklsdjf
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // Gotta add this comment in here. It's an incredibly important comment!

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // The mitochondria is overrated and it betrayed me! It took my money and invested in a pyramid scheme!
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // Homer Simpson loves donuts
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
