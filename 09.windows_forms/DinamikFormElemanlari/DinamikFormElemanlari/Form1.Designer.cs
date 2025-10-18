namespace DinamikFormElemanlari
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
            this.btnbtnuret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnbtnuret
            // 
            this.btnbtnuret.Location = new System.Drawing.Point(433, 12);
            this.btnbtnuret.Name = "btnbtnuret";
            this.btnbtnuret.Size = new System.Drawing.Size(100, 30);
            this.btnbtnuret.TabIndex = 0;
            this.btnbtnuret.Text = "Üret";
            this.btnbtnuret.UseVisualStyleBackColor = true;
            this.btnbtnuret.Click += new System.EventHandler(this.btnbtnuret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 214);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 238);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnbtnuret);
            this.Name = "Form1";
            this.Text = "Dinamik Form Elemanı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbtnuret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

