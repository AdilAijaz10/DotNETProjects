var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "Default",
    // pattern: "{controller=UserController1}/{action=Index}/{Id?}"
    pattern: "{controller=Home}/{action=About}/{Id?}"
    );
app.Run();
