Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Web

Namespace E5030.Reports
	Partial Public Class ProductsByCategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private Const ExpandedCategories_SessionKey As String = "ProductsByCategoriesReport_ExpandedCategories"

		Private _expandedCategories As HashSet(Of Integer) = Nothing

		Private ReadOnly Property ExpandedCategories() As HashSet(Of Integer)
			Get
				If _expandedCategories Is Nothing Then
					_expandedCategories = CType(HttpContext.Current.Session(ExpandedCategories_SessionKey), HashSet(Of Integer))
					If _expandedCategories Is Nothing Then
						_expandedCategories = New HashSet(Of Integer)()
						HttpContext.Current.Session(ExpandedCategories_SessionKey) = _expandedCategories
					End If
				End If
				Return _expandedCategories
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub CategoryExpandClicked(ByVal categoryID As Integer)
			If ExpandedCategories.Contains(categoryID) Then
				ExpandedCategories.Remove(categoryID)
			Else
				ExpandedCategories.Add(categoryID)
			End If
		End Sub

		Private Sub lbExpand_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles lbExpand.HtmlItemCreated
			e.ContentCell.Attributes.Add("onclick", String.Format("parent.ProductsByCategoriesReport_ExpandClick('{0}')", e.Brick.Value))
			e.ContentCell.Style.Add("cursor", "pointer")
		End Sub

		Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
			Dim categoryID As Integer = GetCurrentColumnValue(Of Integer)("CategoryID")
			e.Cancel = Not ExpandedCategories.Contains(categoryID)
		End Sub

		Private Sub lbExpand_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbExpand.BeforePrint
			Dim label As XRLabel = TryCast(sender, XRLabel)
			Dim categoryID As Integer = GetCurrentColumnValue(Of Integer)("CategoryID")
			label.Text = If(ExpandedCategories.Contains(categoryID), "-", "+")
		End Sub

	End Class
End Namespace
