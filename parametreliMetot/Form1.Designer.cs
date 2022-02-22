namespace parametreliMetot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_telParcala = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_terstenUc = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_arkaPlanıDegistir = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_toplamınKupu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_telParcala
            // 
            this.btn_telParcala.Location = new System.Drawing.Point(6, 45);
            this.btn_telParcala.Name = "btn_telParcala";
            this.btn_telParcala.Size = new System.Drawing.Size(95, 28);
            this.btn_telParcala.TabIndex = 1;
            this.btn_telParcala.Text = "telParcala";
            this.btn_telParcala.UseVisualStyleBackColor = true;
            this.btn_telParcala.Click += new System.EventHandler(this.btn_telParcala_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(510, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 433);
            this.listBox1.TabIndex = 2;
            // 
            // btn_terstenUc
            // 
            this.btn_terstenUc.Location = new System.Drawing.Point(206, 45);
            this.btn_terstenUc.Name = "btn_terstenUc";
            this.btn_terstenUc.Size = new System.Drawing.Size(95, 28);
            this.btn_terstenUc.TabIndex = 1;
            this.btn_terstenUc.Text = "terstenÜç";
            this.btn_terstenUc.UseVisualStyleBackColor = true;
            this.btn_terstenUc.Click += new System.EventHandler(this.btn_terstenUc_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "White",
            "Black",
            "Yellow",
            "Green",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(5, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btn_arkaPlanıDegistir
            // 
            this.btn_arkaPlanıDegistir.Location = new System.Drawing.Point(207, 73);
            this.btn_arkaPlanıDegistir.Name = "btn_arkaPlanıDegistir";
            this.btn_arkaPlanıDegistir.Size = new System.Drawing.Size(95, 35);
            this.btn_arkaPlanıDegistir.TabIndex = 1;
            this.btn_arkaPlanıDegistir.Text = "ArkaPlanıDegistir";
            this.btn_arkaPlanıDegistir.UseVisualStyleBackColor = true;
            this.btn_arkaPlanıDegistir.Click += new System.EventHandler(this.btn_arkaPlanıDegistir_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "White",
            "Black",
            "Yellow",
            "Green",
            "Blue"});
            this.comboBox2.Location = new System.Drawing.Point(5, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(297, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_toplamınKupu
            // 
            this.btn_toplamınKupu.Location = new System.Drawing.Point(207, 19);
            this.btn_toplamınKupu.Name = "btn_toplamınKupu";
            this.btn_toplamınKupu.Size = new System.Drawing.Size(95, 34);
            this.btn_toplamınKupu.TabIndex = 1;
            this.btn_toplamınKupu.Text = "Toplamın Küpü";
            this.btn_toplamınKupu.UseVisualStyleBackColor = true;
            this.btn_toplamınKupu.Click += new System.EventHandler(this.btn_toplamınKupu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.btn_toplamınKupu);
            this.groupBox1.Location = new System.Drawing.Point(7, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btn_arkaPlanıDegistir);
            this.groupBox2.Location = new System.Drawing.Point(7, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 114);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btn_telParcala);
            this.groupBox3.Controls.Add(this.btn_terstenUc);
            this.groupBox3.Location = new System.Drawing.Point(8, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 79);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_telParcala;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_terstenUc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_arkaPlanıDegistir;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_toplamınKupu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

