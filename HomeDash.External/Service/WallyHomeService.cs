using HomeDash.External.Model.WallyHome;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeDash.External.Service
{
    public class WallyHomeService
    {
        public async Task<List<SensorsResponse>>  GetSensorDataAsync(string Url, string authToken)
        {
            List<SensorsResponse> _response = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", authToken);

                var response = await client.GetAsync(Url);

                if (response.IsSuccessStatusCode)
                {
                    var serviceResponse = response.Content.ReadAsStringAsync().Result;

                    _response = JsonConvert.DeserializeObject<List<SensorsResponse>>(serviceResponse);
                }
            }


            return _response;
        }
    }
        
}
