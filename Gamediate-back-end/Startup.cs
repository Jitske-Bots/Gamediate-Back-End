using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamediate_back_end.DAL;
using Microsoft.EntityFrameworkCore;
using Gamediate_back_end.BLL;
using Newtonsoft;

namespace Gamediate_back_end
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsDevelopment", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddControllers();

            services.AddDbContext<GameContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            //addScoped creates an instance
            services.AddSignalR();

            services.AddScoped<IGameDAL, GameDAL>();
            services.AddScoped<GameBLL>();

            services.AddScoped<IOrderDAL, OrderDAL>();
            services.AddScoped<OrderBLL>();

            services.AddScoped<IOrderItemDAL, OrderItemDAL>();
            services.AddScoped<OrderItemBLL>();

            services.AddScoped<IAccountDAL, AccountDAL>();
            services.AddScoped<AccountBLL>();

            services.AddScoped<IWishlist, WishlistDAL>();
            services.AddScoped<WishlistBLL>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
            app.UseCors("CorsDevelopment");
            app.UseCors(options => options.AllowAnyOrigin());

            app.UseAuthorization();

            app.UseWebSockets(new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromSeconds(120),
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });






        }
    }
}
