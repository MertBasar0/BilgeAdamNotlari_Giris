namespace SystemIO
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
            this.btn_systemIO2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_systemIO2
            // 
            this.btn_systemIO2.Location = new System.Drawing.Point(56, 32);
            this.btn_systemIO2.Name = "btn_systemIO2";
            this.btn_systemIO2.Size = new System.Drawing.Size(118, 24);
            this.btn_systemIO2.TabIndex = 0;
            this.btn_systemIO2.Text = "sistem2";
            this.btn_systemIO2.UseVisualStyleBackColor = true;
            this.btn_systemIO2.Click += new System.EventHandler(this.btn_systemIO2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(440, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 404);
            this.listBox1.TabIndex = 1;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(204, 32);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(118, 24);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.btn_systemIO2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_systemIO2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_file;
    }
}

