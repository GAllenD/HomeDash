using HomeDash.External.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDash.External.Test.Service
{
   
    [TestFixture]
    public class WallyHomeServiceTest
    {
        [Test]
        public async void ShouldReturnValidResponse()
        {
            var wallyService = new WallyHomeService();

            var response = await wallyService.GetSensorData();
        }
    }
}
