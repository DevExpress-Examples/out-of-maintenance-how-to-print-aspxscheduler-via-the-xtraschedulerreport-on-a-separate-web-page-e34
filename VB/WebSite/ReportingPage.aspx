<%@ Page Language="vb" AutoEventWireup="true" CodeFile="ReportingPage.aspx.vb" Inherits="ReportingPage" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2, Version=15.2.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxScheduler.Reporting" TagPrefix="dxwschsc" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2, Version=15.2.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.XtraScheduler.v15.2.Core, Version=15.2.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraScheduler" TagPrefix="dx" %>
<%@ Register Src="~/DefaultObjectDataSources.ascx" TagName="DefaultObjectDataSources"
	TagPrefix="dds" %>
<%@ Register src="ReportPreview.ascx" tagname="ReportPreview" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
	<form id="form1" runat="server">
	<div>
		<dds:DefaultObjectDataSources ID="DataSource1" runat="server" />
		<dxwschsc:ASPxSchedulerControlPrintAdapter ID="ASPxSchedulerControlPrintAdapter1" runat="server" />
		<dxwschs:ASPxScheduler ID="ASPxScheduler1" runat="server"  Visible="false" />
		<uc1:ReportPreview ID="ReportPreview1" runat="server" ControlAdapter="<%#ASPxSchedulerControlPrintAdapter1%>" />
	</div>
	</form>
</body>
</html>
