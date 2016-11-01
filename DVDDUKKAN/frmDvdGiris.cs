using DVDDUKKAN.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDDUKKAN
{
    public partial class frmDvdGiris : Form
    {
        public frmDvdGiris()
        {
            InitializeComponent();
        }
        private void frmDvdGiris_Load(object sender, EventArgs e)
        {
            KategorileriGetir(cmbKategori);
            RaflariGetir(cmbRaf);

        }

        private void RaflariGetir(ComboBox eklenecekraflar)
        {
          
            try
            {
                SqlCommand cmd = new SqlCommand("Select RafID,RafAdi from Raflar", cn);
                if (cn.State == ConnectionState.Closed) cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Raflar r = new Raflar()
                        {
                            RafID=Convert.ToInt32(dr["RafID"]),
                            RafAdi = dr["RafAdi"].ToString()
                        };
                        eklenecekraflar.Items.Add(r);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        SqlConnection cn = new SqlConnection(Baglanti.conn);
        private void KategorileriGetir(ComboBox eklenecekKategoriler)
        {
                try
            {
                SqlCommand cmd = new SqlCommand("Select KatID,KategoriAdi from Kategoriler", cn);
                if (cn.State == ConnectionState.Closed) cn.Open();
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Kategoriler k = new Kategoriler()
                            {
                                KategoriID = Convert.ToInt32(dr["KatID"]),
                                KategoriAdi = dr["KategoriAdi"].ToString()
                            };
                            eklenecekKategoriler.Items.Add(k);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool sonuc = false;
            int durum = 1;
            if (!rdDurum.Checked)
                durum = 4;
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Dvdler (DvdAdi,DvdAciklama,DvdImajYolu,RafID,KategoriID,DurumID) VALUES(@DvdAdi,@Aciklama,@DvdImajYolu,@RafID,@KategoriID,@DurumID)", cn);
                    cmd.Parameters.AddWithValue("@DvdAdi", txtAd.Text);
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    cmd.Parameters.AddWithValue("@DvdImajYolu",txtimajYolu.Text );
                    cmd.Parameters.AddWithValue("@RafID", (cmbRaf.SelectedItem as Raflar).RafID);
                    cmd.Parameters.AddWithValue("@KategoriID", (cmbKategori.SelectedItem as Kategoriler).KategoriID);
                    cmd.Parameters.AddWithValue("@DurumID", durum);
                    sonuc = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show(sonuc ? "Ürün Ekleme işlemi Başarı ile Gerçekleşti." : "Ekleme sırasında bir hata oluştu.", "Ekleme Bildirimi", MessageBoxButtons.OK, sonuc ? MessageBoxIcon.Information : MessageBoxIcon.Stop);
                txtAciklama.Text = string.Empty;
                txtAd.Text = string.Empty;
                txtimajYolu.Text = string.Empty;
                cmbKategori.SelectedIndex = -1;
                cmbRaf.SelectedIndex = -1;
                rdDurum.Checked = false;
                cn.Close();
            }
        }


        string imajYolu;
        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "png Dosyası|*.png";
            file.ShowDialog();
            txtimajYolu.Text = file.FileName;
            imajYolu = @"Resimler\" + file.SafeFileName;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtimajYolu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRaf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
