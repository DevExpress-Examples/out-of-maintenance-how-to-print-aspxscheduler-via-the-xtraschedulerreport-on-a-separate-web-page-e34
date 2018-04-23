Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraScheduler

Partial Public Class [Default]
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DataHelper.SetupMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

		If (Not IsPostBack) Then
			ASPxScheduler1.Start = DateTime.Today
		End If
	End Sub

	Protected Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("ReportingPage.aspx")
	End Sub
End Class
