Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports E5030.Reports

Namespace E5030.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		<HttpGet> _
		Public Function ReportCallbackPanelPartial() As ActionResult
			Dim report As New ProductsByCategoriesReport()
			Return PartialView("_ReportCallbackPanelPartial", report)
		End Function

		<HttpPost> _
		Public Function ReportCallbackPanelPartial(ByVal categoryID As Integer) As ActionResult
			Dim report As New ProductsByCategoriesReport()
			report.CategoryExpandClicked(categoryID)
			Return PartialView("_ReportCallbackPanelPartial", report)
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			Dim report As New ProductsByCategoriesReport()
			Return PartialView("_DocumentViewerPartial", report)
		End Function

		Public Function DocumentViewerExport() As ActionResult
			Dim report As New ProductsByCategoriesReport()
			Return ReportViewerExtension.ExportTo(report)
		End Function
	End Class
End Namespace