using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2
{
    public partial class nasıl : Form
    {
        public nasıl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Öğrenci butonuna tıklayınız.\n\nEklemek için 'ekle' tuşuna silme/güncelleme yapmak için 'liste' tuşlarına basınız.\n\nEkle tuşuna basıldıktan sonra bilgileri girip yeni kayıt yapabilirsiniz.\n\nListe tuşuna bastıktan sonra karşınıza çıkan listeden silme/güncelleme yapacağınız\nöğrenciyi bulup çift tıklayınız.Karşınıza çıkan formdan işleminizi yapınız.v\n\nListede arama yapmak için arama çubuguna arama yapmak istediğiniz kelimeyi\nsayıyı,sınıfı,subeyi yazınız.İstersenizde sütun baslarına gelip çıkan simgeye tıklayıp\ndaha kapsamlı arama yapanilirisniz. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Kitap butonuna tıklayınız.\n\nEklemek için 'ekle' tuşuna silme/güncelleme yapmak için 'liste' tuşlarına basınız.\n\nEkle tuşuna basıldıktan sonra bilgileri girip yeni kayıt yapabilirsiniz.\n\nListe tuşuna bastıktan sonra karşınıza çıkan listeden silme/güncelleme yapacağınız\nkitabı bulup çift tıklayınız.Karşınıza çıkan formdan işleminizi yapınız.\n\nListede arama yapmak için arama çubuguna arama yapmak istediğiniz\nkitapadı/sayfasayısı/basımtarihi/barkodnosunu yazınız.İstersenizde sütun başlarına\ngelip çıkan simgeye tıklayıp daha kapsamlı arama yapanilirisniz. ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "Kütüphaneden kitap almak/vermek/süre uzatmak için 'kitap al-ver' tıklayınız.\n\nKitap almak için 'ödünç al'tıklayınız.Karşınıza çıkan ekranda barkod no ile\nöğrenci no'nuzu yazınız.Açılan sayfada kitapbilgisi ve öğrenci bilgisi bulunmaktadır.\nEğer doğruysa 'kitabı ver' tıkklayınız.\n\nKitabı geri vermek için 'geri ver' tıklayın.Barkod no'yu yazın ve geri verin.\n\nSüre uzatmak için 'süre uzat' tıklayın.Barkod no ile süreyi girin.   ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Selam,\nCBU Yazılım mühendisi öğrencisi Ali Tevfik Döner'im.Bu benim ilk büyük projem.\nElimden geldiğince güzel ve açıklayıcı yapmaya çalıştım.\nŞimdilik bu kadar kendinize iyi bakın :)";
        }

        private void nasıl_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
