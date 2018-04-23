using System;
using DevExpress.Web.ASPxScheduler.Reporting;

public partial class ReportPreview : System.Web.UI.UserControl {
    ASPxSchedulerControlPrintAdapter controlAdapter;

    public ASPxSchedulerControlPrintAdapter ControlAdapter { 
        get { return controlAdapter; } 
        set { controlAdapter = value; } }

    protected void Page_Load(object sender, EventArgs e) {
        XtraSchedulerReport1 rpt = new XtraSchedulerReport1();
        this.DataBind();
        rpt.SchedulerAdapter = ControlAdapter.SchedulerAdapter;
        ReportViewer1.Report = rpt;
    }
}
