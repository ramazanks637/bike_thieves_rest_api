using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace bike_thieves
{
    class Program
    {
        static async Task GetItemAsync(string location,string distance,string stolenness)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://bikeindex.org:443/api/v3/search?page=1&per_page=25&location="+location+ "&distance=" + distance + "&stolenness=" + stolenness);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    Root itemlist = new Root();
                    itemlist = await JsonSerializer.DeserializeAsync<Root>(await response.Content.ReadAsStreamAsync());
                    foreach (Bike item in itemlist.bikes)
                    {
                        Console.WriteLine($"Bike Id    : {item.id}");
                        Console.WriteLine($"Bike Color    : {item.frame_colors}");
                        Console.WriteLine($"Model      : {item.frame_model}");
                        Console.WriteLine($"Manufacturer Name      : {item.manufacturer_name}");
                        Console.WriteLine($"Serial      : {item.serial}");
                        Console.WriteLine($"Status      : {item.status}");
                        Console.WriteLine($"Stollen      : {item.stolen}");
                        Console.WriteLine($"Stollen coordinates     : {item.stolen_coordinates}");
                        Console.WriteLine($"Stollen Location     : {item.stolen_location}");
                        Console.WriteLine($"title     : {item.title}");
                        Console.WriteLine($"Url     : {item.url}");
                        Console.WriteLine($"year     : {item.year}");
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            string location = "Amsterdam";
            string distance = "20";
            string stolenness = "proximity";

            while (true)
            {
                Console.WriteLine("Which of the following cities would you like to see the stolen bike status of ?");
                Console.WriteLine("1. Amsterdam, The Netherlands");
                Console.WriteLine("2. Berlin, Germany");
                Console.WriteLine("3. Copenhagen, Denmark");
                Console.WriteLine("4. Brussels, Belgium");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        location = "Amsterdam";
                        Console.WriteLine("Distance : ");
                        distance =  Console.ReadLine();
                        Console.WriteLine("Stolenness : ");
                        stolenness =  Console.ReadLine();
                        GetItemAsync(location,distance,stolenness).Wait();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    default:

                        break;
                }
            }

        }
    }
}
