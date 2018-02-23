using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
namespace kutuphane2
{
    public partial class kitapliste : Form
    {
        public kitapliste()
        {
            InitializeComponent();
        }

        private void kitapliste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet2.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter1.Fill(this.kutuphaneDataSet2.Kitap);
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'kutuphaneDataSet1.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kutuphaneDataSet1.Kitap);
               }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
           
           
        }
      
        private void gridControl1_Click_1(object sender, EventArgs e)
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
           
            int id = int.Parse(gridView1.GetFocusedRowCellValue("BarkodNo").ToString());
       
            KitapDuzenle duzen = new KitapDuzenle();
            duzen.id = id;
            duzen.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            duzen.Show();

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
      
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

         
        }
    }
}
