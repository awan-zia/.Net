var builder = WebApplication.CreateBuilder(args);

// Azure Container Apps ke liye port settings configure karna
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080); // Azure standard port
});

var app = builder.Build();

// Browser par display hone wala output
app.MapGet("/", () => "Welcome to My .NET Website on Azure Container Apps!");

app.Run();
