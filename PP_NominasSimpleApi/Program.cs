using Microsoft.OpenApi.Models;
using MongoDB.Driver;
using PP_NominasBack.Configuracion;
using PP_NominasBack.Models.Catalogos.Asistencia;
using PP_NominasBack.Dtos.Catalogos.Asistencia;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "PP_NominasSimpleApi", Version = "v1" }));

builder.Services.Configure<MongoConnectionSettings>(builder.Configuration.GetSection("MongoConnection"));
var mongoSettings = new MongoConnectionSettings();
builder.Configuration.GetSection("MongoConnection").Bind(mongoSettings);

builder.Services.AddSingleton<IMongoClient>(_ => new MongoClient(mongoSettings.ConnectionString));
builder.Services.AddScoped<IMongoDatabase>(sp =>
{
    var client = sp.GetRequiredService<IMongoClient>();
    return client.GetDatabase(mongoSettings.Database);
});

builder.Services.AddAutoMapper(typeof(PP_NominasBack.Profiles.CatalogosProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("Default", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PP_NominasSimpleApi v1"));
app.UseCors("Default");

var mapper = app.Services.GetRequiredService<IMapper>();

app.MapGet("/api/horariosempleado", async (IMongoDatabase db) =>
{
    var collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
    var entities = await collection.Find(_ => true).ToListAsync();
    return Results.Ok(mapper.Map<IEnumerable<HorarioEmpleadoDto>>(entities));
});

app.MapGet("/api/horariosempleado/{id}", async (string id, IMongoDatabase db) =>
{
    var collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
    var entity = await collection.Find(x => x.Id == id).FirstOrDefaultAsync();
    return entity == null ? Results.NotFound() : Results.Ok(mapper.Map<HorarioEmpleadoDto>(entity));
});

app.MapPost("/api/horariosempleado", async (HorarioEmpleadoDto dto, IMongoDatabase db) =>
{
    var collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
    var entity = mapper.Map<HorarioEmpleado>(dto);
    await collection.InsertOneAsync(entity);
    return Results.Created($"/api/horariosempleado/{entity.Id}", mapper.Map<HorarioEmpleadoDto>(entity));
});

app.MapPut("/api/horariosempleado/{id}", async (string id, HorarioEmpleadoDto dto, IMongoDatabase db) =>
{
    var collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
    var entity = mapper.Map<HorarioEmpleado>(dto);
    entity.Id = id;
    var result = await collection.ReplaceOneAsync(x => x.Id == id, entity);
    return result.MatchedCount > 0 ? Results.NoContent() : Results.NotFound();
});

app.MapDelete("/api/horariosempleado/{id}", async (string id, IMongoDatabase db) =>
{
    var collection = db.GetCollection<HorarioEmpleado>("HorariosEmpleado");
    var result = await collection.DeleteOneAsync(x => x.Id == id);
    return result.DeletedCount > 0 ? Results.NoContent() : Results.NotFound();
});

app.Run();
