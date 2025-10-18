using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace Udemy.WindowsForm_UI
{
    public partial class lisansekranı : Form
    {
        public lisansekranı()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtLisansKey.Text == "32b28880-6cdf-4232-956d-4f8c4bb76f2e")
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

                if (!string.IsNullOrEmpty(HarddiskSeriNumarasi) && !string.IsNullOrEmpty(MacAddress))
                {
                    string[] Keys = Registry.CurrentUser.GetSubKeyNames();
                    bool kontrol = false;
                    foreach (string item in  Keys)
                    {
                        if (item == "TelefonRehberi")
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol == false)
                    {
                        Registry.CurrentUser.CreateSubKey("TelefonRehberi");
                    }
                    RegistryKey Key = Registry.CurrentUser.OpenSubKey("TelefonRehberi", true);
                    Key.SetValue("HardDiskSerialNumber", HarddiskSeriNumarasi);
                    Key.SetValue("MacAddress", MacAddress);

                    MessageBox.Show("Lisanslama işleminiz tamamlanmıştır. Lütfen programı yeniden başlatınız.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz lisans anahtarı hatalıdır", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
