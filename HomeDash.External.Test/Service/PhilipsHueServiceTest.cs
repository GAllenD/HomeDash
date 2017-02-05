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
    public class PhilipsHueServiceTest
    {
        private PhilipsHueService _service;

        [OneTimeSetUp]
        public void Setup()
        {
            var ip = ConfigurationManager.AppSettings["HueIpAddres"];
            var appKey = ConfigurationManager.AppSettings["HueAppKey"];

            _service = new PhilipsHueService(ip,appKey);
        }

        [Test]
        public void ShouldTurnLightOn()
        {
            _service.TurnSingleLightOnAsync("6");
        }

        [Test]
        public void ShouldGetListOfLights()
        {
            var lightCount = _service.GetLights().Count();
            lightCount.ShouldBeGreaterThan(1);
            TestContext.WriteLine("Light Count is: " + lightCount);
        }
    }
}
