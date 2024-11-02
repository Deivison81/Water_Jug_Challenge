using Water_Jug_Challenge.Application;
using Water_Jug_Challenge.Application.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//injection of dependencies
builder.Services.AddAplicationServices();

Stepsby step1 = new Stepsby(1);
Stepsby step2 = new Stepsby(2);
Stepsby step3 = new Stepsby(3);
Stepsby step4 = new Stepsby(4);
Stepsby step5 = new Stepsby(5);
Stepsby step6 = new Stepsby(6);
Stepsby step7 = new Stepsby(7);
Stepsby step8 = new Stepsby(8);
Stepsby step9 = new Stepsby(9);

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
