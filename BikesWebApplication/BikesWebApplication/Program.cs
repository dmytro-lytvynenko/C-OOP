using BikesWebApplication;
using BikesWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext <DBLytvynenkoContext> (option => option.UseSqlServer(
       builder.Configuration.GetConnectionString("DefaultConnection")

));
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext <IdentityContext> (option => option.UseSqlServer(
       builder.Configuration.GetConnectionString("IdentityConnection")
));
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity <User, IdentityRole> ().AddEntityFrameworkStores <IdentityContext> ();
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<User>> ();
        var rolesManager = services.GetRequiredService<RoleManager<IdentityRole> ();
        await RoleInitializer.InitializeAsync(userManager, rolesManager);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService <ILogger<Program>> ();
        logger.LogError(ex, "An error occurred while seeding the database." +DateTime.Now.ToString());
    }
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/ Home / Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication(); //���������� ��������������
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
name: "default ",
pattern: "{ controller = Home}/{ action = Index}/{ id ?}");
app.Run();