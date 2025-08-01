using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

// ...existing code...
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
// ...existing code...