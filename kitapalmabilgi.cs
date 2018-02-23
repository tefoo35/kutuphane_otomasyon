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
    public partial class kitapalmabilgi : Form
    {
        KitapAl al = new KitapAl();

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=true");
        int sayac = 0;

        public kitapalmabilgi()
        {
            InitializeComponent();
        }
        public int ogrno { get; set; }
        public int barkodno { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            DateTime son = DateTime.Today.AddDays(15);
            SqlCommand sayibul = new SqlCommand("select *from OkumaSayisi", baglan);
            SqlDataReader oku = sayibul.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(label5.Text) == Convert.ToInt32(oku["OkulNo"].ToString()))
                {
                    int Id=Convert.ToInt32(oku["Id"].ToString());
                    SqlCommand uyelik = new SqlCommand("update OkumaSayisi set KitapSayisi=@KitapSayisi where Id=@Id", baglan);
                    int okuma = Convert.ToInt32(oku["KitapSayisi"].ToString());
                    okuma++;
                    uyelik.Parameters.Add("@KitapSayisi",okuma);
                    uyelik.Parameters.Add("@Id",Id);
                    uyelik.ExecuteNonQuery();

                }
            }


            SqlCommand Durum = new SqlCommand("insert into Durum values(@VerilenTarih,@AlmaTarih,@BarkodNo,@OkulNo,@Bildirim)", baglan);
            Durum.Parameters.Add("@VerilenTarih", DateTime.Now);
            Durum.Parameters.Add("@AlmaTarih", son);
            Durum.Parameters.Add("@BarkodNo", label5.Text);
            Durum.Parameters.Add("@OkulNo", label23.Text);
            Durum.Parameters.Add("@Bildirim", "Verilmedi");
            Durum.ExecuteNonQuery();

            SqlCommand islemkayıt = new SqlCommand("insert into İslemler values(@VerilenTarih,@AlınanTarih,@OgrAdi,@OgrSoyad,@OkulNo,@KitapAdi,@BarkodNo,@Durum)", baglan);
            islemkayıt.Parameters.Add("@VerilenTarih", DateTime.Now);
            islemkayıt.Parameters.Add("@AlınanTarih", DBNull.Value);//null girilmeli!!
            islemkayıt.Parameters.Add("@OgrAdi", label2.Text);
            islemkayıt.Parameters.Add("@OgrSoyad", label3.Text);
            islemkayıt.Parameters.Add("@OkulNo", label5.Text);
            islemkayıt.Parameters.Add("@KitapAdi", label17.Text);
            islemkayıt.Parameters.Add("@BarkodNo", label23.Text);
            islemkayıt.Parameters.Add("@Durum", "EMANET");
            islemkayıt.ExecuteNonQuery();
            MessageBox.Show("Kitap Verilmiştir!");
            this.Hide();
     
            baglan.Close();
           

        }

        private void kitapalmabilgi_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kitap = new SqlCommand("select *from Kitap", baglan);
            SqlCommand ogrenci = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader okukitap = kitap.ExecuteReader();

            while (okukitap.Read())
            {
                if (barkodno == Convert.ToInt32(okukitap["BarkodNo"].ToString()))
                {
                    label17.Text = okukitap["KitapAdi"].ToString();
                    label15.Text = okukitap["KitapSayfa"].ToString();
                    label13.Text = okukitap["KitapYayınevi"].ToString();
                    label23.Text = okukitap["BarkodNo"].ToString();

                    sayac++;
                    break;
                }
            }
            okukitap.Close();
            SqlDataReader ogroku = ogrenci.ExecuteReader();
            while (ogroku.Read())
            {
                if (ogrno == Convert.ToInt32(ogroku["OkulNo"].ToString()))
                {
                    label2.Text = ogroku["Ad"].ToString();
                    label3.Text = ogroku["SoyAd"].ToString();
                    label5.Text = ogroku["OkulNo"].ToString();
                    label11.Text = ogroku["Tel"].ToString();
                    label8.Text = ogroku["Sinif"].ToString();
                    label9.Text = ogroku["Sube"].ToString();
                    sayac++;
                    break;
                }
            }
            ogroku.Close();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
