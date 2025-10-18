namespace FakeData_GridWiew
{
    partial class PopupMessage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.tamAdi = new System.Windows.Forms.Label();
            this.txttamad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(263, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(45, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 1;
            this.id.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(152, 20);
            this.txtid.TabIndex = 2;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(45, 64);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(24, 13);
            this.isim.TabIndex = 1;
            this.isim.Text = "isim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(100, 61);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(152, 20);
            this.txtisim.TabIndex = 2;
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.Location = new System.Drawing.Point(45, 90);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(40, 13);
            this.soyisim.TabIndex = 1;
            this.soyisim.Text = "soyisim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(100, 87);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(152, 20);
            this.txtsoyisim.TabIndex = 2;
            // 
            // tamAdi
            // 
            this.tamAdi.AutoSize = true;
            this.tamAdi.Location = new System.Drawing.Point(45, 116);
            this.tamAdi.Name = "tamAdi";
            this.tamAdi.Size = new System.Drawing.Size(46, 13);
            this.tamAdi.TabIndex = 1;
            this.tamAdi.Text = "Tam Adı";
            // 
            // txttamad
            // 
            this.txttamad.Location = new System.Drawing.Point(100, 113);
            this.txttamad.Name = "txttamad";
            this.txttamad.Size = new System.Drawing.Size(152, 20);
            this.txttamad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(100, 139);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(152, 20);
            this.txtemail.TabIndex = 2;
            // 
            // PopupMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttamad);
            this.Controls.Add(this.tamAdi);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupMessage";
            this.Load += new System.EventHandler(this.PopupMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label tamAdi;
        private System.Windows.Forms.TextBox txttamad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
    }
}