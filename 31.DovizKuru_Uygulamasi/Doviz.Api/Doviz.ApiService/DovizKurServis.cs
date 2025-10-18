using Doviz.Core;
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

namespace Doviz.ApiService
{
    public partial class DovizKurServis : ServiceBase
    {
        Timer timer;
        public DovizKurServis()
        {
            InitializeComponent();
            timer = new Timer(3600000); // bir saat
            timer.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            BLL.KurBilgileriniGuncelle();
        }

        protected override void OnStart(string[] args)
        {
            timer.Start();
        }

        protected override void OnContinue()
        {
            timer.Start();
        }

        protected override void OnPause()
        {
            timer.Stop();
        }

        protected override void OnShutdown()
        {
            timer.Stop();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }
    }
}
