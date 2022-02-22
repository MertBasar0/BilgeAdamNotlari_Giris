namespace ForDöngüsü2
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
            this.ForDonguleri = new System.Windows.Forms.ListBox();
            this.btn_Sayma = new System.Windows.Forms.Button();
            this.btn_tersSay = new System.Windows.Forms.Button();
            this.btn_ikiserSayma = new System.Windows.Forms.Button();
            this.btn_toplamıBas = new System.Windows.Forms.Button();
            this.btn_A_Z = new System.Windows.Forms.Button();
            this.btn_toplamınınKaresi = new System.Windows.Forms.Button();
            this.btn_yıllar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForDonguleri
            // 
            this.ForDonguleri.FormattingEnabled = true;
            this.ForDonguleri.ItemHeight = 16;
            this.ForDonguleri.Location = new System.Drawing.Point(5, 9);
            this.ForDonguleri.Name = "ForDonguleri";
            this.ForDonguleri.Size = new System.Drawing.Size(554, 1044);
            this.ForDonguleri.TabIndex = 0;
            // 
            // btn_Sayma
            // 
            this.btn_Sayma.Location = new System.Drawing.Point(594, 30);
            this.btn_Sayma.Name = "btn_Sayma";
            this.btn_Sayma.Size = new System.Drawing.Size(215, 45);
            this.btn_Sayma.TabIndex = 1;
            this.btn_Sayma.Text = "Say";
            this.btn_Sayma.UseVisualStyleBackColor = true;
            this.btn_Sayma.Click += new System.EventHandler(this.btn_Sayma_Click);
            // 
            // btn_tersSay
            // 
            this.btn_tersSay.Location = new System.Drawing.Point(594, 115);
            this.btn_tersSay.Name = "btn_tersSay";
            this.btn_tersSay.Size = new System.Drawing.Size(215, 45);
            this.btn_tersSay.TabIndex = 1;
            this.btn_tersSay.Text = "TersSay";
            this.btn_tersSay.UseVisualStyleBackColor = true;
            this.btn_tersSay.Click += new System.EventHandler(this.btn_tersSay_Click);
            // 
            // btn_ikiserSayma
            // 
            this.btn_ikiserSayma.Location = new System.Drawing.Point(594, 208);
            this.btn_ikiserSayma.Name = "btn_ikiserSayma";
            this.btn_ikiserSayma.Size = new System.Drawing.Size(215, 45);
            this.btn_ikiserSayma.TabIndex = 1;
            this.btn_ikiserSayma.Text = "İkişerSay";
            this.btn_ikiserSayma.UseVisualStyleBackColor = true;
            this.btn_ikiserSayma.Click += new System.EventHandler(this.btn_ikiserSayma_Click);
            // 
            // btn_toplamıBas
            // 
            this.btn_toplamıBas.Location = new System.Drawing.Point(594, 298);
            this.btn_toplamıBas.Name = "btn_toplamıBas";
            this.btn_toplamıBas.Size = new System.Drawing.Size(215, 45);
            this.btn_toplamıBas.TabIndex = 1;
            this.btn_toplamıBas.Text = "ToplamıBas";
            this.btn_toplamıBas.UseVisualStyleBackColor = true;
            this.btn_toplamıBas.Click += new System.EventHandler(this.btn_toplamıBas_Click);
            // 
            // btn_A_Z
            // 
            this.btn_A_Z.Location = new System.Drawing.Point(594, 388);
            this.btn_A_Z.Name = "btn_A_Z";
            this.btn_A_Z.Size = new System.Drawing.Size(215, 45);
            this.btn_A_Z.TabIndex = 1;
            this.btn_A_Z.Text = "A_Z";
            this.btn_A_Z.UseVisualStyleBackColor = true;
            this.btn_A_Z.Click += new System.EventHandler(this.btn_A_Z_Click);
            // 
            // btn_toplamınınKaresi
            // 
            this.btn_toplamınınKaresi.Location = new System.Drawing.Point(594, 479);
            this.btn_toplamınınKaresi.Name = "btn_toplamınınKaresi";
            this.btn_toplamınınKaresi.Size = new System.Drawing.Size(215, 45);
            this.btn_toplamınınKaresi.TabIndex = 1;
            this.btn_toplamınınKaresi.Text = "ToplamınKaresi";
            this.btn_toplamınınKaresi.UseVisualStyleBackColor = true;
            this.btn_toplamınınKaresi.Click += new System.EventHandler(this.btn_toplamınınKaresi_Click);
            // 
            // btn_yıllar
            // 
            this.btn_yıllar.Location = new System.Drawing.Point(594, 570);
            this.btn_yıllar.Name = "btn_yıllar";
            this.btn_yıllar.Size = new System.Drawing.Size(215, 45);
            this.btn_yıllar.TabIndex = 1;
            this.btn_yıllar.Text = "Yıllar";
            this.btn_yıllar.UseVisualStyleBackColor = true;
            this.btn_yıllar.Click += new System.EventHandler(this.btn_yıllar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 1054);
            this.Controls.Add(this.btn_yıllar);
            this.Controls.Add(this.btn_toplamınınKaresi);
            this.Controls.Add(this.btn_A_Z);
            this.Controls.Add(this.btn_toplamıBas);
            this.Controls.Add(this.btn_ikiserSayma);
            this.Controls.Add(this.btn_tersSay);
            this.Controls.Add(this.btn_Sayma);
            this.Controls.Add(this.ForDonguleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ForDonguleri;
        private System.Windows.Forms.Button btn_Sayma;
        private System.Windows.Forms.Button btn_tersSay;
        private System.Windows.Forms.Button btn_ikiserSayma;
        private System.Windows.Forms.Button btn_toplamıBas;
        private System.Windows.Forms.Button btn_A_Z;
        private System.Windows.Forms.Button btn_toplamınınKaresi;
        private System.Windows.Forms.Button btn_yıllar;
    }
}

