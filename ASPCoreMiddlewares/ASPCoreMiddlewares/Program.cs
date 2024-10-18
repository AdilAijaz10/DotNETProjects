var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//use to run just 1 middle ware
/*app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcome to ASP .Net6 CORE");
});*/
app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Welcome to ASP .Net6 CORE");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync(" Adil");
});
app.Run();
