using OrderManagement.Logic;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions
            .Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions
            .PropertyNameCaseInsensitive = true;
        options.JsonSerializerOptions
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    })
    .AddXmlDataContractSerializerFormatters();

//builder.Services.AddScoped<IOrderManagementLogic, IOrderManagementLogic>();
builder.Services.AddSingleton<IOrderManagementLogic, OrderManagementLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
