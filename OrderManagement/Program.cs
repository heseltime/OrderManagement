using OrderManagement.Logic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//builder.Services.AddScoped<IOrderManagementLogic, IOrderManagementLogic>();
builder.Services.AddSingleton<IOrderManagementLogic, OrderManagementLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
