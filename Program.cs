using Eaigle.SmokeEvent.API.Mapper;
using Eaigle.SmokeEvent.API.Model;
using Eaigle.SmokeEvent.API.Repositories;
using Eaigle.SmokeEvent.API.Repositories.Interfaces;
using Eaigle.SmokeEvent.API.SignalR.Hubs;
using EaigleWebService.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Maps));

builder.Services.AddScoped(typeof(IRepositoryBaseAsync<>), typeof(RepositoryBaseAsync<>));
builder.Services.AddScoped<ISmokeEventRepository, SmokeEventRepository>();

// SignalR
builder.Services.AddSignalR();
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
            builder =>
            {
                builder.AllowAnyHeader()
                       .AllowAnyMethod()
                       .SetIsOriginAllowed((host) => true)
                       .AllowCredentials();
            }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// SignalR configuration
app.UseCors("CorsPolicy");
app.MapHub<HubClient>("/SmokeAlerts");

app.Run();