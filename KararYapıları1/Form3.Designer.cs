namespace KararYapıları1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Kontrol = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Sifre = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(524, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Kontrol
            // 
            this.Kontrol.Location = new System.Drawing.Point(935, 229);
            this.Kontrol.Name = "Kontrol";
            this.Kontrol.Size = new System.Drawing.Size(524, 94);
            this.Kontrol.TabIndex = 0;
            this.Kontrol.Text = "Kontrol";
            this.Kontrol.UseVisualStyleBackColor = true;
            this.Kontrol.Click += new System.EventHandler(this.Kontrol_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(935, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btn_Sifre
            // 
            this.btn_Sifre.Location = new System.Drawing.Point(137, 541);
            this.btn_Sifre.Name = "btn_Sifre";
            this.btn_Sifre.Size = new System.Drawing.Size(524, 94);
            this.btn_Sifre.TabIndex = 0;
            this.btn_Sifre.Text = "Sifre";
            this.btn_Sifre.UseVisualStyleBackColor = true;
            this.btn_Sifre.Click += new System.EventHandler(this.btn_Sifre_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 418);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(524, 22);
            this.textBox3.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 727);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Sifre);
            this.Controls.Add(this.Kontrol);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Kontrol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Sifre;
        private System.Windows.Forms.TextBox textBox3;
    }
}