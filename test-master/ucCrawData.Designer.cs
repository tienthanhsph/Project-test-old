namespace SH.Crawler
{
    partial class ucCrawData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboWebpage = new System.Windows.Forms.ComboBox();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SiteCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiteItemGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemSiteCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemSiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SitePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrlCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cboWebpage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn website:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(821, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(689, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Bắt đầu";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cboWebpage
            // 
            this.cboWebpage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWebpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWebpage.FormattingEnabled = true;
            this.cboWebpage.Location = new System.Drawing.Point(85, 18);
            this.cboWebpage.Name = "cboWebpage";
            this.cboWebpage.Size = new System.Drawing.Size(598, 21);
            this.cboWebpage.TabIndex = 5;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(0, 54);
            this.gridData.MainView = this.gridView1;
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(934, 409);
            this.gridData.TabIndex = 2;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SiteCode,
            this.SiteItemGroup,
            this.ItemBrand,
            this.ItemSiteCode,
            this.ItemSiteName,
            this.SitePrice,
            this.UrlCheck});
            this.gridView1.GridControl = this.gridData;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // SiteCode
            // 
            this.SiteCode.Caption = "Mã Trang";
            this.SiteCode.FieldName = "SiteCode";
            this.SiteCode.Name = "SiteCode";
            this.SiteCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SiteCode.Visible = true;
            this.SiteCode.VisibleIndex = 0;
            // 
            // SiteItemGroup
            // 
            this.SiteItemGroup.Caption = "Nhóm hàng";
            this.SiteItemGroup.FieldName = "SiteItemGroup";
            this.SiteItemGroup.Name = "SiteItemGroup";
            this.SiteItemGroup.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.SiteItemGroup.Visible = true;
            this.SiteItemGroup.VisibleIndex = 2;
            // 
            // ItemBrand
            // 
            this.ItemBrand.Caption = "Thương hiệu";
            this.ItemBrand.FieldName = "ItemBrand";
            this.ItemBrand.Name = "ItemBrand";
            this.ItemBrand.Visible = true;
            this.ItemBrand.VisibleIndex = 1;
            // 
            // ItemSiteCode
            // 
            this.ItemSiteCode.Caption = "Mã hàng";
            this.ItemSiteCode.FieldName = "ItemSiteCode";
            this.ItemSiteCode.Name = "ItemSiteCode";
            this.ItemSiteCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ItemSiteCode.Visible = true;
            this.ItemSiteCode.VisibleIndex = 3;
            // 
            // ItemSiteName
            // 
            this.ItemSiteName.Caption = "Tên hàng";
            this.ItemSiteName.FieldName = "ItemSiteName";
            this.ItemSiteName.Name = "ItemSiteName";
            this.ItemSiteName.Visible = true;
            this.ItemSiteName.VisibleIndex = 4;
            // 
            // SitePrice
            // 
            this.SitePrice.Caption = "Giá";
            this.SitePrice.DisplayFormat.FormatString = "{0:0,0}";
            this.SitePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SitePrice.FieldName = "SitePrice";
            this.SitePrice.Name = "SitePrice";
            this.SitePrice.Visible = true;
            this.SitePrice.VisibleIndex = 5;
            // 
            // UrlCheck
            // 
            this.UrlCheck.Caption = "UrlCheck";
            this.UrlCheck.FieldName = "UrlCheck";
            this.UrlCheck.Name = "UrlCheck";
            this.UrlCheck.Visible = true;
            this.UrlCheck.VisibleIndex = 6;
            // 
            // ucCrawData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.panel1);
            this.Name = "ucCrawData";
            this.Size = new System.Drawing.Size(934, 463);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboWebpage;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn SiteCode;
        private DevExpress.XtraGrid.Columns.GridColumn SiteItemGroup;
        private DevExpress.XtraGrid.Columns.GridColumn ItemBrand;
        private DevExpress.XtraGrid.Columns.GridColumn ItemSiteCode;
        private DevExpress.XtraGrid.Columns.GridColumn ItemSiteName;
        private DevExpress.XtraGrid.Columns.GridColumn SitePrice;
        private DevExpress.XtraGrid.Columns.GridColumn UrlCheck;

    }
}
