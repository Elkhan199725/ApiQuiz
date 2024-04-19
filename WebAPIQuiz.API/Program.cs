using FluentAssertions.Common;
using FluentValidation;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebAPIQuiz.Business;
using WebAPIQuiz.Business.DTOs.BlogDtoValidation;
using WebAPIQuiz.Business.Helpers.Extension;
using WebAPIQuiz.Core;
using WebAPIQuiz.Data;
using WebAPIQuiz.Data.Contexts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddValidatorsFromAssemblyContaining<BlogCreateDtoValidator>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddRepositories();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<WebAPIQuizDbContext>(options=> 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
