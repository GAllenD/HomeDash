using HomeDash.External.Helpers;
using Q42.HueApi;
using Q42.HueApi.Models.Groups;
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

        public Light GetSingleLight(string lightName)
        {
            return GetLights().FirstOrDefault(l => l.Name == lightName);
        }

        public List<Light> GetLights()
        {
            return client.GetLightsAsync().Result.ToList();
        }

        public Group GetSingleGroup(string groupName)
        {
            return GetGroups().FirstOrDefault(g => g.Name == groupName);
        }

        public List<Group> GetGroups()
        {
            return client.GetGroupsAsync().Result.ToList();
        }

        public async void TurnAllLightsOnAsync()
        {
            await client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand());
        }

        public async void TurnAllLightsOffAsync()
        {
            await client.SendCommandAsync(PhilipsHueServiceHelper.GetOffCommand());
        }

        public async void TurnSingleLightOnAsync(string lightId)
        {
             await client.SendCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), new List<string> { lightId });
        }

        public async void TurnSingleLightOffAsync(string lightId)
        {
            await client.SendCommandAsync(PhilipsHueServiceHelper.GetOffCommand(), new List<string> { lightId });
        }

        public async void TurnGroupLightsOnAsync(string groupId)
        {
            await client.SendGroupCommandAsync(PhilipsHueServiceHelper.GetOnCommand(), groupId);
        }

        public async void TurnGroupLightsOffAsync(string groupId)
        {
            await client.SendGroupCommandAsync(PhilipsHueServiceHelper.GetOffCommand(), groupId);
        }
    }
}
