using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region

string connectionString = builder.Configuration["ConnectionStrings:ArhDBConnectionString"]!;

//// Configure the SQLite connection
//var connection = new SqliteConnection(connectionString);
//connection.Open();

//// Set journal mode to DELETE using PRAGMA statement
//using (var command = connection.CreateCommand())
//{
//    command.CommandText = "PRAGMA journal_mode = DELETE;";
//    command.ExecuteNonQuery();
//}

//builder.Services.AddDbContext<ApplicationDbContext>(dbContextOptions => dbContextOptions.UseSqlite(connection, options =>
//        options.MigrationsAssembly("Infrastructure")));

var connection = new SqliteConnection(connectionString);
connection.Open();

using (var command = connection.CreateCommand())
{
    command.CommandText = "PRAGMA journal_mode = DELETE;";
   command.ExecuteNonQuery();
}

builder.Services.AddDbContext<ApplicationDbContext>(dbContextOptions =>
    dbContextOptions.UseSqlite(connection, options =>
        options.MigrationsAssembly("Infrastructure")));

//builder.Services.AddDbContext<ApplicationDbContext>(dbContextOptions => dbContextOptions.UseSqlite(connection, options =>
  //     options.MigrationsAssembly("Infrastructure")));

#endregion

builder.Services.AddScoped<IJugadorService, JugadorService>();
builder.Services.AddScoped<IJugadorRepository, JugadorRepository>();

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
