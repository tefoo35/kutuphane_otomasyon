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
    public partial class KitapDuzenle : Form
    {
        kitapliste kl = new kitapliste();
        int sayac;
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;MultipleActiveResultSets=true;Integrated Security=True");

        public KitapDuzenle()
        {
            InitializeComponent();
        }
        int Id;
        public int id { get; set; }
        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            baglan.Open();
            SqlCommand kitapoku = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader okukitap = kitapoku.ExecuteReader();
            while (okukitap.Read())
            {
                if (id == Convert.ToInt32(okukitap["BarkodNo"].ToString()))
                {
                    Id = Convert.ToInt32(okukitap["Id"].ToString());
                    textBox1.Text = okukitap["KitapAdi"].ToString();
                    textBox2.Text = okukitap["Yazar"].ToString();
                    textBox3.Text = okukitap["KitapSayfa"].ToString();
                    dateTimePicker1.Text = okukitap["KitapBasımTarih"].ToString();
                    textBox5.Text = okukitap["KitapYayınevi"].ToString();
                    textBox4.Text = okukitap["BarkodNo"].ToString();
                }
            }

            okukitap.Close();
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("select *from Kitap ", baglan);
            SqlDataReader oku = kontrol.ExecuteReader();
            while (oku.Read())
            {
              
            SqlCommand ogrguncelle = new SqlCommand("update Kitap set KitapAdi=@KitapAdi,Yazar=@Yazar,KitapSayfa=@KitapSayfa,KitapBasımTarih=@KitapBasımTarih,KitapYayınevi=@KitapYayınevi,BarkodNo=@BarkodNo where Id=@Id", baglan);
            ogrguncelle.Parameters.Add("@KitapAdi", textBox1.Text);
            ogrguncelle.Parameters.Add("@Yazar", textBox2.Text);
            ogrguncelle.Parameters.Add("@KitapSayfa", textBox3.Text);
            ogrguncelle.Parameters.Add("@KitapBasımTarih", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            ogrguncelle.Parameters.Add("@KitapYayınevi", textBox5.Text);
            ogrguncelle.Parameters.Add("@BarkodNo", textBox4.Text);
            ogrguncelle.Parameters.Add("@Id", Id);
            ogrguncelle.ExecuteNonQuery();
           
        }

            MessageBox.Show("Kitap Güncellenmiştir.");

            this.Hide();
            kl.Show();
            baglan.Close();
            oku.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from Kitap where Id=@Id", baglan);

            SqlCommand ara = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(oku["BarkodNo"].ToString()) == Convert.ToInt32(textBox4.Text))
                {
                    SqlCommand kontrol = new SqlCommand("select *from Durum", baglan);
                    SqlDataReader kontroloku = kontrol.ExecuteReader();
                    while (kontroloku.Read())
                    {
                        if (Convert.ToInt32(kontroloku["BarkodNo"].ToString()) == Convert.ToInt32(oku["BarkodNo"].ToString()))
                        {
                            sayac++;
                            break;
                        }

                    }

                    if (sayac == 1)
                        MessageBox.Show("       Şuanda Kitap Emanettedir.\n   \tSilinme Başarısız!");
                    else
                    {
                        int id = Convert.ToInt32(oku["Id"].ToString());
                        if (MessageBox.Show("Kitap Bilgileri:\n     Kitap Adı: " + oku["KitapAdi"].ToString() + "\n     Yayınevi: " + oku["KitapYayınevi"].ToString()+"\n\n          Silinsinmi?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sil.Parameters.Add("@Id", id);
                            sil.ExecuteNonQuery();
                            MessageBox.Show("Kitap Silinmiştir!");
                            this.Hide();
                            kl.Show();
                            sayac++;
                        }
                    }

                   


                }
            }
       oku.Close();
            baglan.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
