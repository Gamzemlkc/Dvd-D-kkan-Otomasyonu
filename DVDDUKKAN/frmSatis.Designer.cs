namespace DVDDUKKAN
{
    partial class frmSatis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKapak = new System.Windows.Forms.GroupBox();
            this.pbKapak = new System.Windows.Forms.PictureBox();
            this.dgvDvdListe = new System.Windows.Forms.DataGridView();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.grpRaf = new System.Windows.Forms.GroupBox();
            this.lblRafBilgisi = new System.Windows.Forms.Label();
            this.grpDurum = new System.Windows.Forms.GroupBox();
            this.rbSat = new System.Windows.Forms.RadioButton();
            this.rbKirala = new System.Windows.Forms.RadioButton();
            this.btnIslem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrSatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpKapak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).BeginInit();
            this.grpRaf.SuspendLayout();
            this.grpDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSatisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMusteriler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(452, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(12, 46);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(380, 21);
            this.cmbMusteriler.TabIndex = 3;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen Müşteri Seçiniz:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            // 
            // grpKapak
            // 
            this.grpKapak.Controls.Add(this.pbKapak);
            this.grpKapak.Location = new System.Drawing.Point(452, 46);
            this.grpKapak.Name = "grpKapak";
            this.grpKapak.Size = new System.Drawing.Size(192, 304);
            this.grpKapak.TabIndex = 7;
            this.grpKapak.TabStop = false;
            this.grpKapak.Text = "DvD Kapak İmaj";
            // 
            // pbKapak
            // 
            this.pbKapak.Location = new System.Drawing.Point(6, 26);
            this.pbKapak.Name = "pbKapak";
            this.pbKapak.Size = new System.Drawing.Size(180, 272);
            this.pbKapak.TabIndex = 0;
            this.pbKapak.TabStop = false;
            this.pbKapak.Click += new System.EventHandler(this.pbKapak_Click);
            // 
            // dgvDvdListe
            // 
            this.dgvDvdListe.AllowUserToAddRows = false;
            this.dgvDvdListe.AllowUserToDeleteRows = false;
            this.dgvDvdListe.AllowUserToOrderColumns = true;
            this.dgvDvdListe.AllowUserToResizeColumns = false;
            this.dgvDvdListe.AllowUserToResizeRows = false;
            this.dgvDvdListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDvdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvdListe.Location = new System.Drawing.Point(13, 79);
            this.dgvDvdListe.Name = "dgvDvdListe";
            this.dgvDvdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDvdListe.Size = new System.Drawing.Size(431, 298);
            this.dgvDvdListe.TabIndex = 6;
            this.dgvDvdListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDvdListe_CellContentClick);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(13, 46);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(431, 21);
            this.cmbKategoriler.TabIndex = 5;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // grpRaf
            // 
            this.grpRaf.Controls.Add(this.lblRafBilgisi);
            this.grpRaf.Location = new System.Drawing.Point(650, 46);
            this.grpRaf.Name = "grpRaf";
            this.grpRaf.Size = new System.Drawing.Size(200, 100);
            this.grpRaf.TabIndex = 9;
            this.grpRaf.TabStop = false;
            this.grpRaf.Text = "Raf Bilgisi";
            // 
            // lblRafBilgisi
            // 
            this.lblRafBilgisi.Location = new System.Drawing.Point(0, 33);
            this.lblRafBilgisi.Name = "lblRafBilgisi";
            this.lblRafBilgisi.Size = new System.Drawing.Size(188, 24);
            this.lblRafBilgisi.TabIndex = 0;
            // 
            // grpDurum
            // 
            this.grpDurum.Controls.Add(this.rbSat);
            this.grpDurum.Controls.Add(this.rbKirala);
            this.grpDurum.Location = new System.Drawing.Point(650, 152);
            this.grpDurum.Name = "grpDurum";
            this.grpDurum.Size = new System.Drawing.Size(200, 100);
            this.grpDurum.TabIndex = 10;
            this.grpDurum.TabStop = false;
            this.grpDurum.Text = "Durumu";
            // 
            // rbSat
            // 
            this.rbSat.AutoSize = true;
            this.rbSat.Location = new System.Drawing.Point(9, 27);
            this.rbSat.Name = "rbSat";
            this.rbSat.Size = new System.Drawing.Size(46, 17);
            this.rbSat.TabIndex = 0;
            this.rbSat.TabStop = true;
            this.rbSat.Text = "SAT";
            this.rbSat.UseVisualStyleBackColor = true;
            // 
            // rbKirala
            // 
            this.rbKirala.AutoSize = true;
            this.rbKirala.Location = new System.Drawing.Point(9, 55);
            this.rbKirala.Name = "rbKirala";
            this.rbKirala.Size = new System.Drawing.Size(63, 17);
            this.rbKirala.TabIndex = 0;
            this.rbKirala.TabStop = true;
            this.rbKirala.Text = "KİRALA";
            this.rbKirala.UseVisualStyleBackColor = true;
            // 
            // btnIslem
            // 
            this.btnIslem.BackColor = System.Drawing.Color.Peru;
            this.btnIslem.Location = new System.Drawing.Point(657, 259);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(199, 91);
            this.btnIslem.TabIndex = 11;
            this.btnIslem.Text = "İŞLEM YAP";
            this.btnIslem.UseVisualStyleBackColor = false;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // nmrSatisFiyati
            // 
            this.nmrSatisFiyati.Location = new System.Drawing.Point(293, 397);
            this.nmrSatisFiyati.Name = "nmrSatisFiyati";
            this.nmrSatisFiyati.Size = new System.Drawing.Size(120, 20);
            this.nmrSatisFiyati.TabIndex = 13;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(293, 438);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Satiş Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adet :";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.nmrSatisFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKapak);
            this.Controls.Add(this.dgvDvdListe);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.grpRaf);
            this.Controls.Add(this.grpDurum);
            this.Controls.Add(this.btnIslem);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpKapak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).EndInit();
            this.grpRaf.ResumeLayout(false);
            this.grpDurum.ResumeLayout(false);
            this.grpDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSatisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKapak;
        private System.Windows.Forms.PictureBox pbKapak;
        private System.Windows.Forms.DataGridView dgvDvdListe;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.GroupBox grpRaf;
        private System.Windows.Forms.Label lblRafBilgisi;
        private System.Windows.Forms.GroupBox grpDurum;
        private System.Windows.Forms.RadioButton rbSat;
        private System.Windows.Forms.RadioButton rbKirala;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrSatisFiyati;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}