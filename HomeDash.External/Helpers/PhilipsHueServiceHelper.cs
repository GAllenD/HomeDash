using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDash.External.Helpers
{
    public class PhilipsHueServiceHelper
    {
        public static LightCommand GetOnCommand()
        {
            return new LightCommand { On = true };
        }
        public static LightCommand GetOffCommand()
        {
            return new LightCommand { On = false };
        }

    }
}
