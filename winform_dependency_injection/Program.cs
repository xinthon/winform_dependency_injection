
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.DependencyInjection;
global using winform_dependency_injection.HostBuilders;
global using winform_dependency_injection.Views;

namespace winform_dependency_injection;

internal static class Program
{
    private static IHost builder;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        builder = CreateHostBuilder().Build();

        ApplicationConfiguration.Initialize();
        Application.Run(builder.Services.GetRequiredService<Form1>());

        builder.Start();
    }

    public static IHostBuilder CreateHostBuilder(string[] args = null)
    {
        return Host.CreateDefaultBuilder(args)
            .AddViews();
    }
}
