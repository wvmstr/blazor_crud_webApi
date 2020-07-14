using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace SchoolClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            //suggestion mgebhard
            builder.Services.AddHttpClient("ServerAPI", client =>
            {
                client.BaseAddress = new Uri(@"https://localhost:44318/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            //builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }

        //public class ExampleModel
        //{
        //    [Required]
        //    [StringLength(10, ErrorMessage = "Name is too long.")]
        //    public string Name { get; set; }
        //}
    }
}
