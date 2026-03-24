var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ModularPluginWebApi v1");

    // 🔥 ROOT FIX
    c.RoutePrefix = string.Empty;
});

// 🔥 ROOT REDIRECT (IMPORTANT)
app.MapGet("/", () => Results.Redirect("/"));

// Auth (if you added login)
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Run($"http://0.0.0.0:{port}");