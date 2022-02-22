namespace genericListTekrar
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
            this.btn_ternaryif = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_contains = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_sayisalDizi = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_elemanEkle = new System.Windows.Forms.Button();
            this.btn_reSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ternaryif
            // 
            this.btn_ternaryif.Location = new System.Drawing.Point(12, 12);
            this.btn_ternaryif.Name = "btn_ternaryif";
            this.btn_ternaryif.Size = new System.Drawing.Size(157, 29);
            this.btn_ternaryif.TabIndex = 0;
            this.btn_ternaryif.Text = "sırala";
            this.btn_ternaryif.UseVisualStyleBackColor = true;
            this.btn_ternaryif.Click += new System.EventHandler(this.btn_ternaryif_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(315, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 436);
            this.listBox1.TabIndex = 1;
            // 
            // btn_contains
            // 
            this.btn_contains.Location = new System.Drawing.Point(12, 73);
            this.btn_contains.Name = "btn_contains";
            this.btn_contains.Size = new System.Drawing.Size(157, 29);
            this.btn_contains.TabIndex = 0;
            this.btn_contains.Text = "Bul";
            this.btn_contains.UseVisualStyleBackColor = true;
            this.btn_contains.Click += new System.EventHandler(this.btn_contains_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_sayisalDizi
            // 
            this.btn_sayisalDizi.Location = new System.Drawing.Point(12, 166);
            this.btn_sayisalDizi.Name = "btn_sayisalDizi";
            this.btn_sayisalDizi.Size = new System.Drawing.Size(157, 29);
            this.btn_sayisalDizi.TabIndex = 0;
            this.btn_sayisalDizi.Text = "MaxMin";
            this.btn_sayisalDizi.UseVisualStyleBackColor = true;
            this.btn_sayisalDizi.Click += new System.EventHandler(this.btn_sayisalDizi_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btn_elemanEkle
            // 
            this.btn_elemanEkle.Location = new System.Drawing.Point(12, 137);
            this.btn_elemanEkle.Name = "btn_elemanEkle";
            this.btn_elemanEkle.Size = new System.Drawing.Size(157, 23);
            this.btn_elemanEkle.TabIndex = 4;
            this.btn_elemanEkle.Text = "Ekle";
            this.btn_elemanEkle.UseVisualStyleBackColor = true;
            this.btn_elemanEkle.Click += new System.EventHandler(this.btn_elemanEkle_Click);
            // 
            // btn_reSize
            // 
            this.btn_reSize.Location = new System.Drawing.Point(12, 201);
            this.btn_reSize.Name = "btn_reSize";
            this.btn_reSize.Size = new System.Drawing.Size(157, 29);
            this.btn_reSize.TabIndex = 0;
            this.btn_reSize.Text = "reSize";
            this.btn_reSize.UseVisualStyleBackColor = true;
            this.btn_reSize.Click += new System.EventHandler(this.btn_reSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 453);
            this.Controls.Add(this.btn_elemanEkle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_reSize);
            this.Controls.Add(this.btn_sayisalDizi);
            this.Controls.Add(this.btn_contains);
            this.Controls.Add(this.btn_ternaryif);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ternaryif;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_contains;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_sayisalDizi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_elemanEkle;
        private System.Windows.Forms.Button btn_reSize;
    }
}

