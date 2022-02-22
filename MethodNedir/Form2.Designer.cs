namespace MethodNedir
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
            this.btn_Ornek1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Ornek2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ornek1
            // 
            this.btn_Ornek1.Location = new System.Drawing.Point(12, 12);
            this.btn_Ornek1.Name = "btn_Ornek1";
            this.btn_Ornek1.Size = new System.Drawing.Size(200, 45);
            this.btn_Ornek1.TabIndex = 0;
            this.btn_Ornek1.Text = "Ornek1";
            this.btn_Ornek1.UseVisualStyleBackColor = true;
            this.btn_Ornek1.Click += new System.EventHandler(this.btn_Ornek1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(237, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 564);
            this.listBox1.TabIndex = 1;
            // 
            // btn_Ornek2
            // 
            this.btn_Ornek2.Location = new System.Drawing.Point(12, 63);
            this.btn_Ornek2.Name = "btn_Ornek2";
            this.btn_Ornek2.Size = new System.Drawing.Size(200, 45);
            this.btn_Ornek2.TabIndex = 0;
            this.btn_Ornek2.Text = "Ornek2";
            this.btn_Ornek2.UseVisualStyleBackColor = true;
            this.btn_Ornek2.Click += new System.EventHandler(this.btn_Ornek2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 585);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Ornek2);
            this.Controls.Add(this.btn_Ornek1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ornek1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Ornek2;
    }
}