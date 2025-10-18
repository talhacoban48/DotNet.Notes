using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;

namespace WMI_NetworkCard_MAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementClass M = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection RV = M.GetInstances();
            foreach (ManagementObject item in RV)
            {
                if ((bool)item["IPEnabled"])
                {
                    RegistryKey Key = Registry.CurrentUser.OpenSubKey("xyzProjesi", true);
                    Key.SetValue("MacAdress", item["MacAddress"].ToString());
                }
            }
        }
    }
}
