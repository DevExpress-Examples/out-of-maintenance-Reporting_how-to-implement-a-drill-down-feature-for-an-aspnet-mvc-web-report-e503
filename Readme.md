<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E5030/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5030/Controllers/HomeController.vb))
* [ProductsByCategoriesReport.cs](./CS/E5030/Reports/ProductsByCategoriesReport.cs) (VB: [ProductsByCategoriesReport.vb](./VB/E5030/Reports/ProductsByCategoriesReport.vb))
* [_DocumentViewerPartial.cshtml](./CS/E5030/Views/Home/_DocumentViewerPartial.cshtml)
* [_ReportCallbackPanelPartial.cshtml](./CS/E5030/Views/Home/_ReportCallbackPanelPartial.cshtml)
* **[Index.cshtml](./CS/E5030/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to implement a drill-down feature for an ASP.NET MVC web report


<p>This example demonstrates how you can implement a <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5316"><u>Drill-Down</u></a> feature for a report displayed in the ASP.NET MVC <a href="http://documentation.devexpress.com/#AspNet/CustomDocument10009"><u>DocumentViewer</u></a> extension.<br /><br /></p>
<p><strong>IMPORTANT NOTE:</strong><br />Starting with version <strong>15.1,</strong> our Reporting Suite provides the Drill-Down functionality out of the box. So, use the approach demonstrated in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114106">How to: Create a Drill-Down Report</a> help topic instead of using the approach demonstrated in this code example.<br /><br /></p>
<br />
<p>The main idea of this approach is to store the expanded state of report categories. As this is a web application, a Session is used to store it. Then depending on the category's expanded state its product list is shown or hidden. The <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_BeforePrinttopic"><u>DetailReportBand.BeforePrint</u></a> event handler is used for this purpose.</p>
<br />
<p>To make the expand/collapse button working in a web report its <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_HtmlItemCreatedtopic"><u>HtmlItemCreated</u></a> event handler is used to add required HTML attributes to it. When the expand button is clicked a client-side function is executed and a callback is sent to the CallbackPanel. In the controller, the expanded state of report categories is updated, and the report is updated.</p>

<br/>


