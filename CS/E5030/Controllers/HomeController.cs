using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using E5030.Reports;

namespace E5030.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult ReportCallbackPanelPartial() {
            ProductsByCategoriesReport report = new ProductsByCategoriesReport();
            return PartialView("_ReportCallbackPanelPartial", report);
        }

        [HttpPost]
        public ActionResult ReportCallbackPanelPartial(int categoryID) {
            ProductsByCategoriesReport report = new ProductsByCategoriesReport();
            report.CategoryExpandClicked(categoryID);
            return PartialView("_ReportCallbackPanelPartial", report);
        }

        public ActionResult DocumentViewerPartial() {
            ProductsByCategoriesReport report = new ProductsByCategoriesReport();
            return PartialView("_DocumentViewerPartial", report);
        }

        public ActionResult DocumentViewerExport() {
            ProductsByCategoriesReport report = new ProductsByCategoriesReport();
            return ReportViewerExtension.ExportTo(report);
        }        
    }
}