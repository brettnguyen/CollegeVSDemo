using CollegeVS.Services;
using CollegeVS.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Essentials;

namespace CollegeVS
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static void Init()
        {
            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("CollegeVS.appsettings.json");

            var host = new HostBuilder()
                        .ConfigureHostConfiguration(c =>
                        {
                // Tell the host configuration where to file the file (this is required for Xamarin apps)
                c.AddCommandLine(new string[] { $"ContentRoot={FileSystem.AppDataDirectory}" });

                //read in the configuration file!
                c.AddJsonStream(stream);
                        })
                        .ConfigureServices((c, x) =>
                        {
                // Configure our local services and access the host configuration
                ConfigureServices(c, x);
                        })
                        .ConfigureLogging(l => l.AddConsole(o =>
                        {
                //setup a console logger and disable colors since they don't have any colors in VS
                //o.DisableColors = true;
                        }))
                        .Build();

            //Save our service provider so we can use it later.
            ServiceProvider = host.Services;
        }

        static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
        {
            services.AddHttpClient();

            

            //services.AddSingleton<IDataStore, MockDataStore>();

            // The HostingEnvironment comes from the appsetting.json and could be optionally used to configure the mock service
            if (ctx.HostingEnvironment.IsDevelopment())
            {
                // add as a singleton so only one ever will be created.
                services.AddSingleton<IHomeAPIStore, HomeAPIStore>();
                services.AddSingleton<IAuthStore, AuthStore>();
                
            }
            else
            {
                services.AddSingleton<IHomeAPIStore, HomeAPIStore>();
                services.AddSingleton<IAuthStore, AuthStore>();
                
            }

            // add the ViewModel, but as a Transient, which means it will create a new one each time.
            services.AddTransient<CLGVSHomeViewModel>(); 
                services.AddTransient<ProfileGalleryViewModel>();
            services.AddTransient<LoginViewModel>();
            

            //Another thing we can do is access variables from that json file
            var world = ctx.Configuration["Hello"];
        }
    }
}
