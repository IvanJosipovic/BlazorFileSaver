using Microsoft.Extensions.DependencyInjection;

namespace BlazorFileSaver
{
    public static class BlazorFileSaverExtensions
    {
        public static IServiceCollection AddBlazorFileSaver(this IServiceCollection services)
        {
            return services.AddTransient<IBlazorFileSaver, BlazorFileSaverJS>();
        }
    }
}
