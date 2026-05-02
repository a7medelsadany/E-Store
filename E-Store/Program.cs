
using E_Store.Extentions;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace E_Store
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            //---------------------------------------------------------------------------
            #region Configure Service
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddCoreService();
            builder.Services.AddJWTService(builder.Configuration);


            #endregion
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            
            builder.Services.AddMemoryCache();

            builder.Services.AddSession();
            builder.Services.AddDistributedMemoryCache(); // ضروري لتخزين بيانات الـ Session


            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider
                    .GetRequiredService<EStoreDbContext>();
                db.Database.Migrate();
            }


            var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
            app.Urls.Add($"http://+:{port}");


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            
            app.MapControllers();

            app.Run();
        }
    }
}
