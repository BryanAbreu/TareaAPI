using FluentValidation.AspNetCore;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
=======
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
<<<<<<< HEAD
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;
using TareasList.Core.Interfaces;
using TareasList.Core.Services;
using TareasList.Infrastructure.Data;
using TareasList.Infrastructure.Filters;
using TareasList.Infrastructure.Repositories;
using WorksList.Core.Repositories;
=======
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
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b

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
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
            services.AddTransient<ILoginService, LoginService>();


            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Authentication:Issuer"],
                    ValidAudience = Configuration["Authentication:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Authentication:SecretKey"]))
                };
            });


            services.AddMvc(options =>
            {
                options.Filters.Add<ValidationFilter>();
            })
            .AddFluentValidation(options =>
            {
              options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
=======
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
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
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

            app.UseAuthentication();
            app.UseAuthorization();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
