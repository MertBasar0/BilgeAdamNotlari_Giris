namespace KararYapıları1
{
    partial class Form2
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
            this.Mesaj = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mesaj
            // 
            this.Mesaj.AutoSize = true;
            this.Mesaj.Location = new System.Drawing.Point(205, 106);
            this.Mesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(86, 13);
            this.Mesaj.TabIndex = 0;
            this.Mesaj.Text = "Hoşgeldin Admin";
            this.Mesaj.Click += new System.EventHandler(this.Mesaj_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(195, 148);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 50);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Kapat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Mesaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mesaj;
        private System.Windows.Forms.Button btn_exit;
    }
}