using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Web;

namespace E5030.Reports {
    public partial class ProductsByCategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        const string ExpandedCategories_SessionKey = "ProductsByCategoriesReport_ExpandedCategories";

        HashSet<int> _expandedCategories = null;

        HashSet<int> ExpandedCategories {
            get {
                if (_expandedCategories == null) {
                    _expandedCategories = (HashSet<int>) HttpContext.Current.Session[ExpandedCategories_SessionKey];
                    if (_expandedCategories == null) {
                        _expandedCategories = new HashSet<int>();
                        HttpContext.Current.Session[ExpandedCategories_SessionKey] = _expandedCategories;
                    }
                }
                return _expandedCategories;
            }
        }

        public ProductsByCategoriesReport() {
            InitializeComponent();
        }

        public void CategoryExpandClicked(int categoryID) {
            if (ExpandedCategories.Contains(categoryID)) {
                ExpandedCategories.Remove(categoryID);
            }
            else {
                ExpandedCategories.Add(categoryID);
            }
        }

        private void lbExpand_HtmlItemCreated(object sender, HtmlEventArgs e) {
            e.ContentCell.Attributes.Add("onclick", String.Format("parent.ProductsByCategoriesReport_ExpandClick('{0}')", e.Brick.Value));
            e.ContentCell.Style.Add("cursor", "pointer");
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            int categoryID = GetCurrentColumnValue<int>("CategoryID");
            e.Cancel = !ExpandedCategories.Contains(categoryID);
        }

        private void lbExpand_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRLabel label = sender as XRLabel;
            int categoryID = GetCurrentColumnValue<int>("CategoryID");
            label.Text = ExpandedCategories.Contains(categoryID) ? "-" : "+";
        }

    }
}
