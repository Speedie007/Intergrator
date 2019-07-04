using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Integrator.Data;
using Integrator.Models.Domain.Authentication;
using Integrator.Web.Services;
using Integrator.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Integrator.Models.ViewModels.EmailSending;

namespace Integrator.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

            services.AddDbContext<ApplicationDbContext>(options =>
                                     options.UseSqlServer(
                                         Configuration.GetConnectionString("DefaultConnection")));


            services.AddIdentity<IntegratorUser, IntegratorRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;
                //options.Tokens.ProviderMap.Add("Default", new TokenProviderDescriptor(typeof(IUserTwoFactorTokenProvider<BeachClubMember>)));
            })
            // .AddDefaultUI(UIFramework.Bootstrap4)
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders(); ;

           

            //services.AddAuthentication("FiverSecurityScheme")
            //       .AddCookie("FiverSecurityScheme", options =>
            //       {
            //           options.AccessDeniedPath = new PathString("/Security/Access");
            //           options.LoginPath = new PathString("/Users/Login");
            //       });

            services.Configure<IdentityOptions>(options =>
            {
                options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;

                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                //options.Password.RequiredUniqueChars = 1;
                

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

           

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
               
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.SameAsRequest;


            });


            services.ConfigureApplicationCookie(options =>
            {

                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
               // options.Cookie.Name = "IntrgratorCookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Authentication/Login";
                options.AccessDeniedPath = "/Authentication/Login";
                // ReturnUrlParameter requires 
                //using Microsoft.AspNetCore.Authentication.Cookies;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
                //options.ForwardSignIn = "/Users/Login";
            });

            services.Configure<DataProtectionTokenProviderOptions>(o =>
            {
                //o.Name = "Default";
                o.TokenLifespan = TimeSpan.FromHours(24);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddHttpContextAccessor();


            return services.ConfigureApplicationServices(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            dbInitializer.Initialize();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Individual}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=LandingPage}/{id?}");

                
            });
        }
    }
}
