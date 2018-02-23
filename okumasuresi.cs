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
    public partial class okumasuresi : Form
    {
        public okumasuresi()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void okumasuresi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet5.OkumaSayisi' table. You can move, or remove it, as needed.
            this.okumaSayisiTableAdapter.Fill(this.kutuphaneDataSet5.OkumaSayisi);

        }
    }
}
