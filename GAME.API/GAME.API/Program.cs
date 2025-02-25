using GAME.Aplication.Login;
using GAME.Aplication.Register;
using GAME.Domain.Repository;
using GAME.Infra.Repository;
using GAME.Service.Domain.Login;
using GAME.Service.Domain.Register;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILoginDomainService, LoginDomainService>();
builder.Services.AddScoped<IRegisterDomainService, RegisterDomainService>();
builder.Services.AddScoped<ILogin, Login>();
builder.Services.AddScoped<IRegister, Register>();
builder.Services.AddScoped<IRegisterAplication, RegisterAplication>();
builder.Services.AddScoped<ILoginAplication, LoginAplication>();


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
