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
    public partial class KitapAl : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        int sayac = 0;

        public KitapAl()
        {
            InitializeComponent();
        }
      


        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""&&textBox2.Text=="")
                MessageBox.Show("Bos kutucuk bırakmayınız!");
            else { 
            baglan.Open();
            SqlCommand kitapoku = new SqlCommand("select *from Kitap", baglan);
            SqlCommand ogroku = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader okukitap = kitapoku.ExecuteReader();
            while (okukitap.Read())
            {
                if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(okukitap["BarkodNo"].ToString()))
                {
                    sayac++;
                    break;
                }
            }

            okukitap.Close();

            SqlDataReader okuogr = ogroku.ExecuteReader();
            while (okuogr.Read())
            {
                if (Convert.ToInt32(textBox2.Text) == Convert.ToInt32(okuogr["OkulNo"].ToString()))
                {
                    sayac++;
                    break;
                }
            }
            okuogr.Close();
            SqlCommand islemler = new SqlCommand("select *from Durum", baglan);
            SqlDataReader islemoku = islemler.ExecuteReader();
            if (sayac == 2)
            {
                while (islemoku.Read())
                {
                    if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(islemoku["BarkodNo"].ToString()))
                    {
                        if (MessageBox.Show("suan kitap baskasında", "hata!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            sayac++;
                            break;
                        }
                    }
                }
            }
            if (sayac == 2)
            {
                kitapalmabilgi gec = new kitapalmabilgi();
                gec.barkodno = Convert.ToInt32(textBox1.Text);
                gec.ogrno = Convert.ToInt32(textBox2.Text);
                gec.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                gec.ShowDialog();
              
                  
            }

            if (sayac != 2 && sayac != 3)
            {
                if (MessageBox.Show("yanlıs bilgi girdiniz!", "yanlıs giris", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {

                }

            }
            sayac = 0;
            baglan.Close();
            }
        }

        private void KitapAl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
