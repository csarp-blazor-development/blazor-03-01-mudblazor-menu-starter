using Blazored.LocalStorage;
using Kreta.Components.Layout;
using MudBlazor.Services;

namespace Kreta.Extension
{
    public static class AddBlazorExtension
    {
        public static void AddBlazor(this IServiceCollection services)
        {
            services.AddMudServices();
            services.AddBlazoredLocalStorage();
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ThemeService>();
        }
    }
}
