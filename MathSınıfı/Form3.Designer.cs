namespace MathSınıfı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_firs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_startStop = new System.Windows.Forms.Button();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "1.png");
            this.imgList.Images.SetKeyName(1, "2.jpg");
            this.imgList.Images.SetKeyName(2, "3.jpg");
            this.imgList.Images.SetKeyName(3, "4.jpg");
            this.imgList.Images.SetKeyName(4, "5.jpeg");
            this.imgList.Images.SetKeyName(5, "6.jpg");
            this.imgList.Images.SetKeyName(6, "7.jpg");
            this.imgList.Images.SetKeyName(7, "8.jpg");
            this.imgList.Images.SetKeyName(8, "9.jpg");
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(44, 263);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 1;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1506, 263);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(1416, 695);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 1;
            this.btn_last.Text = "Last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_firs
            // 
            this.btn_firs.Location = new System.Drawing.Point(138, 695);
            this.btn_firs.Name = "btn_firs";
            this.btn_firs.Size = new System.Drawing.Size(75, 23);
            this.btn_firs.TabIndex = 1;
            this.btn_firs.Text = "First";
            this.btn_firs.UseVisualStyleBackColor = true;
            this.btn_firs.Click += new System.EventHandler(this.btn_firs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_startStop
            // 
            this.btn_startStop.Location = new System.Drawing.Point(766, 695);
            this.btn_startStop.Name = "btn_startStop";
            this.btn_startStop.Size = new System.Drawing.Size(75, 23);
            this.btn_startStop.TabIndex = 2;
            this.btn_startStop.Text = "StartStop";
            this.btn_startStop.UseVisualStyleBackColor = true;
            this.btn_startStop.Click += new System.EventHandler(this.btn_startStop_Click);
            // 
            // pcbResim
            // 
            this.pcbResim.Location = new System.Drawing.Point(138, 71);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(1341, 598);
            this.pcbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResim.TabIndex = 3;
            this.pcbResim.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 822);
            this.Controls.Add(this.pcbResim);
            this.Controls.Add(this.btn_startStop);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_firs);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_firs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_startStop;
        private System.Windows.Forms.PictureBox pcbResim;
    }
}