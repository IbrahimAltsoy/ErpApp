using Microsoft.Extensions.Configuration;

namespace ErpApp.Persistance
{
    //public static class Configuration
    //{
    //    private static readonly IConfigurationRoot _configuration;

    //    static Configuration()
    //    {
    //        try
    //        {
    //            var builder = new ConfigurationBuilder()
    //                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ErpApi"))
    //                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

    //            _configuration = builder.Build();
    //        }            
    //        catch (Exception ex)
    //        {
    //            // Log the exception (if a logging mechanism is in place)
    //            Console.WriteLine($"Error loading configuration: {ex.Message}");
    //            throw;
    //        }
    //    }

    //    public static string ConnectionString => _configuration.GetConnectionString("PostgreSQL");
    //}
}
