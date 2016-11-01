namespace DVDDUKKAN
{
    partial class frmDvdGiris
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.txtimajYolu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDurum = new System.Windows.Forms.GroupBox();
            this.rdDurum = new System.Windows.Forms.RadioButton();
            this.cmbRaf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(20, 47);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(488, 26);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir kategori seçiniz:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(161, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(347, 27);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "AÇIKLAMA";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(161, 113);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(347, 27);
            this.txtAciklama.TabIndex = 2;
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(161, 174);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(347, 32);
            this.btnResim.TabIndex = 3;
            this.btnResim.Text = "İMAJ SEÇ";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // txtimajYolu
            // 
            this.txtimajYolu.Location = new System.Drawing.Point(161, 146);
            this.txtimajYolu.Name = "txtimajYolu";
            this.txtimajYolu.Size = new System.Drawing.Size(347, 27);
            this.txtimajYolu.TabIndex = 2;
            this.txtimajYolu.TextChanged += new System.EventHandler(this.txtimajYolu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "İMAJ YOLU";
            // 
            // grpDurum
            // 
            this.grpDurum.Controls.Add(this.rdDurum);
            this.grpDurum.Location = new System.Drawing.Point(161, 212);
            this.grpDurum.Name = "grpDurum";
            this.grpDurum.Size = new System.Drawing.Size(347, 88);
            this.grpDurum.TabIndex = 4;
            this.grpDurum.TabStop = false;
            this.grpDurum.Text = "Durum";
            // 
            // rdDurum
            // 
            this.rdDurum.AutoSize = true;
            this.rdDurum.Location = new System.Drawing.Point(6, 36);
            this.rdDurum.Name = "rdDurum";
            this.rdDurum.Size = new System.Drawing.Size(93, 22);
            this.rdDurum.TabIndex = 0;
            this.rdDurum.TabStop = true;
            this.rdDurum.Text = "MEVCUT";
            this.rdDurum.UseVisualStyleBackColor = true;
            // 
            // cmbRaf
            // 
            this.cmbRaf.FormattingEnabled = true;
            this.cmbRaf.Location = new System.Drawing.Point(15, 335);
            this.cmbRaf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbRaf.Name = "cmbRaf";
            this.cmbRaf.Size = new System.Drawing.Size(488, 26);
            this.cmbRaf.TabIndex = 0;
            this.cmbRaf.SelectedIndexChanged += new System.EventHandler(this.cmbRaf_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Raf Seçiniz:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(357, 381);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 48);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDvdGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpDurum);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.txtimajYolu);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRaf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDvdGiris";
            this.Text = "frmDvdGiris";
            this.Load += new System.EventHandler(this.frmDvdGiris_Load);
            this.grpDurum.ResumeLayout(false);
            this.grpDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.TextBox txtimajYolu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpDurum;
        private System.Windows.Forms.RadioButton rdDurum;
        private System.Windows.Forms.ComboBox cmbRaf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}