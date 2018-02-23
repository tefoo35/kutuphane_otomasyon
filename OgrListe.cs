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
    public partial class OgrListe : Form
    {
        public OgrListe()
        {
            InitializeComponent();
        }

        private void OgrListe_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'kutuphaneDataSet.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.kutuphaneDataSet.Ogrenci);

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            int id = int.Parse(gridView1.GetFocusedRowCellValue("OkulNo").ToString());

            OgrDuzenle duzen = new OgrDuzenle();
            duzen.id = id;
            duzen.StartPosition = FormStartPosition.CenterScreen;

            duzen.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
            gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(255, 255, 192);
        }
    }
}
