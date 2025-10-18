namespace messagebox_uygulama
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
            this.components = new System.ComponentModel.Container();
            this.addNewCustemerGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lstCustermers = new System.Windows.Forms.ListBox();
            this.bildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.addNewCustemerGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewCustemerGroup
            // 
            this.addNewCustemerGroup.Controls.Add(this.btnAddNew);
            this.addNewCustemerGroup.Controls.Add(this.txtPhoneNo);
            this.addNewCustemerGroup.Controls.Add(this.txtEmail);
            this.addNewCustemerGroup.Controls.Add(this.txtLastName);
            this.addNewCustemerGroup.Controls.Add(this.txtName);
            this.addNewCustemerGroup.Controls.Add(this.label4);
            this.addNewCustemerGroup.Controls.Add(this.label3);
            this.addNewCustemerGroup.Controls.Add(this.label2);
            this.addNewCustemerGroup.Controls.Add(this.label1);
            this.addNewCustemerGroup.Location = new System.Drawing.Point(12, 12);
            this.addNewCustemerGroup.Name = "addNewCustemerGroup";
            this.addNewCustemerGroup.Size = new System.Drawing.Size(210, 180);
            this.addNewCustemerGroup.TabIndex = 0;
            this.addNewCustemerGroup.TabStop = false;
            this.addNewCustemerGroup.Text = "yeni müsteri ekleme formu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCustermers);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "müsteri kayıt listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "soysisim :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(116, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "telefon no :";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(77, 112);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(116, 20);
            this.txtPhoneNo.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(77, 138);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(116, 22);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "ekle";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lstCustermers
            // 
            this.lstCustermers.FormattingEnabled = true;
            this.lstCustermers.Location = new System.Drawing.Point(7, 20);
            this.lstCustermers.Name = "lstCustermers";
            this.lstCustermers.Size = new System.Drawing.Size(242, 147);
            this.lstCustermers.TabIndex = 0;
            // 
            // bildirimCubugu
            // 
            this.bildirimCubugu.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNewCustemerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "message box uygulama";
            this.addNewCustemerGroup.ResumeLayout(false);
            this.addNewCustemerGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addNewCustemerGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCustermers;
        private System.Windows.Forms.NotifyIcon bildirimCubugu;
    }
}

