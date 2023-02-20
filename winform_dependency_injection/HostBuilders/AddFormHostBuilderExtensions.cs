
namespace winform_dependency_injection.HostBuilders;

    internal static class AddFormHostBuilderExtensions
    {
        public static IHostBuilder AddViews(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<Form1>();
            });

            return host;
        }
    }

