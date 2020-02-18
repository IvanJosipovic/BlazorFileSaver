using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace BlazorFileSaver.Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBlazorFileSaver();

            await builder.Build().RunAsync();
        }
    }
}
