using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.WindowsForm_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LK = lisansKontrol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (LK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new lisansekranı());
            }
        }

        static bool lisansKontrol()
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("TelefonRehberi");
            if (RK != null)
            {
                string HarddiskSeriNumarasi = string.Empty;
                string MacAddress = string.Empty;

                string Driver = "C";
                ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Driver + ":\"");
                Disk.Get();
                HarddiskSeriNumarasi = Disk["VolumeSerialNumber"].ToString();

                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MACADD.GetInstances();
                foreach (ManagementObject NIC in NAL)
                {
                    if ((bool)NIC["IPEnabled"])
                    {
                        MacAddress = NIC["MacAddress"].ToString();
                    }
                }

                string HDDSNSTR = RK.GetValue("HardDiskSerialNumber").ToString();
                string MACADDSTR = RK.GetValue("MacAddress").ToString();

                if (HDDSNSTR == HarddiskSeriNumarasi && MACADDSTR == MacAddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
