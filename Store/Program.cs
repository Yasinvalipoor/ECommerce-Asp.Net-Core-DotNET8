using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Operation;

var builder = WebApplication.CreateBuilder(args);

var Cnn = builder.Configuration.GetConnectionString("CnnStr");
builder.Services.AddDbContext<PersonDbContext>(options => options.UseSqlServer(Cnn));
builder.Services.AddScoped<IPeopleReader,ConcreteReader>();

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Pagination","/{Controller=Home}/{Action=Index}/Page{PageNumber}");
    endpoints.MapDefaultControllerRoute();
});
//کد بالا چنین نقشه‌ای ایجاد میکند
//{controller=home}/{action=index}/{id?}



//Tab ==>
//Shift + Tab <==



app.Run();
