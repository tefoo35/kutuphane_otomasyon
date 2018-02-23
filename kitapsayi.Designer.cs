namespace kutuphane2
{
    partial class kitapsayi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kutuphaneDataSet3 = new kutuphane2.KutuphaneDataSet3();
            this.islemlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İslemlerTableAdapter = new kutuphane2.KutuphaneDataSet3TableAdapters.İslemlerTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVerilenTarih = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAlınanTarih = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOgrAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOgrSoyad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBarkodNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDurum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneDataSet3
            // 
            this.kutuphaneDataSet3.DataSetName = "KutuphaneDataSet3";
            this.kutuphaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemlerBindingSource
            // 
            this.islemlerBindingSource.DataMember = "İslemler";
            this.islemlerBindingSource.DataSource = this.kutuphaneDataSet3;
            // 
            // İslemlerTableAdapter
            // 
            this.İslemlerTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.islemlerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-2, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(619, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colVerilenTarih,
            this.colAlınanTarih,
            this.colOgrAdi,
            this.colOgrSoyad,
            this.colOkulNo,
            this.colKitapAdi,
            this.colBarkodNo,
            this.colDurum});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colVerilenTarih);
            this.gridBand1.Columns.Add(this.colId);
            this.gridBand1.Columns.Add(this.colAlınanTarih);
            this.gridBand1.Columns.Add(this.colOgrAdi);
            this.gridBand1.Columns.Add(this.colOgrSoyad);
            this.gridBand1.Columns.Add(this.colOkulNo);
            this.gridBand1.Columns.Add(this.colKitapAdi);
            this.gridBand1.Columns.Add(this.colBarkodNo);
            this.gridBand1.Columns.Add(this.colDurum);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 675;
            // 
            // colVerilenTarih
            // 
            this.colVerilenTarih.FieldName = "VerilenTarih";
            this.colVerilenTarih.Name = "colVerilenTarih";
            this.colVerilenTarih.Visible = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            // 
            // colAlınanTarih
            // 
            this.colAlınanTarih.FieldName = "AlınanTarih";
            this.colAlınanTarih.Name = "colAlınanTarih";
            this.colAlınanTarih.Visible = true;
            // 
            // colOgrAdi
            // 
            this.colOgrAdi.FieldName = "OgrAdi";
            this.colOgrAdi.Name = "colOgrAdi";
            this.colOgrAdi.Visible = true;
            // 
            // colOgrSoyad
            // 
            this.colOgrSoyad.FieldName = "OgrSoyad";
            this.colOgrSoyad.Name = "colOgrSoyad";
            this.colOgrSoyad.Visible = true;
            // 
            // colOkulNo
            // 
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.Visible = true;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.FieldName = "BarkodNo";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.Visible = true;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            // 
            // kitapsayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 312);
            this.Controls.Add(this.gridControl1);
            this.Name = "kitapsayi";
            this.Text = "kitapsayi";
            this.Load += new System.EventHandler(this.kitapsayi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KutuphaneDataSet3 kutuphaneDataSet3;
        private System.Windows.Forms.BindingSource islemlerBindingSource;
        private KutuphaneDataSet3TableAdapters.İslemlerTableAdapter İslemlerTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVerilenTarih;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAlınanTarih;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrSoyad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOkulNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKitapAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBarkodNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDurum;
    }
}