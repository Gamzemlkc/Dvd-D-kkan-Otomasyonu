namespace DVDDUKKAN
{
    partial class frmMain
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
            this.btnDvd = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDvd
            // 
            this.btnDvd.Location = new System.Drawing.Point(12, 24);
            this.btnDvd.Name = "btnDvd";
            this.btnDvd.Size = new System.Drawing.Size(217, 70);
            this.btnDvd.TabIndex = 0;
            this.btnDvd.Text = "DVD GİRİSİ YAP";
            this.btnDvd.UseVisualStyleBackColor = true;
            this.btnDvd.Click += new System.EventHandler(this.btnDvd_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(235, 24);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(217, 70);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "SATIŞ YAP";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 109);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnDvd);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDvd;
        private System.Windows.Forms.Button btnSatis;
    }
}