using ErpApp.Application;
using ErpApp.Infrastructure;
using ErpApp.Infrastructure.Hubs;
using ErpApp.Persistance;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddPersistanceServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:4200", "http://localhost:4200") // Kullan�lacak origins'leri buraya ekleyin
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.MapHubs();
app.Run();

// buray� sor ben bunu Infrastructure �zerinde yapmak istiyorum
public static class HubMapsRegistration
{
    public static void MapHubs(this WebApplication webApplication)
    {        
        webApplication.MapHub<CretateUserHub>("/createUser-hub");
        webApplication.MapHub<LoginUserHub>("/loginUser-hub");
    }
}