using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace OrderProcessorClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line;
            while ((line = Console.ReadLine()) != "q")
            {
                HttpClient httpClient = new HttpClient();
                Console.Write("Enter payment processor type (book, video, membership, upgrade, product): ");
                string processor = Console.ReadLine();

                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://localhost:44384/OrderPayment?processor=" + processor),
                };

                var result = httpClient.SendAsync(httpRequest).Result;

                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                }
            }
            Console.WriteLine("Press enter to continue!");
            Console.WriteLine("Enter q to exit!");
        }
    }
}
