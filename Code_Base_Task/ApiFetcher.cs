    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Code_Base_Task
    {
    public class ApiFetcher
    {
        private readonly HttpClient _httpClient;

        public ApiFetcher()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> FetchDataFromApisAsync(string api1Url, string api2Url)
        {
            Task<string> api1Task = _httpClient.GetStringAsync(api1Url);
            Task<string> api2Task = _httpClient.GetStringAsync(api2Url);


            await Task.WhenAll(api1Task, api2Task);


            string api1Result = await api1Task;
            string api2Result = await api2Task;

            return $"Combined Results:\nAPI1: {api1Result}\nAPI2: {api2Result}";
        }


        public async Task FetchDataFromApis()
        {
            Console.WriteLine("\nFetching data from APIs...");

            string api1Url = "https://catfact.ninja/fact";
            string api2Url = "https://api.nationalize.io?name=nathaniel";

            string result = await FetchDataFromApisAsync(api1Url, api2Url);

            Console.WriteLine(result);
        }
    }
 }
  