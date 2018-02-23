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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True;MultipleActiveResultSets=true");

        int okulno, barkodno, sayac, id;

        private void bildirim()
        {
            SqlCommand okey = new SqlCommand("update Durum set Bildirim=@Bildirim where Id=@Id", baglan);
            okey.Parameters.Add("@Bildirim", "Verildi");
            okey.Parameters.Add("@Id", id);
            okey.ExecuteNonQuery();

            String kitapadi = "", ad = "", soyad = "";
            SqlCommand ogr = new SqlCommand("select *from Ogrenci", baglan);
            SqlDataReader okuogr = ogr.ExecuteReader();
            while (okuogr.Read())
            {
                if (okulno == Convert.ToInt32(okuogr["OkulNo"].ToString()))
                {
                    ad = okuogr["Ad"].ToString();
                    soyad = okuogr["Soyad"].ToString();

                    break;
                }
            }
            okuogr.Close();

            SqlCommand kitap = new SqlCommand("select *from Kitap", baglan);
            SqlDataReader kitapoku = kitap.ExecuteReader();
            while (kitapoku.Read())
            {
                if (barkodno == Convert.ToInt32(kitapoku["BarkodNo"].ToString()))
                {
                    kitapadi = kitapoku["KitapAdi"].ToString();

                    break;
                }
            }
            kitapoku.Close();
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = ad + "  " + soyad + "  öğrencinin " + kitapadi + "  adlı kitap iade vakti gelmiştir.";
            notifyIcon1.BalloonTipTitle = "İade Vakti Geldi!";
            notifyIcon1.BalloonTipClicked += new EventHandler(button11_Click);


            notifyIcon1.ShowBalloonTip(1000);

        }
        private void Form2_Load(object sender, EventArgs e)
        {


           



            DateTime zaman = DateTime.Now;

            baglan.Open();
            SqlCommand durumkontrol = new SqlCommand("select *from Durum", baglan);
            SqlDataReader durumoku = durumkontrol.ExecuteReader();
            while (durumoku.Read())
            {
                DateTime time = Convert.ToDateTime(durumoku["AlmaTarih"].ToString());

                if (zaman.Day == time.Day && zaman.Month == time.Month && zaman.Year == time.Year && durumoku["Bildirim"].ToString() == "Verilmedi")
                {
                    okulno = Convert.ToInt32(durumoku["OkulNo"].ToString());
                    id = Convert.ToInt32(durumoku["Id"].ToString());
                    barkodno = Convert.ToInt32(durumoku["BarkodNo"].ToString());
                    bildirim();

                }
            }
            durumoku.Close();

            if (sayac == 1)
            {


                sayac = 0;
            }

            else if (sayac != 0 && sayac != 1)
            {

            }

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.Visible = false;
                button3.Visible = false;
            }

            else
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                button7.Visible = false;
                button8.Visible = false; button10.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapEkle ekle = new KitapEkle();
            ekle.StartPosition = FormStartPosition.CenterScreen;
            ekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            kitapliste kitaplist = new kitapliste();

            kitaplist.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button4.Visible)
            {
                button4.Visible = false;
                button5.Visible = false;
            }

            else
            {

                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false; button10.Visible = false;
                button8.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgrEkle ekle = new OgrEkle(); ekle.StartPosition = FormStartPosition.CenterScreen;
            ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrListe list = new OgrListe();

            list.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button10.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }

            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button7.Visible = true;
                button8.Visible = true;
                button10.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GeriVer ver = new GeriVer(); ver.StartPosition = FormStartPosition.CenterScreen;
            ver.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KitapAl al = new KitapAl(); al.StartPosition = FormStartPosition.CenterScreen;
            al.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SureUzat sure = new SureUzat(); sure.StartPosition = FormStartPosition.CenterScreen;
            sure.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Bildirimler b = new Bildirimler();
            b.WindowState = FormWindowState.Maximized;
            b.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            okumasuresi o = new okumasuresi(); o.WindowState = FormWindowState.Maximized;
            o.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Sonİslemler i = new Sonİslemler();
            i.WindowState = FormWindowState.Maximized;
            i.Show();
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bilgiler b = new bilgiler();
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nasıl n = new nasıl(); n.StartPosition = FormStartPosition.CenterScreen;
            n.Show();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Point lastpoint,lastpoint1;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
