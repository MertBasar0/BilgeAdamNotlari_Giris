namespace ForLabOrnekleri
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CarpımTablosu = new System.Windows.Forms.Button();
            this.lbl_MetinAlani = new System.Windows.Forms.Label();
            this.btn_Ornek4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CarpımTablosu
            // 
            this.btn_CarpımTablosu.Location = new System.Drawing.Point(12, 126);
            this.btn_CarpımTablosu.Name = "btn_CarpımTablosu";
            this.btn_CarpımTablosu.Size = new System.Drawing.Size(138, 51);
            this.btn_CarpımTablosu.TabIndex = 1;
            this.btn_CarpımTablosu.Text = "Çarpım tablosu";
            this.btn_CarpımTablosu.UseVisualStyleBackColor = true;
            this.btn_CarpımTablosu.Click += new System.EventHandler(this.btn_CarpımTablosu_Click);
            // 
            // lbl_MetinAlani
            // 
            this.lbl_MetinAlani.AutoSize = true;
            this.lbl_MetinAlani.Location = new System.Drawing.Point(323, 47);
            this.lbl_MetinAlani.Name = "lbl_MetinAlani";
            this.lbl_MetinAlani.Size = new System.Drawing.Size(0, 16);
            this.lbl_MetinAlani.TabIndex = 2;
            // 
            // btn_Ornek4
            // 
            this.btn_Ornek4.Location = new System.Drawing.Point(12, 183);
            this.btn_Ornek4.Name = "btn_Ornek4";
            this.btn_Ornek4.Size = new System.Drawing.Size(138, 51);
            this.btn_Ornek4.TabIndex = 1;
            this.btn_Ornek4.Text = "ornek4";
            this.btn_Ornek4.UseVisualStyleBackColor = true;
            this.btn_Ornek4.Click += new System.EventHandler(this.btn_Ornek4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(396, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 276);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 477);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ornek4);
            this.Controls.Add(this.lbl_MetinAlani);
            this.Controls.Add(this.btn_CarpımTablosu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CarpımTablosu;
        private System.Windows.Forms.Label lbl_MetinAlani;
        private System.Windows.Forms.Button btn_Ornek4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

