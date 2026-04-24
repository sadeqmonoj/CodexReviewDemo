var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.MapGet("/", () =>
{
    return "UP";
});


app.MapPost("/login", (LoginRequest request) =>
{
    // This is just a placeholder for demonstration purposes.
    // In a real application, you would validate the username and password against a database or authentication service.
    if (request.Username == "admin" && request.Password == "password")
    {
        return Results.Ok("Login successful");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.Run();


public record LoginRequest(string Username, string Password);

