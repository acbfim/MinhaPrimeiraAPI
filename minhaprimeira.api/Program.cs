var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/people", () => new[]
{
    new Person("Ana"), new Person("Filipe"), new Person("Emillia")
});

app.MapControllers();

app.Run();

record Person(string Name);
