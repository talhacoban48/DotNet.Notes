namespace messagebox
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
            this.btnmesajgoster = new System.Windows.Forms.Button();
            this.btnAskQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmesajgoster
            // 
            this.btnmesajgoster.Location = new System.Drawing.Point(65, 74);
            this.btnmesajgoster.Name = "btnmesajgoster";
            this.btnmesajgoster.Size = new System.Drawing.Size(114, 39);
            this.btnmesajgoster.TabIndex = 0;
            this.btnmesajgoster.Text = "mesaj göster";
            this.btnmesajgoster.UseVisualStyleBackColor = true;
            this.btnmesajgoster.Click += new System.EventHandler(this.btnmesajgoster_Click);
            // 
            // btnAskQuestion
            // 
            this.btnAskQuestion.Location = new System.Drawing.Point(185, 74);
            this.btnAskQuestion.Name = "btnAskQuestion";
            this.btnAskQuestion.Size = new System.Drawing.Size(114, 39);
            this.btnAskQuestion.TabIndex = 0;
            this.btnAskQuestion.Text = "soru sor";
            this.btnAskQuestion.UseVisualStyleBackColor = true;
            this.btnAskQuestion.Click += new System.EventHandler(this.btnAskQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 313);
            this.Controls.Add(this.btnAskQuestion);
            this.Controls.Add(this.btnmesajgoster);
            this.Name = "Form1";
            this.Text = "messagebox nesnesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmesajgoster;
        private System.Windows.Forms.Button btnAskQuestion;
    }
}

