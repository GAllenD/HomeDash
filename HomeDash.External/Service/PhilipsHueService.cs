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
        
        public void GetSingleLight()
        {
            client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), new List<string> {"6" });
        }

        public void GetLights()
        {

        }
        
        public void TurnAllLightsOn()
        {

        }

        public void TurnSingleLightOn(string lightId)
        {
            client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), new List<string> { lightId });
        }
    }
}
