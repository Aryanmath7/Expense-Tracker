using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//DI for DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DevConnection"),
        new MySqlServerVersion(new Version(8, 0, 33))));

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTg2NDIwOEAzMjMxMmUzMTJlMzMzNVhTVFdTOTM4TDU0eFJRdzluN2JYS09iOVlhQXAvenRXd3R1d3NPWTE0N1E9;Mgo+DSMBaFt+QHFqVkNrWU5AaV1CX2BZeFlzRGlZeE4QCV5EYF5SRHJdRVxrTH9TcUZrXn8=;Mgo+DSMBMAY9C3t2VFhhQlJBfVpdWXxLflF1VWVTel96dFJWACFaRnZdQV1nS3lSfkBiWXhacHdV;Mgo+DSMBPh8sVXJ1S0d+X1RPc0BGQmFJfFBmQ2lcflRwc0UmHVdTRHRcQllhTn9bc0RjXntfeHQ=;MTg2NDIxMkAzMjMxMmUzMTJlMzMzNW1nZHhhTU9RaDRoNlNLZmFSWGExY1lFRFo0VVVTK3NRSFp4anUrSHR0NDQ9;NRAiBiAaIQQuGjN/V0d+XU9Hc1RHQmdWfFN0RnNfdVtxflVBcDwsT3RfQF5jTXxUd01mWH9ZdHFSRg==;ORg4AjUWIQA/Gnt2VFhhQlJBfVpdWXxLflF1VWVTel96dFJWACFaRnZdQV1nS3lSfkBiWXhad3dV;MTg2NDIxNUAzMjMxMmUzMTJlMzMzNU54R1VSVXNNL3doZjhOVHlpc2V6Q01NSXdDbjVWaU1VbGRrdGlPOGlIdFE9;MTg2NDIxNkAzMjMxMmUzMTJlMzMzNUxheGlFeWpENElzdS8reC9xNjFsVlZHdHJHMW1TQ1luR3BuSTFIYXZLWlU9;MTg2NDIxN0AzMjMxMmUzMTJlMzMzNUd6ZWJHMzlmTllsTFY3cXVSNHBOQktNeDVCaU56VWZyaS91SG5GODlITnc9;MTg2NDIxOEAzMjMxMmUzMTJlMzMzNWE0SU1rNHNFS1c5Z3lGU2NuWFlsUTRNSGQ0eFY1T3RBZFdmQzBhSGhSMmc9;MTg2NDIxOUAzMjMxMmUzMTJlMzMzNVhTVFdTOTM4TDU0eFJRdzluN2JYS09iOVlhQXAvenRXd3R1d3NPWTE0N1E9");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
