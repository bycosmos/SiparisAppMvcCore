using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiparisApp.Business.Abstract;
using SiparisApp.Business.Concrete;
using SiparisApp.Dal.Abstract;
using SiparisApp.Dal.Concrete.EfCore;
using SiparisApp.Entities;
using SiparisApp.Web.EmailServices;
using SiparisApp.Web.Identity;
using SiparisApp.Web.Middlewares;

namespace SiparisApp.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.Configure<IdentityOptions>(options =>
            {
              

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true; 
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

               
                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };


            });







            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<IUrunDal, EfCoreUrunDal>();
            services.AddScoped<IBasketDal, EfCoreBasketDal>();
            services.AddScoped<IOrderDal, EfCoreOrderDal>();
            services.AddScoped<ISliderDal, EfCoreSliderDal>();
            services.AddScoped<IKategoriDal, EfCoreKategoriDal>();
            services.AddScoped<IIllerDal, EfCoreIllerDal>();
            services.AddScoped<IBayilerDal, EfCoreBayilerDal>();
            services.AddScoped<ISepetDal, EfCoreSepetDal>();






            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<IKategoriService, KategoriManager>();
            services.AddScoped<IIllerService, IllerManager>();
            services.AddScoped<IBayilerService, BayilerManager>();
            services.AddScoped<ISepetService, SepetManager>();




            services.AddScoped<IMyEmailSender, SmtpEmailSender>(
                i => new SmtpEmailSender(
                   "smtp.gmail.com",
                   587,
                    true,
                   "aliveliav122212121121@gmail.com",
                    "muhammetB1")
                );

            services.AddControllersWithViews();
               
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser>userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

           
            app.CustomStaticFiles();
            app.UseAuthentication();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "galeri",
                  pattern: "Galeri",
                  defaults: new { controller = "Galeri", action = "Galeri" });

                endpoints.MapControllerRoute(
                  name: "bayiler",
                  pattern: "Bayiler",
                  defaults: new { controller = "Bayi", action = "Bayiler" });
                endpoints.MapControllerRoute(
                  name: "iletisim",
                  pattern: "Iletisim",
                  defaults: new { controller = "Iletisim", action = "Iletisim" });
                endpoints.MapControllerRoute(
                  name: "urun",
                  pattern: "Urunler",
                  defaults: new { controller = "Urun", action = "Urunler" });
                endpoints.MapControllerRoute(
               name: "urunekle",
               pattern: "UrunEkle",
               defaults: new { controller = "Urun", action = "UrunEkle" });
                endpoints.MapControllerRoute(
               name: "urunduzenlesil",
               pattern: "UrunDuzenleSil",
               defaults: new { controller = "Urun", action = "UrunDuzenleSil" });
                endpoints.MapControllerRoute(
         name: "urun",
         pattern: "Urun",
         defaults: new { controller = "Urun", action = "Urun" });
                endpoints.MapControllerRoute(
                name: "kategoriekle",
                pattern: "KategoriEkle",
                defaults: new { controller = "Urun", action = "KategoriEkle" });



                endpoints.MapControllerRoute(
                  name: "kategori",
                  pattern: "KategoriListele",
                  defaults: new { controller = "Urun", action = "KategoriListele" });

                endpoints.MapControllerRoute(
                  name: "kategori",
                  pattern: "KategoriSil",
                  defaults: new { controller = "Urun", action = "KategoriSil" });
                endpoints.MapControllerRoute(
                name: "kategori",
                pattern: "KategoriDuzenle",
                defaults: new { controller = "Urun", action = "KategoriDuzenle" });

                endpoints.MapControllerRoute(
            name: "sepet",
            pattern: "Sepetim",
            defaults: new { controller = "Sepet", action = "Sepetim" });

                endpoints.MapControllerRoute(
                  name: "urun",
                  pattern: "Hakkimizda",
                  defaults: new { controller = "Hakkimizda", action = "Hakkimizda" });

                endpoints.MapControllerRoute(
                  name: "bayi",
                  pattern: "IllerListesi",
                  defaults: new { controller = "Bayi", action = "IllerListesi" });
                endpoints.MapControllerRoute(
              name: "bayi",
              pattern: "IlEkle",
              defaults: new { controller = "Bayi", action = "IlEkle" });
                endpoints.MapControllerRoute(
            name: "bayi",
            pattern: "IlDuzenle",
            defaults: new { controller = "Bayi", action = "IlDuzenle" });
                endpoints.MapControllerRoute(
                  name: "bayi",
                  pattern: "BayiListesi",
                  defaults: new { controller = "Bayi", action = "BayiListesi" });

                endpoints.MapControllerRoute(
           name: "bayi",
           pattern: "BayiEkle",
           defaults: new { controller = "Bayi", action = "BayiEkle" }); 
                endpoints.MapControllerRoute(
           name: "bayi",
           pattern: "BayiDuzenle",
           defaults: new { controller = "Bayi", action = "BayiDuzenle" });







                endpoints.MapControllerRoute(
                   name: "kayit",
                   pattern: "Register",
                   defaults: new { controller = "Account", action = "Register" });
                endpoints.MapControllerRoute(
                   name: "giris",
                   pattern: "Login",
                   defaults: new { controller = "Account", action = "Login" });
                endpoints.MapControllerRoute(
                   name: "home",
                   pattern: "Anasayfa",
                   defaults: new { controller = "Anasayfa", action = "Anasayfa" });
                endpoints.MapControllerRoute(
                  name: "home",
                  pattern: "SliderEkle",
                  defaults: new { controller = "Anasayfa", action = "SliderEkle" });
                endpoints.MapControllerRoute(
                  name: "sliderdüzenle",
                  pattern: "SliderDüzenle",
                  defaults: new { controller = "Anasayfa", action = "SliderDüzenle" });

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");

                


            });
           



            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();
        }
    }
}
