@Code
    ViewBag.Title = "Home Page"
End Code
<script type="text/javascript">
    function ProductsByCategoriesReport_ExpandClick(categoryID) {
        ReportCallbackPanel.PerformCallback({ CategoryID: categoryID });
    }
</script>
@Html.Action("ReportCallbackPanelPartial")
