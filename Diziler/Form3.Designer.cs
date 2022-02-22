namespace Diziler
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_ornek3 = new System.Windows.Forms.Button();
            this.btn_ornek4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(282, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(201, 388);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_birOrnek_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(860, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(201, 388);
            this.listBox2.TabIndex = 1;
            // 
            // btn_ornek3
            // 
            this.btn_ornek3.Location = new System.Drawing.Point(571, 12);
            this.btn_ornek3.Name = "btn_ornek3";
            this.btn_ornek3.Size = new System.Drawing.Size(208, 72);
            this.btn_ornek3.TabIndex = 0;
            this.btn_ornek3.Text = "ornek3";
            this.btn_ornek3.UseVisualStyleBackColor = true;
            this.btn_ornek3.Click += new System.EventHandler(this.btn_ornek3_Click);
            // 
            // btn_ornek4
            // 
            this.btn_ornek4.Location = new System.Drawing.Point(571, 167);
            this.btn_ornek4.Name = "btn_ornek4";
            this.btn_ornek4.Size = new System.Drawing.Size(208, 72);
            this.btn_ornek4.TabIndex = 0;
            this.btn_ornek4.Text = "Ornek4";
            this.btn_ornek4.UseVisualStyleBackColor = true;
            this.btn_ornek4.Click += new System.EventHandler(this.btn_ornek4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 696);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ornek4);
            this.Controls.Add(this.btn_ornek3);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_ornek3;
        private System.Windows.Forms.Button btn_ornek4;
    }
}