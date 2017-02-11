using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HomeDash.External.Service
{
    public class EcobeeService
    {
        public async void RefreshTokenAsync(string apiKey, string refreshToken)
        {
            var url = "https://api.ecobee.com/token";

            var values = new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "code", refreshToken },
                { "client_id", apiKey }
            };
            var content = new FormUrlEncodedContent(values);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var serviceResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
