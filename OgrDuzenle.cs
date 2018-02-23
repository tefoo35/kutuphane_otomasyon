using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kutuphane2
{
    public partial class OgrDuzenle : Form
    {

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=True"); int sayac = 0;

        public OgrDuzenle()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        int Id;
        private void OgrDuzenle_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader oku = kontrol.ExecuteReader();
            while (oku.Read())
            {

                if (id ==Convert.ToInt32(oku["OkulNo"].ToString()))
                { 
                 

                    Id = Convert.ToInt32(oku["Id"].ToString());
                    textBox2.Text = oku["Ad"].ToString();
                    textBox3.Text = oku["Soyad"].ToString();
                    textBox4.Text = oku["OkulNo"].ToString();
                    textBox5.Text = oku["Tel"].ToString();
                    comboBox1.Text = oku["Sinif"].ToString();
                    comboBox2.Text = oku["Sube"].ToString();

                    break;
                }
            }
            oku.Close();
            baglan.Close();
        }
        int okulno;
        OgrListe ol = new OgrListe();
        private void button1_Click(object sender, EventArgs e)
        {
           
            baglan.Open();
            SqlCommand bul = new SqlCommand("select *from Ogrenci", baglan);
            SqlCommand kitapsayisil = new SqlCommand("delete from OkumaSayisi where OkulNo=@OkulNo", baglan);
            SqlDataReader oku = bul.ExecuteReader();
            SqlCommand sil = new SqlCommand("delete from Ogrenci where Id=@Id", baglan);
            SqlCommand kontrol = new SqlCommand("select *from Durum", baglan);
            SqlDataReader kontroloku = kontrol.ExecuteReader();
            while (oku.Read())
            {
               
                if (id ==Convert.ToInt32(oku["OkulNo"].ToString()) )
                {
                    okulno = Convert.ToInt32(oku["OkulNo"].ToString());
                    while (kontroloku.Read())
                    {
                        if (Convert.ToInt32(kontroloku["OkulNo"].ToString()) == Convert.ToInt32(oku["OkulNo"].ToString()))
                        {
                            
                            sayac++;
                            break;
                        }

                    }

                    if(sayac==1)
                        MessageBox.Show("        Şuanda Emanet Kitap Bulunuyor!\n   \t     Silinme Başarısız!");
                    else { 
                    int id = Convert.ToInt32(oku["Id"].ToString());
                    sayac++;
                    if (MessageBox.Show("Öğrenci Bilgileri:\n     Adı: " + oku["Ad"] + "\n     Soyisim: " + oku["Soyad"] + "\n\n          Silinsinmi?", "Öğrenci Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                            kitapsayisil.Parameters.Add("@OkulNo", okulno);
                        sil.Parameters.Add("@Id", id);
                            kitapsayisil.ExecuteNonQuery();
                        MessageBox.Show("Öğrenci Silinmiştir.");
                            sil.ExecuteNonQuery();
                            this.Hide();
                            ol.Show();
                            break;
                    }

                }
                }
            }
            oku.Close();
           
               
            
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
        
            if (textBox5.Text.Length >= 12)
            {
                MessageBox.Show("Fazla Rakam Girdiniz!");
             
            }
            else
            {
                SqlCommand ogrguncelle = new SqlCommand("update Ogrenci set Ad=@Ad,Soyad=@Soyad,OkulNo=@OkulNo,Tel=@Tel,Sinif=@Sinif,Sube=@Sube where Id=@Id", baglan);
                ogrguncelle.Parameters.Add("@Ad", textBox2.Text);
                ogrguncelle.Parameters.Add("@Soyad", textBox3.Text);
                ogrguncelle.Parameters.Add("@OkulNo", textBox4.Text);
                ogrguncelle.Parameters.Add("@Tel", textBox5.Text);
                ogrguncelle.Parameters.Add("@Sinif", comboBox1.Text);
                ogrguncelle.Parameters.Add("@Sube", comboBox2.Text);

                ogrguncelle.Parameters.Add("@Id", Id);
                ogrguncelle.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Güncellenmiştir.");
                this.Hide();
                ol.Show();
              
            }
           





            baglan.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
