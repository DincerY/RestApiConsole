using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main()
    {
        CreateHostBuilder().Build().Run();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        // Gerekirse servis ekleyebilirsiniz.
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        // Endpoint tanımlamalarını ekleyin
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Merhaba, bu bir RESTful API!");
            });

            endpoints.MapGet("/api/echo", async context =>
            {
                // Örnek bir API endpoint'i
                await context.Response.WriteAsync("Bu bir echo endpoint'idir.");
            });
            endpoints.MapControllers();
        });
    }
}

[ApiController]
[Route("api/[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Bu bir örnek controller metodu.");
    }
}


[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<User> GetAllUser()
    {
        global::User user = new User();
        user.Id = 1;
        user.Name = "Dincer";
        return Ok(user);
    }

    
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

