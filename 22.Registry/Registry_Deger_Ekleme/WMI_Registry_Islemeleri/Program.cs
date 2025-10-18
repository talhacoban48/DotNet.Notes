using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;

namespace WMI_Registry_Islemeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Driver = "C";
            ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Driver + ":\"");
            Disk.Get();
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("xyzProjesi", true);
            Key.SetValue("LogicalDiskSerialNumber", Disk["VolumeSerialNumber"].ToString());
            Key.Close();
        }
    }
}
