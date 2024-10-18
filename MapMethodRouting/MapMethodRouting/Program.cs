var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
//app.Map("/Home", () => "Hello World! - Map");
//app.MapGet("/Home", () => " Hello World - Get");
//app.MapPost("/Home", () => " Hello World - Post");
//app.MapPut("/Home", () => " Hello World - Put");
//app.MapDelete("/Home", () => " Hello World - Delete");

app.UseEndpoints(endpoints =>
{
    try
    {
        endpoints.MapGet("/Home", async (context) =>
       {
           await context.Response.WriteAsync("Hello World - Get");
       });
        endpoints.MapPost("/Home", async (context) =>
        {
            await context.Response.WriteAsync("Hello World - Post");
        });
        endpoints.MapPut("/Home", async (context) =>
        {
            await context.Response.WriteAsync("Hello World - Get");
        });
        endpoints.MapDelete("/Home", async (context) =>
        {
            await context.Response.WriteAsync("Hello World - Get");
        });
    }
    catch (Exception ex){ 
    }
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello World - Get");
});
