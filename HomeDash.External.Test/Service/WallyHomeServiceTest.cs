using HomeDash.External.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var response =  wallyService.GetSensorDataAsync(serviceUrl);
        }
    }
}
