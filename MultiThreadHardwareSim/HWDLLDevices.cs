using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadHardwareSim
{
    public partial class HWDLL
    {
        public string DeviceName { get; set; }
        public string DeviceFunction { get; set; }
        public uint DeviceSerial { get; set; }
        public int status { get; set; }

        public HWDLL()
        {
            DeviceName = "";
            DeviceFunction = "";
            DeviceSerial = 0;
            status = 0;
        }

        public HWDLL(string deviceName, string deviceFunc, uint deviceSerial)
        {
            DeviceName = deviceName;
            DeviceFunction = deviceFunc;
            DeviceSerial = deviceSerial;
        }

        public override string ToString()
        {
            return string.Format(DeviceName + " " + DeviceSerial.ToString());
        }

    }
}
