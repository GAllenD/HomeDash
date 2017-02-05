using HomeDash.External.Helpers;
using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDash.External.Service
{
    public class PhilipsHueService
    {
        LocalHueClient client;

        public PhilipsHueService(string ipAddress, string appKey)
        {
            client = new LocalHueClient(ipAddress);
            client.Initialize(appKey);
        }
        
        public async void GetSingleLightAsync()
        {
            await client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), new List<string> {"6" });
        }

        public List<Light> GetLights()
        {
            return client.GetLightsAsync().Result.ToList();
        }

        public void TurnAllLightsOn()
        {

        }

        public async void TurnSingleLightOnAsync(string lightId)
        {
             await client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), new List<string> { lightId });
        }
    }
}
