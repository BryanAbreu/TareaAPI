using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TareasList.Core.Interfaces;
<<<<<<< HEAD
using TareasList.Core.Services;
using TareasList.Infrastructure.Data;
using TareasList.Infrastructure.Filters;
using WorksList.Core.Repositories;
=======
using TareasList.Core.Repositories;
using TareasList.Infrastructure.Data;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2

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
<<<<<<< HEAD
            
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
=======
            services.AddControllers();
            services.AddDbContext<TareaListContext>(option =>
             option.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddTransient<ITareaRepository, TareaRespository>();
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
