namespace PromosyonTakip.UI
{
    partial class AnaEkran
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
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.chkSMSOnay = new System.Windows.Forms.CheckBox();
            this.chkEpostaOnay = new System.Windows.Forms.CheckBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hediyepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.grpMusteriBilgileri.Controls.Add(this.btnIptal);
            this.grpMusteriBilgileri.Controls.Add(this.chkSMSOnay);
            this.grpMusteriBilgileri.Controls.Add(this.chkEpostaOnay);
            this.grpMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.grpMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.grpMusteriBilgileri.Controls.Add(this.txtTelefonNo);
            this.grpMusteriBilgileri.Controls.Add(this.txtEmail);
            this.grpMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.grpMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.grpMusteriBilgileri.Controls.Add(this.txtIsim);
            this.grpMusteriBilgileri.Controls.Add(this.txtTCKimlikNo);
            this.grpMusteriBilgileri.Controls.Add(this.label4);
            this.grpMusteriBilgileri.Controls.Add(this.label5);
            this.grpMusteriBilgileri.Controls.Add(this.label8);
            this.grpMusteriBilgileri.Controls.Add(this.label7);
            this.grpMusteriBilgileri.Controls.Add(this.label6);
            this.grpMusteriBilgileri.Controls.Add(this.label3);
            this.grpMusteriBilgileri.Controls.Add(this.label2);
            this.grpMusteriBilgileri.Controls.Add(this.label1);
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(318, 12);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(339, 362);
            this.grpMusteriBilgileri.TabIndex = 0;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Musteri Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(144, 324);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(144, 295);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 23);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // chkSMSOnay
            // 
            this.chkSMSOnay.AutoSize = true;
            this.chkSMSOnay.Location = new System.Drawing.Point(144, 262);
            this.chkSMSOnay.Name = "chkSMSOnay";
            this.chkSMSOnay.Size = new System.Drawing.Size(159, 17);
            this.chkSMSOnay.TabIndex = 9;
            this.chkSMSOnay.Text = "SMS bildirimi almak istiyorum";
            this.chkSMSOnay.UseVisualStyleBackColor = true;
            // 
            // chkEpostaOnay
            // 
            this.chkEpostaOnay.AutoSize = true;
            this.chkEpostaOnay.Location = new System.Drawing.Point(144, 216);
            this.chkEpostaOnay.Name = "chkEpostaOnay";
            this.chkEpostaOnay.Size = new System.Drawing.Size(169, 17);
            this.chkEpostaOnay.TabIndex = 7;
            this.chkEpostaOnay.Text = "Eposta bildirimi almak istiyorum";
            this.chkEpostaOnay.UseVisualStyleBackColor = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(144, 143);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(168, 21);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(144, 117);
            this.txtDogumTarih.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(168, 20);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(144, 235);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(168, 20);
            this.txtTelefonNo.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(144, 166);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(168, 20);
            this.txtMeslek.TabIndex = 5;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(144, 87);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(168, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(144, 62);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(168, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(144, 39);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(168, 20);
            this.txtTCKimlikNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon Numarası : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email Adress : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // hediyepanel
            // 
            this.hediyepanel.Location = new System.Drawing.Point(13, 13);
            this.hediyepanel.Name = "hediyepanel";
            this.hediyepanel.Size = new System.Drawing.Size(299, 361);
            this.hediyepanel.TabIndex = 1;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 381);
            this.Controls.Add(this.hediyepanel);
            this.Controls.Add(this.grpMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.CheckBox chkSMSOnay;
        private System.Windows.Forms.CheckBox chkEpostaOnay;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.FlowLayoutPanel hediyepanel;
    }
}