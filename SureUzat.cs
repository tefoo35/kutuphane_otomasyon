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
    public partial class SureUzat : Form
    {
        public SureUzat()
        {
            InitializeComponent();
        }

        private void SureUzat_Load(object sender, EventArgs e)
        {

        }
       

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            int sayac=0;
            SqlCommand bul = new SqlCommand("select *from Durum", baglan);
            SqlDataReader oku = bul.ExecuteReader();
            while (oku.Read())
            {
                if(Convert.ToInt32(oku["BarkodNo"].ToString())==Convert.ToInt32(textBox1.Text))
                  { DateTime tarih = Convert.ToDateTime(oku["AlmaTarih"].ToString());
                    tarih = tarih.AddDays(Convert.ToInt32(textBox2.Text));
                    int id = Convert.ToInt32(oku["Id"].ToString());
                    SqlCommand guncelle = new SqlCommand("update Durum set AlmaTarih=@AlmaTarih where Id=Id", baglan);
                    guncelle.Parameters.Add("@AlmaTarih", tarih);
                    guncelle.Parameters.Add("@Id", id);
                    guncelle.ExecuteNonQuery();
                    sayac++;
                    MessageBox.Show("Süre "+textBox2.Text+" Gün Uzatıldı!");
                    break;
                }
                        }
            baglan.Close();
            if (sayac == 0)
            {
                MessageBox.Show("Böyle Bir Emanet Kitap Bulunamadı!");
            }
            else
                this.Hide();
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
