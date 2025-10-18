namespace checkbox
{
    partial class Form1
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
            this.chklistbox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kitapDetay = new System.Windows.Forms.RichTextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctUrunResim = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // chklistbox
            // 
            this.chklistbox.FormattingEnabled = true;
            this.chklistbox.Location = new System.Drawing.Point(13, 13);
            this.chklistbox.Name = "chklistbox";
            this.chklistbox.Size = new System.Drawing.Size(182, 304);
            this.chklistbox.TabIndex = 0;
            this.chklistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistbox_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kitapDetay);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtStokAdet);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pctUrunResim);
            this.groupBox1.Location = new System.Drawing.Point(201, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "secilen ürün detay bilgisi";
            // 
            // kitapDetay
            // 
            this.kitapDetay.Location = new System.Drawing.Point(7, 146);
            this.kitapDetay.Name = "kitapDetay";
            this.kitapDetay.Size = new System.Drawing.Size(372, 151);
            this.kitapDetay.TabIndex = 3;
            this.kitapDetay.Text = "";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(193, 101);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(186, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(193, 78);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(186, 20);
            this.txtStokAdet.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(193, 53);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(186, 20);
            this.txtKategori.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(193, 29);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(186, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "stok miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kategorisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ürün adı";
            // 
            // pctUrunResim
            // 
            this.pctUrunResim.Location = new System.Drawing.Point(16, 19);
            this.pctUrunResim.Name = "pctUrunResim";
            this.pctUrunResim.Size = new System.Drawing.Size(100, 121);
            this.pctUrunResim.TabIndex = 0;
            this.pctUrunResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chklistbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checked listbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklistbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox kitapDetay;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctUrunResim;
    }
}

