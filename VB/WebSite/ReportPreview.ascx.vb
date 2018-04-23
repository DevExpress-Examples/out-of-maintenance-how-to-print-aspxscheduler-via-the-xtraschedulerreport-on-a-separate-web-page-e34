Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler.Reporting

Partial Public Class ReportPreview
	Inherits System.Web.UI.UserControl
	Private controlAdapter_Renamed As ASPxSchedulerControlPrintAdapter

	Public Property ControlAdapter() As ASPxSchedulerControlPrintAdapter
		Get
			Return controlAdapter_Renamed
		End Get
		Set(ByVal value As ASPxSchedulerControlPrintAdapter)
			controlAdapter_Renamed = value
		End Set
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim rpt As New XtraSchedulerReport1()
		Me.DataBind()
		rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter
		ReportViewer1.Report = rpt
	End Sub
End Class
