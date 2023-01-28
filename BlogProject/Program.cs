using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // session kullanamk icin servis ekledik
builder.Services.AddMvc(Config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    Config.Filters.Add(new AuthorizeFilter(policy));
}); // proje bazinda authorizaton gereklili�i k�lan kod

builder.Services.AddMvc();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => { x.LoginPath = "/Login/Index"; }); // Giri� yapmayan kullan�c�lar�n yetkisiz olduklar� sayfalara eri�mek istediklerinde onlar� login sayfas�na y�nlendiren kod

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1","?code={0}"); // Sayfa bulunamad� gibi hatalar� istedi�imiz hata sayfas�na y�nlendirmek i�in
app.UseSession(); // session kullanmak icin configure ekledik
app.UseAuthentication(); //  
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
