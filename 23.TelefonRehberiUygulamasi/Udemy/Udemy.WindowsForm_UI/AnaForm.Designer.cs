namespace Udemy.WindowsForm_UI
{
    partial class AnaForm
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
            this.lstListe = new System.Windows.Forms.ListBox();
            this.grpboxKayit = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon3 = new System.Windows.Forms.TextBox();
            this.txtTelefon2 = new System.Windows.Forms.TextBox();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbldatadurum = new System.Windows.Forms.Label();
            this.btnJsonVer = new System.Windows.Forms.Button();
            this.btnCsvVer = new System.Windows.Forms.Button();
            this.btnXmlOku = new System.Windows.Forms.Button();
            this.btnXmlVer = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpboxKayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListe);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Listesi";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(7, 20);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(246, 433);
            this.lstListe.TabIndex = 0;
            this.lstListe.DoubleClick += new System.EventHandler(this.lstListe_DoubleClick);
            // 
            // grpboxKayit
            // 
            this.grpboxKayit.Controls.Add(this.btnKayitSil);
            this.grpboxKayit.Controls.Add(this.btnGuncelle);
            this.grpboxKayit.Controls.Add(this.btnYeniKayit);
            this.grpboxKayit.Controls.Add(this.tabControl1);
            this.grpboxKayit.Location = new System.Drawing.Point(280, 13);
            this.grpboxKayit.Name = "grpboxKayit";
            this.grpboxKayit.Size = new System.Drawing.Size(681, 299);
            this.grpboxKayit.TabIndex = 1;
            this.grpboxKayit.TabStop = false;
            this.grpboxKayit.Text = "Yeni Rehber Kaydı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(235, 266);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 23);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(25, 266);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(204, 23);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 244);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtWebsite);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtTelefon3);
            this.tabPage1.Controls.Add(this.txtTelefon2);
            this.tabPage1.Controls.Add(this.txtTelefon1);
            this.tabPage1.Controls.Add(this.txtsoyisim);
            this.tabPage1.Controls.Add(this.txtisim);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(335, 48);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(268, 137);
            this.txtAdres.TabIndex = 7;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(125, 165);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(184, 20);
            this.txtWebsite.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefon3
            // 
            this.txtTelefon3.Location = new System.Drawing.Point(125, 118);
            this.txtTelefon3.Name = "txtTelefon3";
            this.txtTelefon3.Size = new System.Drawing.Size(184, 20);
            this.txtTelefon3.TabIndex = 4;
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(125, 94);
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(184, 20);
            this.txtTelefon2.TabIndex = 3;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(125, 71);
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(184, 20);
            this.txtTelefon1.TabIndex = 2;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(125, 48);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(184, 20);
            this.txtsoyisim.TabIndex = 1;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(125, 24);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(184, 20);
            this.txtisim.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Website : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adres :  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon 3 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon 2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon 1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtAciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Açıklama : ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(38, 49);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(590, 148);
            this.txtAciklama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbldatadurum);
            this.groupBox3.Controls.Add(this.btnJsonVer);
            this.groupBox3.Controls.Add(this.btnCsvVer);
            this.groupBox3.Controls.Add(this.btnXmlOku);
            this.groupBox3.Controls.Add(this.btnXmlVer);
            this.groupBox3.Location = new System.Drawing.Point(281, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veri importla - Exportla";
            // 
            // lbldatadurum
            // 
            this.lbldatadurum.AutoSize = true;
            this.lbldatadurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatadurum.Location = new System.Drawing.Point(86, 113);
            this.lbldatadurum.Name = "lbldatadurum";
            this.lbldatadurum.Size = new System.Drawing.Size(149, 18);
            this.lbldatadurum.TabIndex = 2;
            this.lbldatadurum.Text = "Durum : beklemede...";
            // 
            // btnJsonVer
            // 
            this.btnJsonVer.Location = new System.Drawing.Point(412, 19);
            this.btnJsonVer.Name = "btnJsonVer";
            this.btnJsonVer.Size = new System.Drawing.Size(137, 36);
            this.btnJsonVer.TabIndex = 0;
            this.btnJsonVer.Text = "Json Ver";
            this.btnJsonVer.UseVisualStyleBackColor = true;
            this.btnJsonVer.Click += new System.EventHandler(this.btnJsonVer_Click);
            // 
            // btnCsvVer
            // 
            this.btnCsvVer.Location = new System.Drawing.Point(269, 19);
            this.btnCsvVer.Name = "btnCsvVer";
            this.btnCsvVer.Size = new System.Drawing.Size(137, 36);
            this.btnCsvVer.TabIndex = 0;
            this.btnCsvVer.Text = "Csv Ver";
            this.btnCsvVer.UseVisualStyleBackColor = true;
            this.btnCsvVer.Click += new System.EventHandler(this.btnCsvVer_Click);
            // 
            // btnXmlOku
            // 
            this.btnXmlOku.Location = new System.Drawing.Point(269, 61);
            this.btnXmlOku.Name = "btnXmlOku";
            this.btnXmlOku.Size = new System.Drawing.Size(137, 36);
            this.btnXmlOku.TabIndex = 0;
            this.btnXmlOku.Text = "Xml Oku";
            this.btnXmlOku.UseVisualStyleBackColor = true;
            // 
            // btnXmlVer
            // 
            this.btnXmlVer.Location = new System.Drawing.Point(126, 19);
            this.btnXmlVer.Name = "btnXmlVer";
            this.btnXmlVer.Size = new System.Drawing.Size(137, 36);
            this.btnXmlVer.TabIndex = 0;
            this.btnXmlVer.Text = "Xml Ver";
            this.btnXmlVer.UseVisualStyleBackColor = true;
            this.btnXmlVer.Click += new System.EventHandler(this.btnXmlVer_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(445, 266);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(204, 23);
            this.btnKayitSil.TabIndex = 0;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpboxKayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpboxKayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxKayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon3;
        private System.Windows.Forms.TextBox txtTelefon2;
        private System.Windows.Forms.TextBox txtTelefon1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJsonVer;
        private System.Windows.Forms.Button btnCsvVer;
        private System.Windows.Forms.Button btnXmlVer;
        private System.Windows.Forms.Label lbldatadurum;
        private System.Windows.Forms.Button btnXmlOku;
        private System.Windows.Forms.Button btnKayitSil;
    }
}