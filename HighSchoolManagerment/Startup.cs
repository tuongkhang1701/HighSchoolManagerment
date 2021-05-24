using AutoMapper;
using HighSchoolManagerment.Application.Implements;
using HighSchoolManagerment.Application.Interfaces;
using HighSchoolManagerment.Data.EF;
using HighSchoolManagerment.Implements;
using HighSchoolManagerment.Interfaces;
using HighSchoolManagerment.IServices;
using HighSchoolManagerment.ServiceImplements;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;

namespace HighSchoolManagerment
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
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Startup));
            //Register mapper
            /*var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ViewModelToEntityMappingProfile());
                cfg.AddProfile(new EntityToViewModelMappingProfile());
            });*/

            /*IMapper mapper = mapperConfig.CreateMapper();*/
            /*services.AddSingleton(mapper);*/

            services.AddMvc()
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddScoped<DbInitializer>();

            services.AddTransient<INguoiDung, NguoiDungImp>();
            services.AddTransient<IChucNang, ChucNangImp>();
            services.AddTransient<IVaiTro, VaiTroImp>();
            services.AddTransient<IMonHoc, MonHocImp>();
            services.AddTransient<IBangDiem, BangDiemImp>();
            services.AddTransient<ILop, LopImp>();
            services.AddTransient<ITKB, TKBImp>();
            services.AddTransient<INamHoc, NamHocImp>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area:exists}/{controller=TrangChu}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "adminLogin",
                    pattern: "{area:exists}/{controller=Login}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                   name: "adminUser",
                   pattern: "{area:exists}/{controller=User}/{action=Index}/{id?}");
            });

            app.Run(async (HttpContext context) =>
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync("Page not found!");
            });
        }
    }
}