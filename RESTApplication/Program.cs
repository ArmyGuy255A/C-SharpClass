using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration.FileExtensions;
using System;
using System.IO;
//using Microsoft.Extensions.Configuration.Binder;
//using Microsoft.Extensions.Configuration.EnvironmentVariables;
//using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace RESTApplication
{
    class Program
    {
        static AppSettings appSettings = new AppSettings();
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();

            ConfigurationBinder.Bind(configuration.GetSection("AppSettings"), appSettings);



            Uri restEndpointURI = new Uri(appSettings.RestEndpoint);

            ResetRestClient();
            var response = await client.GetStringAsync("https://petstore.swagger.io/v2/store/inventory");
            StoreInventory responseObject = System.Text.Json.JsonSerializer.Deserialize<StoreInventory>(response);
            StoreInventory responseObjectNewtonsoft = JsonConvert.DeserializeObject<StoreInventory>(response);
            //JsonSerializer.Serialize(responseObject);
            

            Console.WriteLine("Hello World!");
        }

        private static void ResetRestClient ()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "RESTApplication");
        }



    }
}
