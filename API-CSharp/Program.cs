using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// <<< Método criado para fazer funionar a API
builder.Services.AddDbContext<AgendaContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
// << acima método criado para API


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
