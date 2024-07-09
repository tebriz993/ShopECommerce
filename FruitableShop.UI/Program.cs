using Microsoft.EntityFrameworkCore;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Service;
using ShopECommerce.BusinessLogic.Ioc;
using ShopECommerce.BusinessLogic.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<ShopECommerceDbContext>(options => 
                                   options.UseSqlServer(builder.Configuration.GetConnectionString("Local")));

//This class will be add all services
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "test",
//    pattern: "{controller}/{action}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
