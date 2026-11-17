using Autoszerelo.Api.Data;
using Microsoft.EntityFrameworkCore;

/*Alkalmazás belépési pontja/ mint a springboot main osztálya
 a .NET nem keresi meg magtól a @Service szerű osztályokat, mindet regisztálni kell itt
 Élettartam emlékeztető: AddScoped egy HTTP kérésen belül egy példány (@ReguestScope webfejlesztésből
 AddSingleton: egy példány az egész alkalmazásra (@Application javabol esetleg?)
 AddTransient Minden kérésnél új példány  
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("AutoszereloDb")));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();