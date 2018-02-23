namespace kutuphane2
{
    partial class OgrListe
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new kutuphane2.KutuphaneDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ogrenciTableAdapter = new kutuphane2.KutuphaneDataSetTableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.ogrenciBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(300, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.kutuphaneDataSet;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "KutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAd,
            this.colSoyad,
            this.colOkulNo,
            this.colTel,
            this.colSinif,
            this.colSube});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 500;
            this.gridView1.OptionsFind.FindNullPrompt = "Aramak İstediğiniz Kelimeyi,Sayıyı Giriniz";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 0;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 1;
            // 
            // colOkulNo
            // 
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 2;
            // 
            // colTel
            // 
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 3;
            // 
            // colSinif
            // 
            this.colSinif.FieldName = "Sinif";
            this.colSinif.Name = "colSinif";
            this.colSinif.Visible = true;
            this.colSinif.VisibleIndex = 4;
            // 
            // colSube
            // 
            this.colSube.FieldName = "Sube";
            this.colSube.Name = "colSube";
            this.colSube.Visible = true;
            this.colSube.VisibleIndex = 5;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // OgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gridControl1);
            this.Name = "OgrListe";
            this.Text = "OgrListe";
            this.Load += new System.EventHandler(this.OgrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private KutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private KutuphaneDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colSinif;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
    }
}