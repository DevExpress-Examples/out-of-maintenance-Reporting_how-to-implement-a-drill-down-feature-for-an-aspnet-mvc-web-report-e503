@ModelType XtraReport
@Html.DevExpress().CallbackPanel(Sub(settings)
                                     settings.Name = "ReportCallbackPanel"
                                     settings.CallbackRouteValues = New With {
                                         .Controller = "Home",
                                         .Action = "ReportCallbackPanelPartial"
                                     }
                                     settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                          
                                     settings.SetContent(Sub()
                                                             Html.RenderPartial("_DocumentViewerPartial", Model)
                                                         End Sub)
                                 End Sub).GetHtml()
