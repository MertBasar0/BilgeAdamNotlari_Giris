namespace HorseRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Sifirla = new System.Windows.Forms.Button();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BahisAl = new System.Windows.Forms.Button();
            this.pcp_Horse3 = new System.Windows.Forms.PictureBox();
            this.pcp_Horse2 = new System.Windows.Forms.PictureBox();
            this.pcp_Horse1 = new System.Windows.Forms.PictureBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sifirla
            // 
            this.btn_Sifirla.Location = new System.Drawing.Point(501, 713);
            this.btn_Sifirla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sifirla.Name = "btn_Sifirla";
            this.btn_Sifirla.Size = new System.Drawing.Size(130, 43);
            this.btn_Sifirla.TabIndex = 1;
            this.btn_Sifirla.Text = "Sıfırla";
            this.btn_Sifirla.UseVisualStyleBackColor = true;
            this.btn_Sifirla.Click += new System.EventHandler(this.btn_Sifirla_Click);
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(676, 713);
            this.btn_baslat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(130, 43);
            this.btn_baslat.TabIndex = 2;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Location = new System.Drawing.Point(1424, 0);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(19, 843);
            this.btn_Finish.TabIndex = 3;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // btn_BahisAl
            // 
            this.btn_BahisAl.Location = new System.Drawing.Point(337, 713);
            this.btn_BahisAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BahisAl.Name = "btn_BahisAl";
            this.btn_BahisAl.Size = new System.Drawing.Size(130, 43);
            this.btn_BahisAl.TabIndex = 7;
            this.btn_BahisAl.Text = "Bahis Al";
            this.btn_BahisAl.UseVisualStyleBackColor = true;
            this.btn_BahisAl.Click += new System.EventHandler(this.btn_BahisAl_Click);
            // 
            // pcp_Horse3
            // 
            this.pcp_Horse3.Image = global::HorseRacing.Properties.Resources.horse3__2_;
            this.pcp_Horse3.Location = new System.Drawing.Point(9, 381);
            this.pcp_Horse3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcp_Horse3.Name = "pcp_Horse3";
            this.pcp_Horse3.Size = new System.Drawing.Size(203, 136);
            this.pcp_Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcp_Horse3.TabIndex = 5;
            this.pcp_Horse3.TabStop = false;
            // 
            // pcp_Horse2
            // 
            this.pcp_Horse2.Image = global::HorseRacing.Properties.Resources.horse3__1_;
            this.pcp_Horse2.Location = new System.Drawing.Point(3, 193);
            this.pcp_Horse2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcp_Horse2.Name = "pcp_Horse2";
            this.pcp_Horse2.Size = new System.Drawing.Size(209, 136);
            this.pcp_Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcp_Horse2.TabIndex = 4;
            this.pcp_Horse2.TabStop = false;
            // 
            // pcp_Horse1
            // 
            this.pcp_Horse1.Image = global::HorseRacing.Properties.Resources.ebede532f6f5cf644a3fcf79d14b046c;
            this.pcp_Horse1.Location = new System.Drawing.Point(9, 0);
            this.pcp_Horse1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcp_Horse1.Name = "pcp_Horse1";
            this.pcp_Horse1.Size = new System.Drawing.Size(203, 136);
            this.pcp_Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcp_Horse1.TabIndex = 0;
            this.pcp_Horse1.TabStop = false;
            this.pcp_Horse1.MouseHover += new System.EventHandler(this.pcp_Horse1_MouseHover);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(856, 713);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(130, 43);
            this.btn_Cikis.TabIndex = 8;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 843);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_BahisAl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcp_Horse3);
            this.Controls.Add(this.pcp_Horse2);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.btn_Sifirla);
            this.Controls.Add(this.pcp_Horse1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcp_Horse1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcp_Horse1;
        private System.Windows.Forms.Button btn_Sifirla;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcp_Horse2;
        private System.Windows.Forms.PictureBox pcp_Horse3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BahisAl;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

