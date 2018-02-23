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
    public partial class GeriVer : Form
    {
        int id, no, barkodno, id2;
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        int sayac = 0;
        public GeriVer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand durumoku = new SqlCommand("select *from Durum", baglan);
            SqlDataReader oku = durumoku.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(oku["BarkodNo"].ToString()))
                {
                    id = Convert.ToInt32(oku["Id"].ToString());
                    barkodno = Convert.ToInt32(oku["BarkodNo"].ToString());
                    no = Convert.ToInt32(oku["OkulNo"].ToString());
                    if (MessageBox.Show("Ogrenci numarası:   " + oku["OkulNo"].ToString() + "Kitap Barkod No:" + oku["BarkodNo"], "geri al", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sayac++;
                        break;
                    }
                    else
                        sayac += 2;
              
                  
                }
            }
            oku.Close();

            if (sayac == 1)
            {
                SqlCommand sildurum = new SqlCommand("delete from Durum  where Id=@Id", baglan);
                sildurum.Parameters.Add("@Id", id);
                sildurum.ExecuteNonQuery();
                SqlCommand islemoku = new SqlCommand("select *from İslemler", baglan);
                SqlDataReader okuislem = islemoku.ExecuteReader();
                while (okuislem.Read())
                {
                    if (barkodno == Convert.ToInt32(okuislem["BarkodNo"].ToString()) && no == Convert.ToInt32(okuislem["OkulNo"].ToString()) && okuislem["Durum"].ToString() == "EMANET")
                    {
                        id2 = Convert.ToInt32(okuislem["Id"].ToString());
                    }
                }
                okuislem.Close();


                SqlCommand islem = new SqlCommand("update İslemler set  AlınanTarih=@AlınanTarih,Durum=@Durum where Id=@Id", baglan);
                islem.Parameters.Add("@AlınanTarih", DateTime.Now);
                islem.Parameters.Add("@Durum", "ALINDI");
                islem.Parameters.Add("@Id", id2);
                islem.ExecuteNonQuery();
                this.Hide();
            }
            else if (sayac == 2)
            { }
            else
                MessageBox.Show("böyle bir kitap yok!!");
            sayac = 0;

            baglan.Close();
        }
    }
}
