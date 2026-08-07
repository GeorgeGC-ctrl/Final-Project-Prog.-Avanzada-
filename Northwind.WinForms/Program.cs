using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application;
using Serilog;

namespace Northwind.WinForms
{
    internal static class Program
    {
                /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .Build();

            var services = new ServiceCollection();

            services.AddDomain(configuration);
            services.AddApplication(configuration);
            services.AddInfrastructure(configuration);

            services.AddTransient<Form1>();

            var serviceProvider = services.BuildServiceProvider();

            try
            {
                Log.Information("=== Iniciando aplicación Northwind ===");

                var formPrincipal = serviceProvider.GetRequiredService<Form1>();
                System.Windows.Forms.Application.Run(formPrincipal);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "La aplicación terminó inesperadamente");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}


