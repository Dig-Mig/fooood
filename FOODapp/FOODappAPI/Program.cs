using System.Collections.Immutable;
using DataAcessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDataAcessLayer();
builder.Services.AddAutoMapper(cfg => cfg.LicenseKey = builder.Configuration.GetValue<string>("AutomapperLicense"), typeof(Program));
var test = builder.Configuration.GetValue<string>("AutomapperLicense");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
