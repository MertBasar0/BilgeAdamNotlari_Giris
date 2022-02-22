namespace ForLabOrnekleriTEkrar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_carpımTablosu = new System.Windows.Forms.Button();
            this.btn_caprazX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(592, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 420);
            this.listBox1.TabIndex = 0;
            // 
            // btn_carpımTablosu
            // 
            this.btn_carpımTablosu.Location = new System.Drawing.Point(12, 12);
            this.btn_carpımTablosu.Name = "btn_carpımTablosu";
            this.btn_carpımTablosu.Size = new System.Drawing.Size(146, 47);
            this.btn_carpımTablosu.TabIndex = 1;
            this.btn_carpımTablosu.Text = "ÇarpımTablosu";
            this.btn_carpımTablosu.UseVisualStyleBackColor = true;
            this.btn_carpımTablosu.Click += new System.EventHandler(this.btn_carpımTablosu_Click);
            // 
            // btn_caprazX
            // 
            this.btn_caprazX.Location = new System.Drawing.Point(12, 65);
            this.btn_caprazX.Name = "btn_caprazX";
            this.btn_caprazX.Size = new System.Drawing.Size(146, 47);
            this.btn_caprazX.TabIndex = 1;
            this.btn_caprazX.Text = "ÇaprazX";
            this.btn_caprazX.UseVisualStyleBackColor = true;
            this.btn_caprazX.Click += new System.EventHandler(this.btn_caprazX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_caprazX);
            this.Controls.Add(this.btn_carpımTablosu);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_carpımTablosu;
        private System.Windows.Forms.Button btn_caprazX;
        private System.Windows.Forms.Label label1;
    }
}

