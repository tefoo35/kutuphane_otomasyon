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
    public partial class bilgiler : Form
    {
        public bilgiler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        int ogr=0, kitap=0,kütkitapsayi=0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bilgiler_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ogrsayı = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader ogrbul = ogrsayı.ExecuteReader();
            while (ogrbul.Read())
            {
                ogr++;
                
            }
            ogrbul.Close();
            label2.Text = ogr.ToString();
            SqlCommand kitapsayı = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader kitapbul = kitapsayı.ExecuteReader();
            while (kitapbul.Read())
            {
                kitap++;

            }
            kitapbul.Close();
            label3.Text = kitap.ToString();

            SqlCommand kütüphanekitap = new SqlCommand("select *from Durum", baglan);
            SqlDataReader kütüphanebul = kütüphanekitap.ExecuteReader();
            while (kütüphanebul.Read())
            {
                kütkitapsayi++;

            }
            kütüphanebul.Close();
            label5.Text = (kitap - kütkitapsayi).ToString();
            baglan.Close();
        }
    }
}
