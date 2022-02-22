namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ornek = new System.Windows.Forms.Button();
            this.btn_Böl = new System.Windows.Forms.Button();
            this.btn_Çıkar = new System.Windows.Forms.Button();
            this.btn_Çarp = new System.Windows.Forms.Button();
            this.btn_Mod = new System.Windows.Forms.Button();
            this.btn_Toplam = new System.Windows.Forms.Button();
            this.txt_Sayi2 = new System.Windows.Forms.TextBox();
            this.txt_Sayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nud_Sayi1 = new System.Windows.Forms.NumericUpDown();
            this.nud_Sayi2 = new System.Windows.Forms.NumericUpDown();
            this.btn_topla = new System.Windows.Forms.Button();
            this.Lbl_text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_Ornek);
            this.groupBox1.Controls.Add(this.btn_Böl);
            this.groupBox1.Controls.Add(this.btn_Çıkar);
            this.groupBox1.Controls.Add(this.btn_Çarp);
            this.groupBox1.Controls.Add(this.btn_Mod);
            this.groupBox1.Controls.Add(this.btn_Toplam);
            this.groupBox1.Controls.Add(this.txt_Sayi2);
            this.groupBox1.Controls.Add(this.txt_Sayi1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1632, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matematiksel işlemler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Ornek
            // 
            this.btn_Ornek.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Ornek.Location = new System.Drawing.Point(535, 317);
            this.btn_Ornek.Name = "btn_Ornek";
            this.btn_Ornek.Size = new System.Drawing.Size(215, 51);
            this.btn_Ornek.TabIndex = 4;
            this.btn_Ornek.Text = "Ornek";
            this.btn_Ornek.UseVisualStyleBackColor = true;
            this.btn_Ornek.Click += new System.EventHandler(this.btn_Ornek_Click);
            // 
            // btn_Böl
            // 
            this.btn_Böl.Location = new System.Drawing.Point(6, 317);
            this.btn_Böl.Name = "btn_Böl";
            this.btn_Böl.Size = new System.Drawing.Size(215, 51);
            this.btn_Böl.TabIndex = 3;
            this.btn_Böl.Text = "Bölme";
            this.btn_Böl.UseVisualStyleBackColor = true;
            this.btn_Böl.Click += new System.EventHandler(this.btn_Böl_Click);
            // 
            // btn_Çıkar
            // 
            this.btn_Çıkar.Location = new System.Drawing.Point(6, 197);
            this.btn_Çıkar.Name = "btn_Çıkar";
            this.btn_Çıkar.Size = new System.Drawing.Size(215, 51);
            this.btn_Çıkar.TabIndex = 3;
            this.btn_Çıkar.Text = "Çıkar";
            this.btn_Çıkar.UseVisualStyleBackColor = true;
            this.btn_Çıkar.Click += new System.EventHandler(this.btn_Çıkar_Click);
            // 
            // btn_Çarp
            // 
            this.btn_Çarp.Location = new System.Drawing.Point(535, 196);
            this.btn_Çarp.Name = "btn_Çarp";
            this.btn_Çarp.Size = new System.Drawing.Size(215, 51);
            this.btn_Çarp.TabIndex = 3;
            this.btn_Çarp.Text = "Çarp";
            this.btn_Çarp.UseVisualStyleBackColor = true;
            this.btn_Çarp.Click += new System.EventHandler(this.btn_Çarp_Click);
            // 
            // btn_Mod
            // 
            this.btn_Mod.Location = new System.Drawing.Point(275, 317);
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(215, 51);
            this.btn_Mod.TabIndex = 3;
            this.btn_Mod.Text = "Mod";
            this.btn_Mod.UseVisualStyleBackColor = true;
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click);
            // 
            // btn_Toplam
            // 
            this.btn_Toplam.Location = new System.Drawing.Point(259, 195);
            this.btn_Toplam.Name = "btn_Toplam";
            this.btn_Toplam.Size = new System.Drawing.Size(231, 53);
            this.btn_Toplam.TabIndex = 2;
            this.btn_Toplam.Text = "Topla";
            this.btn_Toplam.UseVisualStyleBackColor = true;
            this.btn_Toplam.Click += new System.EventHandler(this.btn_Toplam_Click);
            // 
            // txt_Sayi2
            // 
            this.txt_Sayi2.Location = new System.Drawing.Point(259, 127);
            this.txt_Sayi2.Name = "txt_Sayi2";
            this.txt_Sayi2.Size = new System.Drawing.Size(231, 22);
            this.txt_Sayi2.TabIndex = 1;
            this.txt_Sayi2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Sayi1
            // 
            this.txt_Sayi1.Location = new System.Drawing.Point(259, 42);
            this.txt_Sayi1.Name = "txt_Sayi1";
            this.txt_Sayi1.Size = new System.Drawing.Size(231, 22);
            this.txt_Sayi1.TabIndex = 1;
            this.txt_Sayi1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // nud_Sayi1
            // 
            this.nud_Sayi1.Location = new System.Drawing.Point(102, 528);
            this.nud_Sayi1.Name = "nud_Sayi1";
            this.nud_Sayi1.Size = new System.Drawing.Size(120, 22);
            this.nud_Sayi1.TabIndex = 1;
            // 
            // nud_Sayi2
            // 
            this.nud_Sayi2.Location = new System.Drawing.Point(287, 528);
            this.nud_Sayi2.Name = "nud_Sayi2";
            this.nud_Sayi2.Size = new System.Drawing.Size(120, 22);
            this.nud_Sayi2.TabIndex = 2;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(200, 585);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(134, 23);
            this.btn_topla.TabIndex = 3;
            this.btn_topla.Text = "Topla";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // Lbl_text
            // 
            this.Lbl_text.AutoSize = true;
            this.Lbl_text.Location = new System.Drawing.Point(434, 534);
            this.Lbl_text.Name = "Lbl_text";
            this.Lbl_text.Size = new System.Drawing.Size(14, 16);
            this.Lbl_text.TabIndex = 4;
            this.Lbl_text.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 664);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_text);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.nud_Sayi2);
            this.Controls.Add(this.nud_Sayi1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_Sayi2;
        private System.Windows.Forms.TextBox txt_Sayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Toplam;
        private System.Windows.Forms.Button btn_Çıkar;
        private System.Windows.Forms.Button btn_Çarp;
        private System.Windows.Forms.Button btn_Mod;
        private System.Windows.Forms.Button btn_Böl;
        private System.Windows.Forms.Button btn_Ornek;
        private System.Windows.Forms.NumericUpDown nud_Sayi1;
        private System.Windows.Forms.NumericUpDown nud_Sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label Lbl_text;
        private System.Windows.Forms.Label label3;
    }
}