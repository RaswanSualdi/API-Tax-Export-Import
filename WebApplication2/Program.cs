
using Microsoft.EntityFrameworkCore;
using WebApplication2.Database;
using WebApplication2.Interfaces;
using WebApplication2.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ICountryRepository,CountryRepository>();
builder.Services.AddScoped<HarborRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<TransactionRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WebApplication2Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("WebApplication2")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API");
    });
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();

