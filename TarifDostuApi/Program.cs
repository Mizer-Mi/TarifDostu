using Newtonsoft.Json.Converters;
using NLog;
using Services.Contracts;
using System.Reflection;
using TarifDostuApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
    .AddNewtonsoftJson(options=>options.SerializerSettings.Converters.Add(new StringEnumConverter()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.ConfigureSqlContext(builder.Configuration);
//Configure
builder.Services.ConfigureRepositoryManager();
builder.Services.RegisterRepositories();
builder.Services.ConfigureServicesManager();
builder.Services.RegisterServices();
builder.Services.ConfigureLoggerService();
// Logger ayarlarý

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerService>();
app.ConfigureExceptionHandler(logger);

if (app.Environment.IsProduction())
{
    app.UseHsts();
}

// Configure the HTTP request pipeline.
if (true)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
