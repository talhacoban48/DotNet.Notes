namespace windows_forms
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnac = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnac
            // 
            this.btnac.Location = new System.Drawing.Point(130, 162);
            this.btnac.Name = "btnac";
            this.btnac.Size = new System.Drawing.Size(164, 40);
            this.btnac.TabIndex = 0;
            this.btnac.Text = "ikinci formu çalıştır";
            this.btnac.UseVisualStyleBackColor = true;
            this.btnac.Click += new System.EventHandler(this.btnac_Click);
            // 
            // textmessage
            // 
            this.textmessage.AccessibleName = "";
            this.textmessage.Location = new System.Drawing.Point(105, 120);
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(215, 20);
            this.textmessage.TabIndex = 1;
            this.textmessage.Text = "metin giriniz";
            this.textmessage.Click += new System.EventHandler(this.textmessage_Click);
            this.textmessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ikinci form üzerinde yazmasını istediğimiz text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.btnac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "merabalar amk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnac;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.Label label1;
    }
}

