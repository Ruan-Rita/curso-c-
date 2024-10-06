using Microsoft.EntityFrameworkCore;
using sharp_project.Model.Context;
using sharp_project.Business;
using sharp_project.Business.Implementations;
using sharp_project.Repository;
using sharp_project.Repository.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Depency Injection
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

var dbConnection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MysqlContext>(options => options.UseMySql(dbConnection, new MySqlServerVersion(new Version(8,2))));

builder.Services.AddApiVersioning();

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
