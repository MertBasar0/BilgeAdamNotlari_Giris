namespace HorseRacing
{
    partial class HACK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HACK));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HACKLENDİN :)";
            // 
            // btn_Hack
            // 
            this.btn_Hack.Location = new System.Drawing.Point(117, 143);
            this.btn_Hack.Name = "btn_Hack";
            this.btn_Hack.Size = new System.Drawing.Size(220, 63);
            this.btn_Hack.TabIndex = 1;
            this.btn_Hack.Text = "Şakaydı..Devam";
            this.btn_Hack.UseVisualStyleBackColor = true;
            this.btn_Hack.Click += new System.EventHandler(this.btn_Hack_Click);
            // 
            // HACK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 266);
            this.Controls.Add(this.btn_Hack);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HACK";
            this.Text = "Horse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hack;
    }
}