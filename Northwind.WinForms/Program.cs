using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application;
using Northwind.Domain;
using Northwind.Infrastructure;
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

            var services = new ServiceCollection();

            services.AddDomain(configuration);
            services.AddApplication(configuration);
            services.AddInfrastructure(configuration);
            services.AddTransient<Form1>();
            services.AddTransient<FrmCategoriaLista>();
            services.AddTransient<FrmCategoriaForm>();

            var serviceProvider = services.BuildServiceProvider();

            try
            {
                Log.Information("=== Iniciando aplicaci�n Northwind ===");

                var formPrincipal = serviceProvider.GetRequiredService<Form1>();
                System.Windows.Forms.Application.Run(formPrincipal);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "La aplicaci�n termin� inesperadamente");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}


