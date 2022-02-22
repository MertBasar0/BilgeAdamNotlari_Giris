namespace arraySınıfıTekrar
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
            this.btn_arrayClear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_diziGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_arrayClear
            // 
            this.btn_arrayClear.Location = new System.Drawing.Point(12, 58);
            this.btn_arrayClear.Name = "btn_arrayClear";
            this.btn_arrayClear.Size = new System.Drawing.Size(153, 40);
            this.btn_arrayClear.TabIndex = 0;
            this.btn_arrayClear.Text = "arrayClear";
            this.btn_arrayClear.UseVisualStyleBackColor = true;
            this.btn_arrayClear.Click += new System.EventHandler(this.btn_arrayClear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(346, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(278, 436);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_diziGetir
            // 
            this.btn_diziGetir.Location = new System.Drawing.Point(12, 12);
            this.btn_diziGetir.Name = "btn_diziGetir";
            this.btn_diziGetir.Size = new System.Drawing.Size(153, 40);
            this.btn_diziGetir.TabIndex = 0;
            this.btn_diziGetir.Text = "diziGetir";
            this.btn_diziGetir.UseVisualStyleBackColor = true;
            this.btn_diziGetir.Click += new System.EventHandler(this.btn_diziGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_diziGetir);
            this.Controls.Add(this.btn_arrayClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_arrayClear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_diziGetir;
        private System.Windows.Forms.Label label1;
    }
}

