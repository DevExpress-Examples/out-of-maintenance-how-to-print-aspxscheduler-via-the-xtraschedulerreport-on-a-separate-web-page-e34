using System;
using System.Web.UI;
using DevExpress.XtraScheduler;

public partial class Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        DataHelper.SetupMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);
        
        if (!IsPostBack)
            ASPxScheduler1.Start = DateTime.Today;
    }

    protected void btnPreview_Click(object sender, EventArgs e) {
        Response.Redirect("ReportingPage.aspx");
    }
}
