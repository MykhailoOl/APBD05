using WebApplication1.Database;
using WebApplication1.Endpoints;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<AnimalRepository>();
builder.Services.AddSingleton<VisitRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapAnimalsEndpoints();

app.MapControllers();

app.Run();
