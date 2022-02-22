namespace TryCatch_hata_yonetimi
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Topla = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Onayla = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Hata_yonetimi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_DetaylıHata = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_finallyOnay = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn_HataTipleri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btn_Topla
            // 
            this.btn_Topla.Location = new System.Drawing.Point(80, 112);
            this.btn_Topla.Name = "btn_Topla";
            this.btn_Topla.Size = new System.Drawing.Size(102, 46);
            this.btn_Topla.TabIndex = 2;
            this.btn_Topla.Text = "topla";
            this.btn_Topla.UseVisualStyleBackColor = true;
            this.btn_Topla.Click += new System.EventHandler(this.btn_Topla_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 22);
            this.textBox3.TabIndex = 3;
            // 
            // Onayla
            // 
            this.Onayla.Location = new System.Drawing.Point(6, 99);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(291, 69);
            this.Onayla.TabIndex = 4;
            this.Onayla.Text = "Onayla";
            this.Onayla.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 22);
            this.textBox4.TabIndex = 3;
            // 
            // btn_Hata_yonetimi
            // 
            this.btn_Hata_yonetimi.Location = new System.Drawing.Point(11, 99);
            this.btn_Hata_yonetimi.Name = "btn_Hata_yonetimi";
            this.btn_Hata_yonetimi.Size = new System.Drawing.Size(291, 69);
            this.btn_Hata_yonetimi.TabIndex = 4;
            this.btn_Hata_yonetimi.Text = "Hata";
            this.btn_Hata_yonetimi.UseVisualStyleBackColor = true;
            this.btn_Hata_yonetimi.Click += new System.EventHandler(this.btn_Hata_yonetimi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Onayla);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(493, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "yönetimsiz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Hata_yonetimi);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(877, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 211);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TryCatch";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_DetaylıHata);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Location = new System.Drawing.Point(1228, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 200);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detaylı";
            // 
            // btn_DetaylıHata
            // 
            this.btn_DetaylıHata.Location = new System.Drawing.Point(90, 97);
            this.btn_DetaylıHata.Name = "btn_DetaylıHata";
            this.btn_DetaylıHata.Size = new System.Drawing.Size(235, 61);
            this.btn_DetaylıHata.TabIndex = 1;
            this.btn_DetaylıHata.Text = "Detaylı";
            this.btn_DetaylıHata.UseVisualStyleBackColor = true;
            this.btn_DetaylıHata.Click += new System.EventHandler(this.btn_DetaylıHata_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(278, 22);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.btn_finallyOnay);
            this.groupBox4.Location = new System.Drawing.Point(12, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 200);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finally";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(126, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 22);
            this.textBox6.TabIndex = 1;
            // 
            // btn_finallyOnay
            // 
            this.btn_finallyOnay.Location = new System.Drawing.Point(167, 122);
            this.btn_finallyOnay.Name = "btn_finallyOnay";
            this.btn_finallyOnay.Size = new System.Drawing.Size(181, 51);
            this.btn_finallyOnay.TabIndex = 0;
            this.btn_finallyOnay.Text = "Finally";
            this.btn_finallyOnay.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.btn_HataTipleri);
            this.groupBox5.Location = new System.Drawing.Point(560, 388);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(468, 200);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hata Tipleri";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(126, 42);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(253, 22);
            this.textBox7.TabIndex = 1;
            // 
            // btn_HataTipleri
            // 
            this.btn_HataTipleri.Location = new System.Drawing.Point(167, 122);
            this.btn_HataTipleri.Name = "btn_HataTipleri";
            this.btn_HataTipleri.Size = new System.Drawing.Size(181, 51);
            this.btn_HataTipleri.TabIndex = 0;
            this.btn_HataTipleri.Text = "Hata tipleri";
            this.btn_HataTipleri.UseVisualStyleBackColor = true;
            this.btn_HataTipleri.Click += new System.EventHandler(this.btn_HataTipleri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 690);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Topla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Topla;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Hata_yonetimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DetaylıHata;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_finallyOnay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn_HataTipleri;
    }
}

