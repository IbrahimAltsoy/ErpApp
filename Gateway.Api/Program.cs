using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot();
builder.Configuration.AddJsonFile("ocelot.json");
//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.ListenAnyIP(5000); // HTTP
//    options.ListenAnyIP(5001, listenOptions =>
//    {
//        listenOptions.UseHttps(); // HTTPS
//    });
//});
var app = builder.Build();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.UseOcelot();

app.Run();
