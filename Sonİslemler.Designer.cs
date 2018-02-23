namespace kutuphane2
{
    partial class Sonİslemler
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.islemlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet3 = new kutuphane2.KutuphaneDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilenTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlınanTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İslemlerTableAdapter = new kutuphane2.KutuphaneDataSet3TableAdapters.İslemlerTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridControl1.DataSource = this.islemlerBindingSource;
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Blue;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(684, 386);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // islemlerBindingSource
            // 
            this.islemlerBindingSource.DataMember = "İslemler";
            this.islemlerBindingSource.DataSource = this.kutuphaneDataSet3;
            // 
            // kutuphaneDataSet3
            // 
            this.kutuphaneDataSet3.DataSetName = "KutuphaneDataSet3";
            this.kutuphaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.AppearancePrint.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.AppearancePrint.EvenRow.ForeColor = System.Drawing.Color.Lime;
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colVerilenTarih,
            this.colAlınanTarih,
            this.colOgrAdi,
            this.colOgrSoyad,
            this.colOkulNo,
            this.colKitapAdi,
            this.colBarkodNo,
            this.colDurum});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(104, 291, 210, 172);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Aramak İstediğiniz Kelimeyi,Sayıyı Giriniz";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colVerilenTarih
            // 
            this.colVerilenTarih.FieldName = "VerilenTarih";
            this.colVerilenTarih.Name = "colVerilenTarih";
            this.colVerilenTarih.Visible = true;
            this.colVerilenTarih.VisibleIndex = 0;
            // 
            // colAlınanTarih
            // 
            this.colAlınanTarih.FieldName = "AlınanTarih";
            this.colAlınanTarih.Name = "colAlınanTarih";
            this.colAlınanTarih.Visible = true;
            this.colAlınanTarih.VisibleIndex = 1;
            // 
            // colOgrAdi
            // 
            this.colOgrAdi.Caption = "Öğrenci Adı";
            this.colOgrAdi.FieldName = "OgrAdi";
            this.colOgrAdi.Name = "colOgrAdi";
            this.colOgrAdi.Visible = true;
            this.colOgrAdi.VisibleIndex = 2;
            // 
            // colOgrSoyad
            // 
            this.colOgrSoyad.Caption = "Öğrenci Soyad";
            this.colOgrSoyad.FieldName = "OgrSoyad";
            this.colOgrSoyad.Name = "colOgrSoyad";
            this.colOgrSoyad.Visible = true;
            this.colOgrSoyad.VisibleIndex = 3;
            // 
            // colOkulNo
            // 
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 4;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 5;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.FieldName = "BarkodNo";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.Visible = true;
            this.colBarkodNo.VisibleIndex = 6;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 7;
            // 
            // İslemlerTableAdapter
            // 
            this.İslemlerTableAdapter.ClearBeforeFill = true;
            // 
            // Sonİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 387);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sonİslemler";
            this.Text = "Sonİslemler";
            this.Load += new System.EventHandler(this.Sonİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private KutuphaneDataSet3 kutuphaneDataSet3;
        private System.Windows.Forms.BindingSource islemlerBindingSource;
        private KutuphaneDataSet3TableAdapters.İslemlerTableAdapter İslemlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilenTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAlınanTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}