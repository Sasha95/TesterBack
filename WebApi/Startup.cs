﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Domain;
using WebApi.Models;
using Microsoft.AspNetCore.Identity;
using WebApi.Models.Users;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
>>>>>>> 5f991939d27868d48c0aadf9e3ade27fa2069771

namespace WebApi
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
            services.AddMvc();

            services.AddDbContext<ApplicationContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

=======
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(option =>
            //    {
            //        option.RequireHttpsMetadata = true;
            //        option.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuer = true,
            //            ValidIssuer = AuthOptions.ISSUER,
            //            ValidateAudience = true,
            //            ValidAudience = AuthOption.AUDIENCE,
            //            ValidateLifetime = true,
            //            IssuerSigningKey = AuthOption.GetSymmetricSecurityKey(),
            //            ValidateIssuerSigningKey = true
            //        };
            //    });

            //???
            services.AddDbContext<ApplicationContext>
                (options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });

            //services.AddIdentity<UserManager<User>, IdentityRole>(option =>
            //    {
            //        option.Password.RequireDigit = false;
            //        option.Password.RequiredLength = 6;
            //        option.Password.RequireNonAlphanumeric = false;
            //        option.Password.RequireUppercase = false;
            //        option.Password.RequireLowercase = false;
            //    })
            //    .AddEntityFrameworkStores<ApplicationContext>();

            services.AddMvc();
>>>>>>> 5f991939d27868d48c0aadf9e3ade27fa2069771
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvcWithDefaultRoute();
            app.UseDefaultFiles();
            app.UseStaticFiles();
<<<<<<< HEAD
=======
            //app.UseAuthentication();
>>>>>>> 5f991939d27868d48c0aadf9e3ade27fa2069771
            app.UseMvc();
        }
    }
}
