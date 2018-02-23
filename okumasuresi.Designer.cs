namespace kutuphane2
{
    partial class okumasuresi
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
            this.kutuphaneDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet5 = new kutuphane2.KutuphaneDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.okumaSayisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okumaSayisiTableAdapter = new kutuphane2.KutuphaneDataSet5TableAdapters.OkumaSayisiTableAdapter();
            this.colOgrAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSınıf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okumaSayisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.okumaSayisiBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(479, 319);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // kutuphaneDataSet5BindingSource
            // 
            this.kutuphaneDataSet5BindingSource.DataSource = this.kutuphaneDataSet5;
            this.kutuphaneDataSet5BindingSource.Position = 0;
            // 
            // kutuphaneDataSet5
            // 
            this.kutuphaneDataSet5.DataSetName = "KutuphaneDataSet5";
            this.kutuphaneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrAd,
            this.colOgrSoyad,
            this.colKitapSayisi,
            this.colSınıf,
            this.colSube,
            this.colOkulNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "aramak istediginiz kelimeyi,sayiyi giriniz...";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // okumaSayisiBindingSource
            // 
            this.okumaSayisiBindingSource.DataMember = "OkumaSayisi";
            this.okumaSayisiBindingSource.DataSource = this.kutuphaneDataSet5BindingSource;
            // 
            // okumaSayisiTableAdapter
            // 
            this.okumaSayisiTableAdapter.ClearBeforeFill = true;
            // 
            // colOgrAd
            // 
            this.colOgrAd.Caption = "Öğrenci Adı";
            this.colOgrAd.FieldName = "OgrAd";
            this.colOgrAd.Name = "colOgrAd";
            this.colOgrAd.Visible = true;
            this.colOgrAd.VisibleIndex = 0;
            // 
            // colOgrSoyad
            // 
            this.colOgrSoyad.Caption = "Öğrenci Soyadı";
            this.colOgrSoyad.FieldName = "OgrSoyad";
            this.colOgrSoyad.Name = "colOgrSoyad";
            this.colOgrSoyad.Visible = true;
            this.colOgrSoyad.VisibleIndex = 1;
            // 
            // colKitapSayisi
            // 
            this.colKitapSayisi.FieldName = "KitapSayisi";
            this.colKitapSayisi.Name = "colKitapSayisi";
            this.colKitapSayisi.Visible = true;
            this.colKitapSayisi.VisibleIndex = 2;
            // 
            // colSınıf
            // 
            this.colSınıf.FieldName = "Sınıf";
            this.colSınıf.Name = "colSınıf";
            this.colSınıf.Visible = true;
            this.colSınıf.VisibleIndex = 3;
            // 
            // colSube
            // 
            this.colSube.FieldName = "Sube";
            this.colSube.Name = "colSube";
            this.colSube.Visible = true;
            this.colSube.VisibleIndex = 4;
            // 
            // colOkulNo
            // 
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 5;
            // 
            // okumasuresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 322);
            this.Controls.Add(this.gridControl1);
            this.Name = "okumasuresi";
            this.Text = "okumasuresi";
            this.Load += new System.EventHandler(this.okumasuresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okumaSayisiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kutuphaneDataSet5BindingSource;
        private KutuphaneDataSet5 kutuphaneDataSet5;
        private System.Windows.Forms.BindingSource okumaSayisiBindingSource;
        private KutuphaneDataSet5TableAdapters.OkumaSayisiTableAdapter okumaSayisiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrAd;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSınıf;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
    }
}