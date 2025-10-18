namespace Doviz.ApiService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DovizKurServis = new System.ServiceProcess.ServiceProcessInstaller();
            this.DovizUygulamasi = new System.ServiceProcess.ServiceInstaller();
            // 
            // DovizKurServis
            // 
            this.DovizKurServis.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.DovizKurServis.Password = null;
            this.DovizKurServis.Username = null;
            // 
            // DovizUygulamasi
            // 
            this.DovizUygulamasi.DisplayName = "DovizKurServis";
            this.DovizUygulamasi.ServiceName = "DovizKurServisUygulamasi";
            this.DovizUygulamasi.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.DovizKurServis,
            this.DovizUygulamasi});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller DovizKurServis;
        private System.ServiceProcess.ServiceInstaller DovizUygulamasi;
    }
}