namespace E5030.Reports {
    partial class ProductsByCategoriesReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DetailCategories = new DevExpress.XtraReports.UI.DetailBand();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nWindDataSet1 = new E5030.Models.NWindDataSet();
            this.productsTableAdapter = new E5030.Models.NWindDataSetTableAdapters.ProductsTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailProducts = new DevExpress.XtraReports.UI.DetailBand();
            this.categoriesTableAdapter1 = new E5030.Models.NWindDataSetTableAdapters.CategoriesTableAdapter();
            this.lbExpand = new DevExpress.XtraReports.UI.XRLabel();
            this.lbProductName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbUnitPrice = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DetailCategories
            // 
            this.DetailCategories.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbExpand,
            this.lbDescription,
            this.lbCategoryName,
            this.pbPicture});
            this.DetailCategories.Name = "DetailCategories";
            this.DetailCategories.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailCategories.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description")});
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(30F, 40.00003F);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(455.4201F, 49.99998F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName")});
            this.lbCategoryName.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(30F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(455.42F, 30F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.StylePriority.UseTextAlignment = false;
            this.lbCategoryName.Text = "lbCategoryName";
            this.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // pbPicture
            // 
            this.pbPicture.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(490F, 10.00001F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(150F, 80F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailProducts});
            this.DetailReport.DataAdapter = this.productsTableAdapter;
            this.DetailReport.DataMember = "Categories.CategoriesProducts";
            this.DetailReport.DataSource = this.nWindDataSet1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            this.DetailReport.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DetailReport_BeforePrint);
            // 
            // DetailProducts
            // 
            this.DetailProducts.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbUnitPrice,
            this.lbProductName});
            this.DetailProducts.HeightF = 25.00001F;
            this.DetailProducts.Name = "DetailProducts";
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // lbExpand
            // 
            this.lbExpand.BackColor = System.Drawing.Color.LightGreen;
            this.lbExpand.BorderColor = System.Drawing.Color.Empty;
            this.lbExpand.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Categories.CategoryID")});
            this.lbExpand.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.lbExpand.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.lbExpand.Name = "lbExpand";
            this.lbExpand.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbExpand.SizeF = new System.Drawing.SizeF(30F, 30F);
            this.lbExpand.StylePriority.UseBackColor = false;
            this.lbExpand.StylePriority.UseBorderColor = false;
            this.lbExpand.StylePriority.UseFont = false;
            this.lbExpand.StylePriority.UseTextAlignment = false;
            this.lbExpand.Text = "+";
            this.lbExpand.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lbExpand.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lbExpand_BeforePrint);
            this.lbExpand.HtmlItemCreated += new DevExpress.XtraReports.UI.HtmlEventHandler(this.lbExpand_HtmlItemCreated);
            // 
            // lbProductName
            // 
            this.lbProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.ProductName")});
            this.lbProductName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbProductName.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbProductName.SizeF = new System.Drawing.SizeF(451.0417F, 25F);
            this.lbProductName.StylePriority.UseFont = false;
            this.lbProductName.StylePriority.UseTextAlignment = false;
            this.lbProductName.Text = "lbProductName";
            this.lbProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoriesProducts.UnitPrice", "{0:c}")});
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbUnitPrice.LocationFloat = new DevExpress.Utils.PointFloat(551.0417F, 0F);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbUnitPrice.SizeF = new System.Drawing.SizeF(88.95831F, 25F);
            this.lbUnitPrice.StylePriority.UseFont = false;
            this.lbUnitPrice.StylePriority.UseTextAlignment = false;
            this.lbUnitPrice.Text = "lbUnitPrice";
            this.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ProductsByCategoriesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.DetailCategories,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.DataAdapter = this.categoriesTableAdapter1;
            this.DataMember = "Categories";
            this.DataSource = this.nWindDataSet1;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand DetailCategories;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private Models.NWindDataSet nWindDataSet1;
        private Models.NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand DetailProducts;
        private Models.NWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private DevExpress.XtraReports.UI.XRLabel lbExpand;
        private DevExpress.XtraReports.UI.XRLabel lbUnitPrice;
        private DevExpress.XtraReports.UI.XRLabel lbProductName;
    }
}
