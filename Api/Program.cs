using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


WebApplicationBuilder? builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.MapControllers();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/dinceryigit", async context =>
    {
        await context.Response.WriteAsync("<a href=https://github.com/DincerY>GitHub</a>");
    });
});

app.Run();


//class Program
//{
//    static void Main()
//    {
//        CreateHostBuilder().Build().Run();
//    }

//    public static IHostBuilder CreateHostBuilder() =>
//        Host.CreateDefaultBuilder()
//            .ConfigureWebHostDefaults(webBuilder =>
//            {
//                webBuilder.UseStartup<Startup>();
//            });
//}

//public class Startup
//{
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddControllers();
//    }

//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//        if (env.IsDevelopment())
//        {
//            app.UseDeveloperExceptionPage();
//        }

//        app.UseRouting();

//        app.UseEndpoints(endpoints =>
//        {
//            endpoints.MapGet("/", async context =>
//            {
//                await context.Response.WriteAsync("Merhaba, bu bir RESTful API!");
//            });

//            endpoints.MapGet("/api/echo", async context =>
//            {
//                await context.Response.WriteAsync("Bu bir echo endpoint'idir.");
//            });
//            endpoints.MapControllers();
//        });
//    }
//}




