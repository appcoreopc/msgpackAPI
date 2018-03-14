using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Alphacert.Acc.Ods.Api;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Logging;
using AlphaCert.RDS.Repository;
using Alphacert.Acc.Ods.Entities.Entities;

namespace Alphacert.acc.ods.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration[AppConstant.ConnectionString];

            services.AddDbContextPool<IDS_ODSContext>(o => o.UseSqlServer(connectionString)).AddAlphaCertUnitorOfWork();
              
            services.Configure<AppConfig>(Configuration);
            
            services.AddMvc();
                        
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(AppConstant.ApiVersion, new Info { Title = AppConstant.ApiKeyInfo, Version = AppConstant.ApiVersion });
            });
                        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            
            app.UseMvc();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            loggerFactory.AddDebug();
        }
    }
}
