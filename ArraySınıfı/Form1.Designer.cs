namespace ArraySınıfı
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
            this.btn_Array1 = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_copy2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_tekrarEdenDeğerler = new System.Windows.Forms.Button();
            this.btn_reSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Array1
            // 
            this.btn_Array1.Location = new System.Drawing.Point(12, 12);
            this.btn_Array1.Name = "btn_Array1";
            this.btn_Array1.Size = new System.Drawing.Size(181, 53);
            this.btn_Array1.TabIndex = 0;
            this.btn_Array1.Text = "Array1";
            this.btn_Array1.UseVisualStyleBackColor = true;
            this.btn_Array1.Click += new System.EventHandler(this.btn_Array1_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(12, 128);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(181, 53);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(406, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 644);
            this.listBox1.TabIndex = 1;
            // 
            // btn_copy2
            // 
            this.btn_copy2.Location = new System.Drawing.Point(12, 242);
            this.btn_copy2.Name = "btn_copy2";
            this.btn_copy2.Size = new System.Drawing.Size(181, 53);
            this.btn_copy2.TabIndex = 0;
            this.btn_copy2.Text = "copy2";
            this.btn_copy2.UseVisualStyleBackColor = true;
            this.btn_copy2.Click += new System.EventHandler(this.btn_copy2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "İndexof";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btn_tekrarEdenDeğerler
            // 
            this.btn_tekrarEdenDeğerler.Location = new System.Drawing.Point(12, 442);
            this.btn_tekrarEdenDeğerler.Name = "btn_tekrarEdenDeğerler";
            this.btn_tekrarEdenDeğerler.Size = new System.Drawing.Size(181, 53);
            this.btn_tekrarEdenDeğerler.TabIndex = 0;
            this.btn_tekrarEdenDeğerler.Text = "tekrarDeğeri";
            this.btn_tekrarEdenDeğerler.UseVisualStyleBackColor = true;
            this.btn_tekrarEdenDeğerler.Click += new System.EventHandler(this.btn_tekrarEdenDeğerler_Click);
            // 
            // btn_reSize
            // 
            this.btn_reSize.Location = new System.Drawing.Point(12, 537);
            this.btn_reSize.Name = "btn_reSize";
            this.btn_reSize.Size = new System.Drawing.Size(181, 53);
            this.btn_reSize.TabIndex = 0;
            this.btn_reSize.Text = "reSize";
            this.btn_reSize.UseVisualStyleBackColor = true;
            this.btn_reSize.Click += new System.EventHandler(this.btn_reSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_reSize);
            this.Controls.Add(this.btn_tekrarEdenDeğerler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_copy2);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_Array1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Array1;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_copy2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_tekrarEdenDeğerler;
        private System.Windows.Forms.Button btn_reSize;
    }
}

