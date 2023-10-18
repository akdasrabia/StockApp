using Microsoft.EntityFrameworkCore;
using StockApp.Blazor.Services;

using StokApp.Blazor.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();




//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
//builder.Services.AddScoped<IRecordRepository, RecordRepository>();
//builder.Services.AddScoped<IRecordService, RecordService>();
//builder.Services.AddScoped<IStockRepository, StockRepository>();
//builder.Services.AddScoped<IStockService, StockService>();
//builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddScoped<RecordService>();




builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

//builder.Services.AddDbContext<AppDbContext>(x =>
//{
//    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
//    {
//        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
//    });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
