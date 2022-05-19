using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuizTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetReceiptData();

            Console.ReadLine();
        }

        private async Task GetReceiptData()
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync("https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1");

            List<Product> product = JsonConvert.DeserializeObject<List<Product>>(response);


            foreach (var item in product)
            {
                if (item.Domestic == true)
                {
                    Console.WriteLine(".Domestic");
                    Console.WriteLine($"...{item.Name}");
                    Console.WriteLine($"Price: ${item.Price}");
                    Console.WriteLine($"{item.Description.Substring(0, 10)}...");
                    Console.WriteLine($"Weight: {item.Weight}g");
                }
                else
                {
                    Console.WriteLine(".Imported");
                    Console.WriteLine($"...{item.Name}");
                    Console.WriteLine($"Price: ${item.Price}");
                    Console.WriteLine($"{item.Description.Substring(0, 10)}...");
                    Console.WriteLine($"Weight: {item.Weight}g");
                }
            }

            var costOfDomesticProducts = (from item in product
                                          where item.Domestic == true
                                          select item).Sum(i => i.Price);

            Console.WriteLine($"Domestic cost: ${costOfDomesticProducts}");

            var costOfImportedProducts = (from item in product
                                          where item.Domestic == false
                                          select item).Sum(i => i.Price);

            Console.WriteLine($"Imported cost: ${costOfImportedProducts}");

            int countOfDomesticProducts = product.Count(item => item.Domestic == true);

            Console.WriteLine($"Domestic count: {countOfDomesticProducts}");

            int countOfImportedProducts = product.Count(item => item.Domestic == false);

            Console.WriteLine($"Imported count: {countOfImportedProducts}");

        }
    }
}
