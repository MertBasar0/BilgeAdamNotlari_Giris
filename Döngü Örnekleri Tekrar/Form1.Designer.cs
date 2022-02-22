namespace Döngü_Örnekleri_Tekrar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_mukemmelSayi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btn_mukemmelSayi
            // 
            this.btn_mukemmelSayi.Location = new System.Drawing.Point(256, 151);
            this.btn_mukemmelSayi.Name = "btn_mukemmelSayi";
            this.btn_mukemmelSayi.Size = new System.Drawing.Size(127, 45);
            this.btn_mukemmelSayi.TabIndex = 1;
            this.btn_mukemmelSayi.Text = "Giriş";
            this.btn_mukemmelSayi.UseVisualStyleBackColor = true;
            this.btn_mukemmelSayi.Click += new System.EventHandler(this.btn_mukemmelSayi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı giriniz..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mukemmelSayi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_mukemmelSayi;
        private System.Windows.Forms.Label label1;
    }
}

