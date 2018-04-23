Imports Microsoft.VisualBasic
Imports System
Namespace E5030.Reports
	Partial Public Class ProductsByCategoriesReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.DetailCategories = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
			Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nWindDataSet1 = New NWindDataSet()
            Me.productsTableAdapter = New NWindDataSetTableAdapters.ProductsTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.DetailProducts = New DevExpress.XtraReports.UI.DetailBand()
            Me.categoriesTableAdapter1 = New NWindDataSetTableAdapters.CategoriesTableAdapter()
			Me.lbExpand = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbProductName = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' DetailCategories
			' 
			Me.DetailCategories.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbExpand, Me.lbDescription, Me.lbCategoryName, Me.pbPicture})
			Me.DetailCategories.Name = "DetailCategories"
			Me.DetailCategories.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.DetailCategories.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(30F, 40.00003F)
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(455.4201F, 49.99998F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 20F)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(30F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(455.42F, 30F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.StylePriority.UseTextAlignment = False
			Me.lbCategoryName.Text = "lbCategoryName"
			Me.lbCategoryName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(490F, 10.00001F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(150F, 80F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nWindDataSet1
			' 
			Me.nWindDataSet1.DataSetName = "NWindDataSet"
			Me.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.DetailProducts})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.nWindDataSet1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
'			Me.DetailReport.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.DetailReport_BeforePrint);
			' 
			' DetailProducts
			' 
			Me.DetailProducts.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbUnitPrice, Me.lbProductName})
			Me.DetailProducts.HeightF = 25.00001F
			Me.DetailProducts.Name = "DetailProducts"
			' 
			' categoriesTableAdapter1
			' 
			Me.categoriesTableAdapter1.ClearBeforeFill = True
			' 
			' lbExpand
			' 
			Me.lbExpand.BackColor = System.Drawing.Color.LightGreen
			Me.lbExpand.BorderColor = System.Drawing.Color.Empty
			Me.lbExpand.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.CategoryID")})
			Me.lbExpand.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold)
			Me.lbExpand.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.lbExpand.Name = "lbExpand"
			Me.lbExpand.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbExpand.SizeF = New System.Drawing.SizeF(30F, 30F)
			Me.lbExpand.StylePriority.UseBackColor = False
			Me.lbExpand.StylePriority.UseBorderColor = False
			Me.lbExpand.StylePriority.UseFont = False
			Me.lbExpand.StylePriority.UseTextAlignment = False
			Me.lbExpand.Text = "+"
			Me.lbExpand.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.lbExpand.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.lbExpand_BeforePrint);
'			Me.lbExpand.HtmlItemCreated += New DevExpress.XtraReports.UI.HtmlEventHandler(Me.lbExpand_HtmlItemCreated);
			' 
			' lbProductName
			' 
			Me.lbProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.lbProductName.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.lbProductName.LocationFloat = New DevExpress.Utils.PointFloat(100F, 0F)
			Me.lbProductName.Name = "lbProductName"
			Me.lbProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbProductName.SizeF = New System.Drawing.SizeF(451.0417F, 25F)
			Me.lbProductName.StylePriority.UseFont = False
			Me.lbProductName.StylePriority.UseTextAlignment = False
			Me.lbProductName.Text = "lbProductName"
			Me.lbProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' lbUnitPrice
			' 
			Me.lbUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:c}")})
			Me.lbUnitPrice.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(551.0417F, 0F)
			Me.lbUnitPrice.Name = "lbUnitPrice"
			Me.lbUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbUnitPrice.SizeF = New System.Drawing.SizeF(88.95831F, 25F)
			Me.lbUnitPrice.StylePriority.UseFont = False
			Me.lbUnitPrice.StylePriority.UseTextAlignment = False
			Me.lbUnitPrice.Text = "lbUnitPrice"
			Me.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' ProductsByCategoriesReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.DetailCategories, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.DataAdapter = Me.categoriesTableAdapter1
			Me.DataMember = "Categories"
			Me.DataSource = Me.nWindDataSet1
			Me.Version = "13.2"
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private DetailCategories As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private nWindDataSet1 As NWindDataSet
        Private productsTableAdapter As NWindDataSetTableAdapters.ProductsTableAdapter
		Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private DetailProducts As DevExpress.XtraReports.UI.DetailBand
        Private categoriesTableAdapter1 As NWindDataSetTableAdapters.CategoriesTableAdapter
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private WithEvents lbExpand As DevExpress.XtraReports.UI.XRLabel
		Private lbUnitPrice As DevExpress.XtraReports.UI.XRLabel
		Private lbProductName As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
