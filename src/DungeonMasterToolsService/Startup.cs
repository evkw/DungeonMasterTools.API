using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DungeonMasterToolsModels;
using DungeonMasterToolsRepository;
using DungeonMasterToolsService.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace DungeonMasterToolsService
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<DungeonMasterToolsDbContext>(
                options => options.UseSqlServer("Server =.; Database = DungeonMasterTools; Trusted_Connection = True;"));

            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Dungeon Master Tools", Version = "v1" });
            });

            AutoMapperConfig.RegisterMappings();

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule(new DomainModule());
            var container = builder.Build();
            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUi(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dungeon Master Tools");
            });
        }
    }
}
