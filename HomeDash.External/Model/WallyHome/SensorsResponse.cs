using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDash.External.Model.WallyHome
{
    public class WallyHomeSensorResponse
    {
        public SensorsResponse[] Sensors { get; set; }
    }

    public class SensorsResponse
    {
        public string snid { get; set; }
        public string gatewayId { get; set; }
        public bool offline { get; set; }
        public Location location { get; set; }
        public DateTime paired { get; set; }
        public bool suspended { get; set; }
        public Thresholds thresholds { get; set; }
        public Contactthresholds contactThresholds { get; set; }
        public DateTime updated { get; set; }
        public object[] activities { get; set; }
        public bool alarmed { get; set; }
        public int signalStrength { get; set; }
        public float recentSignalStrength { get; set; }
        public Hardware hardware { get; set; }
        public string hardwareType { get; set; }
        public State state { get; set; }
    }

    public class Location
    {
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string id { get; set; }
        public string room { get; set; }
        public string appliance { get; set; }
        public string floor { get; set; }
        public string placeId { get; set; }
        public string sensorId { get; set; }
        public string functionalType { get; set; }
    }

    public class Thresholds
    {
        public TEMP TEMP { get; set; }
        public RH RH { get; set; }
    }

    public class TEMP
    {
        public float min { get; set; }
        public float max { get; set; }
    }

    public class RH
    {
        public double max { get; set; }
    }

    public class Contactthresholds
    {
        public DISCONN DISCONN { get; set; }
        public CONN CONN { get; set; }
    }

    public class DISCONN
    {
        public bool enabled { get; set; }
    }

    public class CONN
    {
        public bool enabled { get; set; }
    }

    public class Hardware
    {
        public int HW_REV { get; set; }
        public int HW_TYPE { get; set; }
        public int MAN_WEEK { get; set; }
        public int TX_CNT { get; set; }
        public int BATT_LVL { get; set; }
        public int FW_REV { get; set; }
        public int MAN_ID { get; set; }
        public int MAN_YEAR { get; set; }
    }

    public class State
    {
        public LEAK LEAK { get; set; }
        public CONTACT CONTACT { get; set; }
        public TEMP1 TEMP { get; set; }
        public RH1 RH { get; set; }
        public SENSOR SENSOR { get; set; }
        public COND COND { get; set; }
    }

    public class LEAK
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }

    public class CONTACT
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }

    public class TEMP1
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }

    public class RH1
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }

    public class SENSOR
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }

    public class COND
    {
        public int value { get; set; }
        public DateTime at { get; set; }
    }
}