using Skinet.Application.Extensions;
using Skinet.Data.Extensions;
using Skinet.Infra.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddStoreContext(builder.Configuration);
builder.Services.AddRepository();
builder.Services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseExceptionMiddleware();

app.UseCors(x =>
    x.AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:5119", "https://localhost:7249")
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MigrateStore();

app.Run();
