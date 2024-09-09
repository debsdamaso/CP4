using CP4.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra o serviço de consumo da API externa
builder.Services.AddHttpClient<ICountryService, CountryService>();

// Adiciona o suporte a controladores
builder.Services.AddControllers();

var app = builder.Build();

// Configuração do pipeline HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia os controladores
app.MapControllers();

app.Run();
