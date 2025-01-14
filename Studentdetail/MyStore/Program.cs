using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyStore.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddDbContext<Databasecls>(options =>
//       options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<Databasecls>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
