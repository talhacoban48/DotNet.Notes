using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService_inceleme
{
    public partial class myServices : ServiceBase
    {
        public Timer t;
        public myServices()
        {
            InitializeComponent();
            t = new Timer(3000);
            t.Elapsed += T_Elapsed;    
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.OlayGunluguEkle("Service çalıştı", DateTime.Now);
        }

        /*
         * Start
         * Pause
         * Continue
         * Stop
         * OnShutDown
         */

        protected override void OnStart(string[] args)
        {
            // service çalıştığında çalışan olan method
            t.Start();
        }

        protected override void OnPause()
        {
            // service pause edildiğinde çalışacak method
            t.Stop();
        }

        protected override void OnContinue()
        {
            // service pause işleminden devam ettirildiğinde çalışacak olan method
            t.Start();
        }

        protected override void OnStop()
        {
            // service durduruduğu zaman çalışacak method
            t.Stop();
        }

        protected override void OnShutdown()
        {
            // service kapatıldığında çalışacak method
            t.Stop();
        }
    }
}
