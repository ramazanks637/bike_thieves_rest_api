//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace bike_thieves
//{
//    static class WebApiServices
//    {
//        static string url = "https://bikeindex.org/api/v3/";
//        static string serviceUrl = "";
//        static HttpClient client = new HttpClient();
//        public static async Task<string> GetAll()
//        {
//            serviceUrl = $"{url}search?access_token=0rRvqmA8dDXOwKHHJ04nMaMAVtrnRHOFvlqrtP8a7HU";
//            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
//                return await response.Content.ReadAsStringAsync();
//        }
//        public static async Task<string> GetSingle(string method, int id)
//        {
//            serviceUrl = $"{url}api/personel/{method}/{id}";
//            using (HttpResponseMessage response = await client.GetAsync(serviceUrl))
//                return await response.Content.ReadAsStringAsync();
//        }
//        public static async Task<string> Post<T>(string method, T instance) where T : class, new()
//        {
//            serviceUrl = $"{url}api/personel/{method}";
//            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
//            using (HttpResponseMessage response = await client.PostAsync(serviceUrl, httpContent))
//            {
//                response.EnsureSuccessStatusCode();
//                return await response.Content.ReadAsStringAsync();
//            }
//        }
//        public static async Task<string> Put<T>(string method, T instance) where T : class, new()
//        {
//            serviceUrl = $"{url}api/personel/{method}";
//            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
//            using (HttpResponseMessage response = await client.PutAsync(serviceUrl, httpContent))
//            {
//                response.EnsureSuccessStatusCode();
//                return await response.Content.ReadAsStringAsync();
//            }
//        }
//        public static async Task<string> Delete(string method, int id)
//        {
//            serviceUrl = $"{url}api/personel/{method}/{id}";
//            using (HttpResponseMessage response = await client.DeleteAsync(serviceUrl))
//                return await response.Content.ReadAsStringAsync();
//        }
//    }
//}
