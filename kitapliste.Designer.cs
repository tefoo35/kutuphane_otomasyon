namespace kutuphane2
{
    partial class kitapliste
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
            this.kitapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet2 = new kutuphane2.KutuphaneDataSet2();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet1 = new kutuphane2.KutuphaneDataSet1();
            this.kutuphaneDataSet = new kutuphane2.KutuphaneDataSet();
            this.kutuphaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTableAdapter = new kutuphane2.KutuphaneDataSet1TableAdapters.KitapTableAdapter();
            this.kitapTableAdapter1 = new kutuphane2.KutuphaneDataSet2TableAdapters.KitapTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapSayfa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapBasımTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapYayınevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapBindingSource1
            // 
            this.kitapBindingSource1.DataMember = "Kitap";
            this.kitapBindingSource1.DataSource = this.kutuphaneDataSet2;
            // 
            // kutuphaneDataSet2
            // 
            this.kutuphaneDataSet2.DataSetName = "KutuphaneDataSet2";
            this.kutuphaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneDataSet1;
            // 
            // kutuphaneDataSet1
            // 
            this.kutuphaneDataSet1.DataSetName = "KutuphaneDataSet1";
            this.kutuphaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "KutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneDataSetBindingSource
            // 
            this.kutuphaneDataSetBindingSource.DataSource = this.kutuphaneDataSet;
            this.kutuphaneDataSetBindingSource.Position = 0;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // kitapTableAdapter1
            // 
            this.kitapTableAdapter1.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.CausesValidation = false;
            this.gridControl1.DataSource = this.kitapBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 339);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKitapAdi,
            this.colYazar,
            this.colKitapSayfa,
            this.colKitapBasımTarih,
            this.colKitapYayınevi,
            this.colBarkodNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 500;
            this.gridView1.OptionsFind.FindNullPrompt = "aramak istediginiz kelimeyi,sayiyi giriniz";
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 0;
            // 
            // colYazar
            // 
            this.colYazar.FieldName = "Yazar";
            this.colYazar.Name = "colYazar";
            this.colYazar.Visible = true;
            this.colYazar.VisibleIndex = 1;
            // 
            // colKitapSayfa
            // 
            this.colKitapSayfa.FieldName = "KitapSayfa";
            this.colKitapSayfa.Name = "colKitapSayfa";
            this.colKitapSayfa.Visible = true;
            this.colKitapSayfa.VisibleIndex = 2;
            // 
            // colKitapBasımTarih
            // 
            this.colKitapBasımTarih.FieldName = "KitapBasımTarih";
            this.colKitapBasımTarih.Name = "colKitapBasımTarih";
            this.colKitapBasımTarih.Visible = true;
            this.colKitapBasımTarih.VisibleIndex = 3;
            // 
            // colKitapYayınevi
            // 
            this.colKitapYayınevi.FieldName = "KitapYayınevi";
            this.colKitapYayınevi.Name = "colKitapYayınevi";
            this.colKitapYayınevi.Visible = true;
            this.colKitapYayınevi.VisibleIndex = 4;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.FieldName = "BarkodNo";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.Visible = true;
            this.colBarkodNo.VisibleIndex = 5;
            // 
            // kitapliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(654, 339);
            this.Controls.Add(this.gridControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kitapliste";
            this.Text = "kitapliste";
            this.Load += new System.EventHandler(this.kitapliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kutuphaneDataSetBindingSource;
        private KutuphaneDataSet kutuphaneDataSet;
        private KutuphaneDataSet1 kutuphaneDataSet1;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneDataSet1TableAdapters.KitapTableAdapter kitapTableAdapter;
        private KutuphaneDataSet2 kutuphaneDataSet2;
        private System.Windows.Forms.BindingSource kitapBindingSource1;
        private KutuphaneDataSet2TableAdapters.KitapTableAdapter kitapTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYazar;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapSayfa;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapBasımTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapYayınevi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodNo;
    }
}