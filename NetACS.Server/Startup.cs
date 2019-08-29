﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using NetACS.Server.Middleware;
using System.ServiceModel;
using NetACS.Server.Services;

namespace NetACS.Server
{
    class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<CalculatorService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseSoap<CalculatorService>("/CalculatorService.svc", new BasicHttpBinding());
            app.UseMiddleware<SoapManagement>();
        }
    }
}
