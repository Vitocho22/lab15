using lab15.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace lab15.Services
{
    public class AirbnbApiService
    {
        HttpClient client = new HttpClient();

        public async Task<List<AirbnbListing>> GetListingsAsync(string url)
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<AirbnbListing>>(json);
            }
            return new List<AirbnbListing>();
        }
    }
}