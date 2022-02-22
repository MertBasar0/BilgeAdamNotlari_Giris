namespace DoWhile
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
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_doWhile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_While2 = new System.Windows.Forms.Button();
            this.btn_doWhile2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(83, 33);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(169, 44);
            this.btn_while.TabIndex = 0;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_doWhile
            // 
            this.btn_doWhile.Location = new System.Drawing.Point(83, 94);
            this.btn_doWhile.Name = "btn_doWhile";
            this.btn_doWhile.Size = new System.Drawing.Size(169, 44);
            this.btn_doWhile.TabIndex = 1;
            this.btn_doWhile.Text = "DoWhile";
            this.btn_doWhile.UseVisualStyleBackColor = true;
            this.btn_doWhile.Click += new System.EventHandler(this.btn_doWhile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(418, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 420);
            this.listBox1.TabIndex = 2;
            // 
            // btn_While2
            // 
            this.btn_While2.Location = new System.Drawing.Point(83, 195);
            this.btn_While2.Name = "btn_While2";
            this.btn_While2.Size = new System.Drawing.Size(169, 44);
            this.btn_While2.TabIndex = 0;
            this.btn_While2.Text = "While2";
            this.btn_While2.UseVisualStyleBackColor = true;
            this.btn_While2.Click += new System.EventHandler(this.btn_While2_Click);
            // 
            // btn_doWhile2
            // 
            this.btn_doWhile2.Location = new System.Drawing.Point(83, 256);
            this.btn_doWhile2.Name = "btn_doWhile2";
            this.btn_doWhile2.Size = new System.Drawing.Size(169, 44);
            this.btn_doWhile2.TabIndex = 1;
            this.btn_doWhile2.Text = "DoWhile2";
            this.btn_doWhile2.UseVisualStyleBackColor = true;
            this.btn_doWhile2.Click += new System.EventHandler(this.btn_doWhile2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 449);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_doWhile2);
            this.Controls.Add(this.btn_While2);
            this.Controls.Add(this.btn_doWhile);
            this.Controls.Add(this.btn_while);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_doWhile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_While2;
        private System.Windows.Forms.Button btn_doWhile2;
    }
}

