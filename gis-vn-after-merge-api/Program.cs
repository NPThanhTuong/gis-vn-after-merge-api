using gis_vn_after_merge_api.Data;
using gis_vn_after_merge_api.Middlewares;
using gis_vn_after_merge_api.Repositories;
using gis_vn_after_merge_api.Repositories.Implement;
using gis_vn_after_merge_api.Services;
using gis_vn_after_merge_api.Services.Implement;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Database Connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
		x => x.UseNetTopologySuite()));

// Repository
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();

// Service
builder.Services.AddScoped<IProvinceService, ProvinceService>();

// Add AutoMapper
builder.Services.AddAutoMapper(cfg =>
		cfg.LicenseKey = builder.Configuration["AutoMapper:LicenseKey"],
	typeof(Program));

var app = builder.Build();

// Custom middleware
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) app.MapOpenApi();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();