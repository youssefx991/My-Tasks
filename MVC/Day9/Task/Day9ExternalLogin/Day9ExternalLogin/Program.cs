using Day9ExternalLogin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();


builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "439592204355-7uqgqu9t4bsltd5bag5lveeq9o3b3pi6.apps.googleusercontent.com";
    options.ClientSecret = "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";
}).AddFacebook(options=>
{
    options.ClientId = "1705682263935158";
    options.ClientSecret = "4370545461cf4749ae4dee8367a2ecf3";
}).AddTwitter(options =>
{
    options.ConsumerKey = "gIM88v3rrIAMfIiwJK5PiQIik";
    options.ConsumerSecret = "lzuHdtJ2hgblIZC9K5j4wEy2OesRNrzQwcPeoE4I7YgAUIUVJj";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
