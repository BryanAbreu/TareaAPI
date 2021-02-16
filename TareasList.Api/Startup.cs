using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using TareasList.Core.Interfaces;
using TareasList.Core.Services;
using TareasList.Infrastructure.Data;
using TareasList.Infrastructure.Filters;
using WorksList.Core.Repositories;

namespace TareasList.Api
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
            services.AddSwaggerGen(doc =>{

                doc.SwaggerDoc("v1" , new OpenApiInfo{ Title = "Task List API", Version= "v1"} );
            });
            
            services.AddControllers().AddNewtonsoftJson(option=> 
            {
                option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddDbContext<WorkListContext>(option =>
             option.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddTransient<IWorkService, WorkService>();
            services.AddTransient<IWorkRepository, WorkRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
            .AddFluentValidation(options =>
            {
              options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(options => 
            {
                options.SwaggerEndpoint("/Swagger/v1/swagger.json", "Task List API");
                options.RoutePrefix = string.Empty;
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
