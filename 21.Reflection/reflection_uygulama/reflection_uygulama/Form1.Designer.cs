namespace reflection_uygulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCTORs = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.txtObject);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen bilgi almak istediğiniz classın tam adını giriniz";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(8, 20);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(611, 20);
            this.txtObject.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(624, 20);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(120, 23);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCTORs);
            this.groupBox2.Location = new System.Drawing.Point(13, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMethods);
            this.groupBox3.Location = new System.Drawing.Point(516, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 339);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Methods";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstProperties);
            this.groupBox4.Location = new System.Drawing.Point(264, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 339);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // lstCTORs
            // 
            this.lstCTORs.FormattingEnabled = true;
            this.lstCTORs.Location = new System.Drawing.Point(7, 20);
            this.lstCTORs.Name = "lstCTORs";
            this.lstCTORs.Size = new System.Drawing.Size(233, 316);
            this.lstCTORs.TabIndex = 0;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(6, 17);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(233, 316);
            this.lstProperties.TabIndex = 0;
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(6, 17);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(233, 316);
            this.lstMethods.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 426);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Reflection Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstCTORs;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.ListBox lstProperties;
    }
}

