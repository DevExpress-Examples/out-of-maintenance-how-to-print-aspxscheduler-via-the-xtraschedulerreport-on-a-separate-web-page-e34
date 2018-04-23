using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

public partial class ReportingPage : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        PrepareReportPreview();
    }

    private void PrepareReportPreview() {
        ASPxSchedulerControlPrintAdapter1.TimeInterval = new TimeInterval(DateTime.Today, DateTime.Today.AddDays(7));
        ASPxSchedulerControlPrintAdapter1.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18));

        DataHelper.SetupMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);

        ASPxSchedulerControlPrintAdapter1.SchedulerControl = ASPxScheduler1;
    }
}
