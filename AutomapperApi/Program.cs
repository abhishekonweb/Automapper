using AutomapperApi.Models;
using AutomapperApi.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<StudentStoreDatabase>(builder.Configuration.GetSection(nameof(StudentStoreDatabase)));
builder.Services.AddSingleton<IStudentStoreDatabase>(sp => sp.GetRequiredService<IOptions<StudentStoreDatabase>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("StudentStoreDatabase:Connectionstring")));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<Icreate, Createstudent>();

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

app.Run();
