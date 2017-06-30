using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreadHardwareSim
{
    public enum DeviceChoiceEnum
    {
        PS3,
        NONE
    }

    public partial class HWDLL
    {
        internal static List<HWDLL> Devices;

        internal static int CheckHardwareDevice(object deviceChoiceEnum)
        {
            Devices = new List<HWDLL>();
            Random ran = new Random();
            int num = 0;
            int goodDeviceCount = 0;


            if (deviceChoiceEnum is DeviceChoiceEnum)
            {
                switch ((DeviceChoiceEnum)deviceChoiceEnum)
                {
                    case DeviceChoiceEnum.PS3:
                        num = 4;
                        break;
                    case DeviceChoiceEnum.NONE:
                    default:
                        num = 0;
                        break;
                }
            }

            for (int i = 0; i < num; i++)
            {
                const int serial = 2200;
                Devices.Add(new HWDLL("PS-Move", "PS3 move controller", (uint)(serial + i)) );
            }

            foreach (HWDLL device in Devices)
            {
                // Sim: Setup random failure device
                int temp = ran.Next(64);
                if (temp % 4 == 0)
                {
                    device.status = temp;
                }
                else
                {
                    device.status = 0;
                    goodDeviceCount++;
                }
            }

            return goodDeviceCount;
        }

        internal static int InstallHardwareDevice(object deviceObj)
        {
            HWDLL device = (HWDLL)deviceObj;
            // Sim: Do-work
            Thread.Sleep(500);
            int status = device.status;

            return status;
        }
    }
}
