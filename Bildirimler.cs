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
    public partial class Bildirimler : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=true");
        public Bildirimler()
        {
            InitializeComponent();
        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }
        int sayac = 0;
        int barkod, no;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int Ono, Bno;
        DateTime vermetarih = DateTime.Today;
        public void kontrol(int no, int no2)
        {

           
            String kitapadi="", ad="", soyad = "", sınıf = "", sube = "";
            SqlCommand ogr = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader okuogr = ogr.ExecuteReader();
            while (okuogr.Read())
            {
                if (no == Convert.ToInt32(okuogr["OkulNo"].ToString()))
                {
                    ad = okuogr["Ad"].ToString();
                    soyad = okuogr["Soyad"].ToString();
                    sınıf = okuogr["Sinif"].ToString();
                    sube = okuogr["Sube"].ToString();
                    break;
                }
            }
            okuogr.Close();

            SqlCommand kitap = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader kitapoku = kitap.ExecuteReader();
            while (kitapoku.Read())
            {
                if (no2 == Convert.ToInt32(kitapoku["BarkodNo"].ToString()))
                {
                    kitapadi = kitapoku["KitapAdi"].ToString();

                    break;
                }
            }
            kitapoku.Close();

            listView1.Items.Add(ad);
            listView1.Items[sayac].SubItems.Add(soyad);
            listView1.Items[sayac].SubItems.Add(no.ToString());
            listView1.Items[sayac].SubItems.Add(sınıf + "/" + sube);
            listView1.Items[sayac].SubItems.Add(kitapadi);
            listView1.Items[sayac].SubItems.Add(no2.ToString());
            listView1.Items[sayac].SubItems.Add(vermetarih.ToString());
            sayac++;
        }
    


    private void Bildirimler_Load(object sender, EventArgs e)
{
    listView1.View = View.Details;
            listView1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Italic);
    listView1.Columns.Add("Ad", 150, HorizontalAlignment.Center);
    listView1.Columns.Add("Soyad", 150, HorizontalAlignment.Center);
    listView1.Columns.Add("OkulNo", 120, HorizontalAlignment.Center);
    listView1.Columns.Add("Sınıf/Şube", 150, HorizontalAlignment.Center);
    listView1.Columns.Add("KitapAdı", 175, HorizontalAlignment.Center);
    listView1.Columns.Add("BarkodNo", 120, HorizontalAlignment.Center);
    listView1.Columns.Add("VermeTarihi", 150, HorizontalAlignment.Center);
    baglan.Open();
    SqlCommand bul = new SqlCommand("select *from Durum", baglan);
    SqlDataReader oku = bul.ExecuteReader();
    SqlCommand kitapbul = new SqlCommand("select *from Kitap ", baglan);
    SqlDataReader kitapoku = kitapbul.ExecuteReader();
    SqlCommand ogrbul = new SqlCommand("select *from Ogrenci ", baglan);
    SqlDataReader Ogroku = ogrbul.ExecuteReader();
    int a = 0;

    while (oku.Read())
    {
                if (oku["Bildirim"].ToString() == "Verildi") { 
                vermetarih = Convert.ToDateTime(oku["AlmaTarih"].ToString());
              Ono = Convert.ToInt32(oku["OkulNo"].ToString());
        Bno = Convert.ToInt32(oku["BarkodNo"].ToString());
                if(Ono==null&&Bno==null)
                { Ono = 0; Bno = 0; }
                else { 
                    kontrol(Ono, Bno);
                    a++;
                }
                    }
            }

           
            oku.Close();
            Ogroku.Close();
    baglan.Close();
    if (a == 0)
    {
        MessageBox.Show("Bildirim Bulunmamaktadır!");
        this.Hide();
            }
}
    }
}