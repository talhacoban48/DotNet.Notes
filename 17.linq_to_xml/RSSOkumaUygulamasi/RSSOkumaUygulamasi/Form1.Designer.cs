namespace RSSOkumaUygulamasi
{
    partial class Haberler
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_baslik = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.txt_rssurl);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(7, 20);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(954, 20);
            this.txt_rssurl.TabIndex = 0;
            this.txt_rssurl.Text = "https://www.sabah.com.tr/rss/ekonomi.xml";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(967, 20);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(164, 23);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_baslik);
            this.groupBox2.Location = new System.Drawing.Point(13, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 545);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // lst_baslik
            // 
            this.lst_baslik.FormattingEnabled = true;
            this.lst_baslik.Location = new System.Drawing.Point(7, 20);
            this.lst_baslik.Name = "lst_baslik";
            this.lst_baslik.Size = new System.Drawing.Size(317, 511);
            this.lst_baslik.TabIndex = 0;
            this.lst_baslik.SelectedIndexChanged += new System.EventHandler(this.lst_baslik_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser);
            this.groupBox3.Location = new System.Drawing.Point(350, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 545);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detay";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 16);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(788, 526);
            this.webBrowser.TabIndex = 0;
            // 
            // Haberler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Haberler";
            this.Text = "RSS Okuma Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_baslik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

