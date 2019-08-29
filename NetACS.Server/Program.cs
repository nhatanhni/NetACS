﻿using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NetACS.Server
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
