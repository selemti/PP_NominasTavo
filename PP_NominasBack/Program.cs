using Microsoft.OpenApi.Models;
using MongoDB.Driver;
using PP_NominasBack.Profiles;
using PP_NominasBack.Configuracion;

var builder = WebApplication.CreateBuilder(args);

// 1. Configuración Básica
builder.Services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

// 2. AutoMapper
builder.Services.AddAutoMapper(typeof(CatalogosProfile));

// 3. MongoDB - Inyección con configuración fuerte
builder.Services.Configure<MongoConnectionSettings>(builder.Configuration.GetSection("MongoConnection"));
var mongoSettings = new MongoConnectionSettings();
builder.Configuration.GetSection("MongoConnection").Bind(mongoSettings);

builder.Services.AddSingleton<IMongoClient>(_ => new MongoClient(mongoSettings.ConnectionString));
builder.Services.AddScoped<IMongoDatabase>(sp =>
{
    var client = sp.GetRequiredService<IMongoClient>();
    return client.GetDatabase(mongoSettings.Database);
});

// 4. CORS (según entorno)
builder.Services.AddCors(options =>
{
    options.AddPolicy("Default", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// 5. Swagger
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "PP_NominasBack", Version = "v1" }));

var app = builder.Build();

// Pipeline
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));

app.UseHttpsRedirection();
app.UseCors("Default");
app.UseAuthorization();
app.MapControllers();

app.Run();
