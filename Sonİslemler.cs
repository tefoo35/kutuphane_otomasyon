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
    public partial class Sonİslemler : Form
    {
        public Sonİslemler()
        {
            InitializeComponent();
        }

        private void Sonİslemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet3.İslemler' table. You can move, or remove it, as needed.
            this.İslemlerTableAdapter.Fill(this.kutuphaneDataSet3.İslemler);
          
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
