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
    public partial class KitapEkle : Form
    {

        int sayac = 0;
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        anasayfa form = new anasayfa();
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
      
            if(textBox4.Text!="")
            { 
            SqlCommand ekle = new SqlCommand("insert into Kitap values(@KitapAdi,@Yazar,@KitapSayfa,@KitapBasimTarih,@KitapYayınevi,@BarkodNo)", baglan);
            SqlCommand bul = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader oku = bul.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text == oku["KitapAdi"].ToString() || Convert.ToInt32(textBox4.Text)== Convert.ToInt32(oku["BarkodNo"].ToString()))
                {
                    sayac++;
                    MessageBox.Show("Aynı İsimden Yada Aynı Barkoddan Kitap Bulunmaktadır.");
                    break;
                }
            }
            oku.Close();
            if (sayac == 0)
            {
                ekle.Parameters.Add("@kitapAdi", textBox1.Text);
                ekle.Parameters.Add("@Yazar", textBox2.Text);
                ekle.Parameters.Add("@KitapSayfa", textBox3.Text);
                ekle.Parameters.Add("@KitapBasimTarih", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                ekle.Parameters.Add("@KitapYayınevi", textBox5.Text);
                ekle.Parameters.Add("@BarkodNo", Convert.ToInt32(textBox4.Text));

                ekle.ExecuteNonQuery();
                MessageBox.Show("Kitap Eklenmiştir.");
                this.Close();
               
            }
           
            sayac = 0;
        }
            else
                MessageBox.Show("Boş Alan Bırakmayınız!");
            baglan.Close();
        }
     
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);}

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


