//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace bike_thieves
//{
//    public class ConsumeEventSync
//    {
//        public void GetAllEventData() //Get All Events Records
//        {
//            using (var client = new WebClient()) //WebClient
//            {
//                client.Headers.Add("Content-Type:application/json"); //Content-Type
//                client.Headers.Add("Accept:application/json");
//                var result = client.DownloadString("https://bikeindex.org/api/v3/search?access_token=0rRvqmA8dDXOwKHHJ04nMaMAVtrnRHOFvlqrtP8a7HU"); //URI

//                Console.WriteLine(Environment.NewLine + result);
//            }
//        }
//    }
//}
