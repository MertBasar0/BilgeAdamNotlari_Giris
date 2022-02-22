namespace Döngü_Örnekleri_Tekrar
{
    partial class Form3
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
            this.btn_Control = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Kontrol2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Control
            // 
            this.btn_Control.Location = new System.Drawing.Point(12, 12);
            this.btn_Control.Name = "btn_Control";
            this.btn_Control.Size = new System.Drawing.Size(97, 39);
            this.btn_Control.TabIndex = 0;
            this.btn_Control.Text = "Kontrol";
            this.btn_Control.UseVisualStyleBackColor = true;
            this.btn_Control.Click += new System.EventHandler(this.btn_Control_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Kontrol2
            // 
            this.btn_Kontrol2.Location = new System.Drawing.Point(12, 76);
            this.btn_Kontrol2.Name = "btn_Kontrol2";
            this.btn_Kontrol2.Size = new System.Drawing.Size(97, 39);
            this.btn_Kontrol2.TabIndex = 0;
            this.btn_Kontrol2.Text = "cümleKontrol";
            this.btn_Kontrol2.UseVisualStyleBackColor = true;
            this.btn_Kontrol2.Click += new System.EventHandler(this.btn_Kontrol2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Kontrol2);
            this.Controls.Add(this.btn_Control);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Control;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Kontrol2;
    }
}