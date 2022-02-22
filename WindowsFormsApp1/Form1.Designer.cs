namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_BirinciSayi = new System.Windows.Forms.TextBox();
            this.btn_Topla = new System.Windows.Forms.Button();
            this.txt_İkinciSayi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "sayiBir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SayiIki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_İkinciSayi);
            this.panel1.Controls.Add(this.txt_BirinciSayi);
            this.panel1.Controls.Add(this.btn_Topla);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(104, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 436);
            this.panel1.TabIndex = 4;
            // 
            // txt_BirinciSayi
            // 
            this.txt_BirinciSayi.Location = new System.Drawing.Point(402, 78);
            this.txt_BirinciSayi.Name = "txt_BirinciSayi";
            this.txt_BirinciSayi.Size = new System.Drawing.Size(308, 22);
            this.txt_BirinciSayi.TabIndex = 5;
            // 
            // btn_Topla
            // 
            this.btn_Topla.Location = new System.Drawing.Point(403, 259);
            this.btn_Topla.Name = "btn_Topla";
            this.btn_Topla.Size = new System.Drawing.Size(216, 93);
            this.btn_Topla.TabIndex = 4;
            this.btn_Topla.Text = "Topla";
            this.btn_Topla.UseVisualStyleBackColor = true;
            this.btn_Topla.Click += new System.EventHandler(this.btn_Topla_Click);
            // 
            // txt_İkinciSayi
            // 
            this.txt_İkinciSayi.Location = new System.Drawing.Point(403, 148);
            this.txt_İkinciSayi.Name = "txt_İkinciSayi";
            this.txt_İkinciSayi.Size = new System.Drawing.Size(306, 22);
            this.txt_İkinciSayi.TabIndex = 6;
            this.txt_İkinciSayi.TextChanged += new System.EventHandler(this.txt_ikinciSayi_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 750);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Topla;
        private System.Windows.Forms.TextBox txt_BirinciSayi;
        private System.Windows.Forms.TextBox txt_İkinciSayi;
    }
}

