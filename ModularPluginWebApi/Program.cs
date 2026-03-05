var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ModularPluginWebApi v1");

    // index.html maintain panna
    c.RoutePrefix = "index";

    // click panna URL update aagum
    c.EnableDeepLinking();
});

app.MapControllers();
app.Run();
