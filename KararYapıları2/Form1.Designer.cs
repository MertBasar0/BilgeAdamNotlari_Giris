﻿namespace KararYapıları2
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
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_KitapSatis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kontrol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(78, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(378, 169);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(144, 77);
            this.btn_kontrol.TabIndex = 2;
            this.btn_kontrol.Text = "Kontrol";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not giriniz..";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_KitapSatis);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(803, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 365);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // btn_KitapSatis
            // 
            this.btn_KitapSatis.Location = new System.Drawing.Point(378, 169);
            this.btn_KitapSatis.Name = "btn_KitapSatis";
            this.btn_KitapSatis.Size = new System.Drawing.Size(144, 77);
            this.btn_KitapSatis.TabIndex = 2;
            this.btn_KitapSatis.Text = "Satış";
            this.btn_KitapSatis.UseVisualStyleBackColor = true;
            this.btn_KitapSatis.Click += new System.EventHandler(this.btn_KitapSatis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap sayısını giriniz..";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 884);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_KitapSatis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

