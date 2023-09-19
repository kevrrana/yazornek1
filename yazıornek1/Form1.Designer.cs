namespace yazıornek1
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYazSil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaz.ForeColor = System.Drawing.Color.Honeydew;
            this.btnYaz.Location = new System.Drawing.Point(86, 126);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(129, 33);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "YAZ";
            this.btnYaz.UseVisualStyleBackColor = false;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSil.Location = new System.Drawing.Point(86, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYazSil
            // 
            this.txtYazSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazSil.Location = new System.Drawing.Point(257, 145);
            this.txtYazSil.Multiline = true;
            this.txtYazSil.Name = "txtYazSil";
            this.txtYazSil.Size = new System.Drawing.Size(283, 36);
            this.txtYazSil.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 319);
            this.Controls.Add(this.txtYazSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYazSil;
    }
}

