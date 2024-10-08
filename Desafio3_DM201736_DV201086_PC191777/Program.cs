using Desafio3.Models;
using Desafio3_DM201736_DV201086_PC191777.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurando entity
builder.Services.AddDbContext<RecetaDBContext>(options =>
         options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<RecetaDBContext>()
    .AddApiEndpoints();

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapIdentityApi<Usuario>();
app.Run();
