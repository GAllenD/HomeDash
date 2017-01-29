using HomeDash.External.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace HomeDash.External.Test.Service
{
   
    [TestFixture]
    public class WallyHomeServiceTest
    {
        [Test]
        public void ShouldReturnValidResponse()
        {
            var wallyService = new WallyHomeService();

            var serviceUrl = ConfigurationManager.AppSettings["WallyHomeServiceUrl"];
            var serviceAuth = ConfigurationManager.AppSettings["WallyAuthorization"];

            var response =  wallyService.GetSensorsDataAsync(serviceUrl, serviceAuth);

            var serviceResponse = response.Result;

            serviceResponse.Count.ShouldEqual(2);
            serviceResponse[0].location.appliance.ShouldNotBeEmpty();
            serviceResponse[1].location.appliance.ShouldNotBeEmpty();
        }
    }
}
