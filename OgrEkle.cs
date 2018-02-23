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
    public partial class OgrEkle : Form
    {
        int sayac = 0;
       

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=true");
        public OgrEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader oku = kontrol.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(textBox4.Text)==Convert.ToInt32(oku["OkulNo"].ToString()))
                {
                    sayac++;
                    break;
                }
            }
            oku.Close();
            if (textBox3.Text.Length >= 12)
            {
                MessageBox.Show("Fazla Rakam Girdiniz!");
                sayac += 2;
            }
            else if (sayac == 0)
            {

                SqlCommand uyelik = new SqlCommand("insert into OkumaSayisi values(@OgrAd,@OgrSoyad,@KitapSayisi,@Sınıf,@Sube,@OkulNo)", baglan);
                uyelik.Parameters.Add("@OgrAd", textBox1.Text);
                uyelik.Parameters.Add("@OgrSoyad", textBox2.Text);
                uyelik.Parameters.Add("@KitapSayisi", Convert.ToInt32("0").ToString());
                uyelik.Parameters.Add("@Sınıf", comboBox1.Text);
                uyelik.Parameters.Add("@Sube", comboBox2.Text);
                uyelik.Parameters.Add("@OkulNo", textBox4.Text);
                uyelik.ExecuteNonQuery();
                SqlCommand ogrkaydet = new SqlCommand("insert into Ogrenci values(@Ad,@Soyad,@OkulNo,@Tel,@Sinif,@Sube)", baglan);
                ogrkaydet.Parameters.Add("@Ad", textBox1.Text);
                ogrkaydet.Parameters.Add("@Soyad", textBox2.Text);
                ogrkaydet.Parameters.Add("@Okulno", textBox4.Text);
                ogrkaydet.Parameters.Add("@Tel", textBox3.Text);
                ogrkaydet.Parameters.Add("@Sinif", comboBox1.Text);
                ogrkaydet.Parameters.Add("@Sube", comboBox2.Text);
                ogrkaydet.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Kaydolmuştur.");
                this.Close();
               
            }
            else
                MessageBox.Show("Aynı Numaradan Öğrenci Bulunuyor!!");

            sayac = 0;

            baglan.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OgrEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
       && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
       && !char.IsSeparator(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
          
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
       && !char.IsSeparator(e.KeyChar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
