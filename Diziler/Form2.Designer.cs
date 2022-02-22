namespace Diziler
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
            this.btn_sonEleman = new System.Windows.Forms.Button();
            this.btn_rasgeleGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_diziGetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_diziSıralama = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_sonEleman
            // 
            this.btn_sonEleman.Location = new System.Drawing.Point(12, 12);
            this.btn_sonEleman.Name = "btn_sonEleman";
            this.btn_sonEleman.Size = new System.Drawing.Size(111, 49);
            this.btn_sonEleman.TabIndex = 0;
            this.btn_sonEleman.Text = "sonEleman";
            this.btn_sonEleman.UseVisualStyleBackColor = true;
            this.btn_sonEleman.Click += new System.EventHandler(this.btn_sonEleman_Click);
            // 
            // btn_rasgeleGetir
            // 
            this.btn_rasgeleGetir.Location = new System.Drawing.Point(166, 12);
            this.btn_rasgeleGetir.Name = "btn_rasgeleGetir";
            this.btn_rasgeleGetir.Size = new System.Drawing.Size(111, 49);
            this.btn_rasgeleGetir.TabIndex = 0;
            this.btn_rasgeleGetir.Text = "rasgeleGetir";
            this.btn_rasgeleGetir.UseVisualStyleBackColor = true;
            this.btn_rasgeleGetir.Click += new System.EventHandler(this.btn_rasgeleGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // btn_diziGetir
            // 
            this.btn_diziGetir.Location = new System.Drawing.Point(8, 123);
            this.btn_diziGetir.Name = "btn_diziGetir";
            this.btn_diziGetir.Size = new System.Drawing.Size(115, 30);
            this.btn_diziGetir.TabIndex = 2;
            this.btn_diziGetir.Text = "diziGetir";
            this.btn_diziGetir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(166, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 468);
            this.listBox1.TabIndex = 3;
            // 
            // btn_diziSıralama
            // 
            this.btn_diziSıralama.Location = new System.Drawing.Point(538, 113);
            this.btn_diziSıralama.Name = "btn_diziSıralama";
            this.btn_diziSıralama.Size = new System.Drawing.Size(154, 51);
            this.btn_diziSıralama.TabIndex = 2;
            this.btn_diziSıralama.Text = "diziSıralama";
            this.btn_diziSıralama.UseVisualStyleBackColor = true;
            this.btn_diziSıralama.Click += new System.EventHandler(this.btn_diziSıralama_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(755, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(259, 468);
            this.listBox2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 568);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_diziSıralama);
            this.Controls.Add(this.btn_diziGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rasgeleGetir);
            this.Controls.Add(this.btn_sonEleman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sonEleman;
        private System.Windows.Forms.Button btn_rasgeleGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_diziGetir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_diziSıralama;
        private System.Windows.Forms.ListBox listBox2;
    }
}