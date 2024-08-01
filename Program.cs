using TradeCategoryUbsAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Usando JSON padrão do ASP.NET Core
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<ITradeCategorizationService, TradeCategorizationService>();
builder.Services.AddSingleton<CategorizeTradesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trade Categorization API V1");
        //c.RoutePrefix = string.Empty; // Define o Swagger UI como página inicial
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
