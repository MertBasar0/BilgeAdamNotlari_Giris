namespace DizilerTekrar
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
            this.btn_sırala = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ortalamaAltı = new System.Windows.Forms.Button();
            this.btn_sehirGetir = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_sehirTasi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_sehirBul = new System.Windows.Forms.Button();
            this.btn_duzenDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sırala
            // 
            this.btn_sırala.Location = new System.Drawing.Point(12, 12);
            this.btn_sırala.Name = "btn_sırala";
            this.btn_sırala.Size = new System.Drawing.Size(122, 37);
            this.btn_sırala.TabIndex = 0;
            this.btn_sırala.Text = "sırala";
            this.btn_sırala.UseVisualStyleBackColor = true;
            this.btn_sırala.Click += new System.EventHandler(this.btn_sırala_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(227, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(190, 372);
            this.listBox1.TabIndex = 1;
            // 
            // btn_ortalamaAltı
            // 
            this.btn_ortalamaAltı.Location = new System.Drawing.Point(12, 55);
            this.btn_ortalamaAltı.Name = "btn_ortalamaAltı";
            this.btn_ortalamaAltı.Size = new System.Drawing.Size(122, 37);
            this.btn_ortalamaAltı.TabIndex = 0;
            this.btn_ortalamaAltı.Text = "ortalamaAltı";
            this.btn_ortalamaAltı.UseVisualStyleBackColor = true;
            this.btn_ortalamaAltı.Click += new System.EventHandler(this.btn_ortalamaAltı_Click);
            // 
            // btn_sehirGetir
            // 
            this.btn_sehirGetir.Location = new System.Drawing.Point(12, 98);
            this.btn_sehirGetir.Name = "btn_sehirGetir";
            this.btn_sehirGetir.Size = new System.Drawing.Size(122, 37);
            this.btn_sehirGetir.TabIndex = 0;
            this.btn_sehirGetir.Text = "sehirGetir";
            this.btn_sehirGetir.UseVisualStyleBackColor = true;
            this.btn_sehirGetir.Click += new System.EventHandler(this.btn_sehirGetir_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(448, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(190, 372);
            this.listBox2.TabIndex = 1;
            // 
            // btn_sehirTasi
            // 
            this.btn_sehirTasi.Location = new System.Drawing.Point(12, 141);
            this.btn_sehirTasi.Name = "btn_sehirTasi";
            this.btn_sehirTasi.Size = new System.Drawing.Size(122, 37);
            this.btn_sehirTasi.TabIndex = 0;
            this.btn_sehirTasi.Text = "sehirTasi";
            this.btn_sehirTasi.UseVisualStyleBackColor = true;
            this.btn_sehirTasi.Click += new System.EventHandler(this.btn_sehirTasi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_sehirBul
            // 
            this.btn_sehirBul.Location = new System.Drawing.Point(131, 184);
            this.btn_sehirBul.Name = "btn_sehirBul";
            this.btn_sehirBul.Size = new System.Drawing.Size(90, 37);
            this.btn_sehirBul.TabIndex = 3;
            this.btn_sehirBul.Text = "sehirBul";
            this.btn_sehirBul.UseVisualStyleBackColor = true;
            this.btn_sehirBul.Click += new System.EventHandler(this.btn_sehirBul_Click);
            // 
            // btn_duzenDegistir
            // 
            this.btn_duzenDegistir.Location = new System.Drawing.Point(12, 227);
            this.btn_duzenDegistir.Name = "btn_duzenDegistir";
            this.btn_duzenDegistir.Size = new System.Drawing.Size(122, 37);
            this.btn_duzenDegistir.TabIndex = 0;
            this.btn_duzenDegistir.Text = "duzenDegistir";
            this.btn_duzenDegistir.UseVisualStyleBackColor = true;
            this.btn_duzenDegistir.Click += new System.EventHandler(this.btn_duzenDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 397);
            this.Controls.Add(this.btn_sehirBul);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_duzenDegistir);
            this.Controls.Add(this.btn_sehirTasi);
            this.Controls.Add(this.btn_sehirGetir);
            this.Controls.Add(this.btn_ortalamaAltı);
            this.Controls.Add(this.btn_sırala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sırala;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ortalamaAltı;
        private System.Windows.Forms.Button btn_sehirGetir;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_sehirTasi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_sehirBul;
        private System.Windows.Forms.Button btn_duzenDegistir;
    }
}

