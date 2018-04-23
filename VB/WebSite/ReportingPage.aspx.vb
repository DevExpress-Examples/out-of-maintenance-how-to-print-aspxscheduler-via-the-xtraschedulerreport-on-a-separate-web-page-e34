Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class ReportingPage
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		PrepareReportPreview()
	End Sub

	Private Sub PrepareReportPreview()
		ASPxSchedulerControlPrintAdapter1.TimeInterval = New TimeInterval(DateTime.Today, DateTime.Today.AddDays(7))
		ASPxSchedulerControlPrintAdapter1.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18))

		DataHelper.SetupMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

		ASPxSchedulerControlPrintAdapter1.SchedulerControl = ASPxScheduler1
	End Sub
End Class
