using Crud_mvc_db_mysql_net6.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); 

var app = builder.Build();


builder.Services.AddDbContext<Context>
    (options => options.UseMySql(
            "server=127.0.0.1; uid=mac_win; pwd=M123456*; database=Crud_mvc_db_mysql_net6",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"),

            mySqlOptions =>
            {

                mySqlOptions.EnableRetryOnFailure(
                maxRetryCount: 2,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            }

            ));


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this fo r production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
