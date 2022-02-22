namespace arrayListOrneklerTekrar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_diziyiGetir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_diziToplam = new System.Windows.Forms.Button();
            this.btn_elemanSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(242, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 436);
            this.listBox1.TabIndex = 1;
            // 
            // btn_diziyiGetir
            // 
            this.btn_diziyiGetir.Location = new System.Drawing.Point(12, 58);
            this.btn_diziyiGetir.Name = "btn_diziyiGetir";
            this.btn_diziyiGetir.Size = new System.Drawing.Size(108, 40);
            this.btn_diziyiGetir.TabIndex = 0;
            this.btn_diziyiGetir.Text = "elemanıGetir";
            this.btn_diziyiGetir.UseVisualStyleBackColor = true;
            this.btn_diziyiGetir.Click += new System.EventHandler(this.btn_diziyiGetir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_diziToplam
            // 
            this.btn_diziToplam.Location = new System.Drawing.Point(12, 104);
            this.btn_diziToplam.Name = "btn_diziToplam";
            this.btn_diziToplam.Size = new System.Drawing.Size(108, 40);
            this.btn_diziToplam.TabIndex = 0;
            this.btn_diziToplam.Text = "diziToplam";
            this.btn_diziToplam.UseVisualStyleBackColor = true;
            this.btn_diziToplam.Click += new System.EventHandler(this.btn_diziToplam_Click);
            // 
            // btn_elemanSil
            // 
            this.btn_elemanSil.Location = new System.Drawing.Point(12, 150);
            this.btn_elemanSil.Name = "btn_elemanSil";
            this.btn_elemanSil.Size = new System.Drawing.Size(108, 40);
            this.btn_elemanSil.TabIndex = 0;
            this.btn_elemanSil.Text = "elemanSil";
            this.btn_elemanSil.UseVisualStyleBackColor = true;
            this.btn_elemanSil.Click += new System.EventHandler(this.btn_elemanSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_elemanSil);
            this.Controls.Add(this.btn_diziToplam);
            this.Controls.Add(this.btn_diziyiGetir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_diziyiGetir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_diziToplam;
        private System.Windows.Forms.Button btn_elemanSil;
    }
}

