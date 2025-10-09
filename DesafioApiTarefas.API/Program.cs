using DesafioApiTarefas.Domain.Interfaces.Repositories;
using DesafioApiTarefas.Domain.Interfaces.Services;
using DesafioApiTarefas.Domain.Services;
using DesafioApiTarefas.Domain.Validations;
using DesafioApiTarefas.Infra.Repositories;
using DesafioApiTarefas.Infra.Contexts;  
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApiContext>(options =>
{    
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ITarefaService, TarefaService>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<TarefaValidator>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
