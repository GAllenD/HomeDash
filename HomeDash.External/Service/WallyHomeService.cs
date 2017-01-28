using HomeDash.External.Model.WallyHome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeDash.External.Service
{
    public class WallyHomeService
    {
        public async Task<SensorsResponse>  GetSensorDataAsync(string Url)
        {
            SensorsResponse _response = null;

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(GetServiceUri());
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    var r = response.Content;
                }
            }


            return _response;
        }
    }
        
}
