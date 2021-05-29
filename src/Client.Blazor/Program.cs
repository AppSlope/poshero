using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using POSHero.Client.Blazor.Extensions;
using System.Threading.Tasks;

namespace POSHero.Client.Blazor
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder
                       .CreateDefault(args)
                       .AddRootComponents()
                       .AddClientServices();

            await builder.Build().RunAsync();
        }
    }
}