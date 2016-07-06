using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace SimplestSample
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}