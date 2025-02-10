var builder = WebApplication.CreateBuilder(args);

//Aktivera MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Aktivera statiska filer
app.UseStaticFiles();

//Aktivera routing
app.UseRouting();

//Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id}"
);

app.Run();
