using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using InventoryApp.Data;
using InventoryDataAccess;
using Microsoft.EntityFrameworkCore;
using InventoryBusiness.Contracts;
using InventoryBusiness;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InventoryContext>(options =>
{
    options.UseSqlServer(connectionString, assembly => assembly.MigrationsAssembly(typeof(InventoryContext).Assembly.FullName));
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<InventorySeeder>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IInoutRepository, InoutRepository>();
builder.Services.AddScoped<IStorageRepository, StorageRepository>();
builder.Services.AddScoped<IWarehouseRepository, WarehouseRepository>();
builder.Services.AddScoped<IUnitOfWork, InventoryUnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MigrateDatabase();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

