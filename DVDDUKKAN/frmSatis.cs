using DVDDUKKAN.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDDUKKAN
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        Kategoriler gelenKategori;
       
        private void frmSatis_Load(object sender, EventArgs e)
        {
            KategorileriGetir(cmbKategoriler);
            MusterileriGetir(cmbMusteriler);
        }

        private void MusterileriGetir(ComboBox cmbMusteriler)
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from Musteriler", cn);
                cn.Open();

                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Musteriler musteri = new Musteriler()
                        {
                            MusteriID = Convert.ToInt32(dr["MusteriID"]),
                            MusteriAdi = dr["MusteriAdi"].ToString(),
                            MusteriSoyadi = dr["MusteriSoyadi"].ToString(),
                            Adres = dr["Adres"].ToString(),
                            Tel = dr["Tel"].ToString()
                        };

                        cmbMusteriler.Items.Add(musteri);
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
        private void KategorileriGetir(ComboBox gelenkategoriler)
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from Kategoriler", cn);

                if (cn.State == ConnectionState.Closed) cn.Open();

                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Kategoriler k = new Kategoriler()
                        {
                            KategoriID = Convert.ToInt32(dr["KatID"]),
                            KategoriAdi = dr["KategoriAdi"].ToString(),
                            KategoriAciklama=dr["KategoriAciklama"].ToString()
                        };

                        gelenkategoriler.Items.Add(k);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }
        
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            gelenKategori = cmbKategoriler.SelectedItem as Kategoriler;

            DvdGetir(gelenKategori.KategoriID);
        }
        Raflar gelenRaf;

        private void RafGetir(int secilenraf)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("select * from Raflar where RafID=@id", cn);
                cmd2.Parameters.AddWithValue("@id", secilenraf);
                if (cn.State == ConnectionState.Closed) cn.Open();
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gelenRaf = new Raflar()
                        {
                            RafID = Convert.ToInt32(dr["RafID"]),
                            RafAdi = dr["RafAdi"].ToString(),
                            RafAciklama=dr["RafAciklama"].ToString()
                        };


                        lblRafBilgisi.Text = gelenRaf.RafAdi;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        Durumlar gelenDurum;

        private void DurumlariGetir(int secilenDurum)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from DurumlariGoster where DurumID=@id", cn);
                cmd.Parameters.AddWithValue("@id", secilenDurum);
                if (cn.State == ConnectionState.Closed) cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gelenDurum = new Durumlar()
                        {
                            DurumID = Convert.ToInt32(dr["DurumID"]),
                            DurumAdi = dr["DurumAdi"].ToString(),
                        };

                        if (gelenDurum.DurumID == 1) grpDurum.Enabled = true;
                        else grpDurum.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        List<Dvdler> ListeDvd = new List<Dvdler>();
        private void DvdGetir(int katid)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dvdler where KategoriID=@ID", cn);
                cmd.Parameters.AddWithValue("@ID", katid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        DurumlariGetir(Convert.ToInt32(dr["DurumID"]));
                        RafGetir(Convert.ToInt32(dr["RafID"]));
                        Dvdler dv = new Dvdler()
                        {
                            DvdID = Convert.ToInt32(dr["DvdID"]),
                            DvdAdi = dr["DvdAdi"].ToString(),
                            Dvdimajyolu = dr["DvdImajYolu"].ToString(),
                            DvdAciklama = dr["DvdAciklama"].ToString(),
                            KategoriID = gelenKategori,
                            DurumID = gelenDurum,
                            RafID = gelenRaf
                        };
                        ListeDvd.Add(dv);
                    }
                    dgvDvdListe.DataSource = ListeDvd;
                    dgvDvdListe.Columns[0].Visible = false;
                    dgvDvdListe.Columns[3].Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally { cn.Close(); }
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musteriler musteriDetay = cmbMusteriler.SelectedItem as Musteriler;
        }
        Dvdler secilenDvd;
        private void dgvDvdListe_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilenDvdSirasi = dgvDvdListe.SelectedRows[0].Index;

            secilenDvd = ListeDvd[secilenDvdSirasi];

            lblRafBilgisi.Text = secilenDvd.DurumID.DurumAdi;
            pbKapak.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + secilenDvd.Dvdimajyolu;
            
        }
        Siparisler gelenSiparis;
        private void SiparisleriGetir()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Siparisler S ORDER BY S.SiparisID DESC", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            gelenSiparis = new Siparisler()
                            {
                                SiparisID = Convert.ToInt32(dr["SiparisID"]),
                                SiparisTarihi = (DateTime)dr["SiparisTarihi"],
                                MusteriID = Convert.ToInt32(dr["MusteriID"])
                            };
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

        private void btnIslem_Click(object sender, EventArgs e)
        {
            int DurumID = 2;
            if (rbSat.Checked)
                DurumID = 3;
            bool sonuc = false;
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmdDvdUpdate = new SqlCommand("UPDATE Dvdler SET DurumID=@DurumID WHERE DvdID=@DvdID", cn);
                    cmdDvdUpdate.Parameters.AddWithValue("@DvdID", secilenDvd.DvdID);
                    cmdDvdUpdate.Parameters.AddWithValue("@DurumID", DurumID);
                    sonuc = cmdDvdUpdate.ExecuteNonQuery() > 0;
                    cn.Close();
                }
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmdSiparisEkle = new SqlCommand("INSERT INTO Siparisler (SiparisTarihi,MusteriID) VALUES (@SiparisTarihi,@MusteriID)", cn);
                    cmdSiparisEkle.Parameters.AddWithValue("@SiparisTarihi", DateTime.Now);
                    cmdSiparisEkle.Parameters.AddWithValue("@MusteriID", (cmbMusteriler.SelectedItem as Musteriler).MusteriID);
                    sonuc = cmdSiparisEkle.ExecuteNonQuery() > 0;
                    cn.Close();
                    SiparisleriGetir();
                }
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmdSiparisDetayEkle = new SqlCommand("INSERT INTO SiparisDetaylar (SiparisIDsi,SatisFiyati,Adet,DvdID) VALUES (@SiparisID,@SatisFiyat,@Adet,@DvdID)", cn);
                    cmdSiparisDetayEkle.Parameters.AddWithValue("@SiparisID", gelenSiparis.SiparisID);
                    cmdSiparisDetayEkle.Parameters.AddWithValue("@SatisFiyat", nmrSatisFiyati.Value);
                    cmdSiparisDetayEkle.Parameters.AddWithValue("@Adet", nmrAdet.Value);
                    cmdSiparisDetayEkle.Parameters.AddWithValue("@DvdID", secilenDvd.DvdID);
                    sonuc = cmdSiparisDetayEkle.ExecuteNonQuery() > 0;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show(sonuc ? "Ürün Ekleme işlemi Başarı ile Gerçekleşti." : "Ekleme sırasında bir hata oluştu.", "Ekleme Bildirimi", MessageBoxButtons.OK, sonuc ? MessageBoxIcon.Information : MessageBoxIcon.Stop);

                pbKapak.ImageLocation = string.Empty;
                lblRafBilgisi.Text = string.Empty;
                nmrAdet.Value = nmrAdet.Minimum;
                nmrSatisFiyati.Value = nmrSatisFiyati.Minimum;
                cmbMusteriler.SelectedIndex = -1;
                rbKirala.Checked = false;
                rbSat.Checked = false;

                cn.Close();
            }
        }

        private void pbKapak_Click(object sender, EventArgs e)
        {

        }

        private void dgvDvdListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
