<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveDetail.aspx.cs" Inherits="WorkFlowPresentation.Presentation.ApproveDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Welcome to TekniPlex(Suzhou) WorkFLow Platform Management System</title>
		<meta http-equiv="content-type" content="text/html; charset=gb2312"/>
		<meta content="dynamic vanguard" name="author"/>
		<meta content="mshtml 6.00.3790.2541" name="generator"/>

	 </head>
    
    <frameset rows="15%,55%,30%" scrolling="No">

		<frame id="DoApprove" name="DoApprove" marginwidth="0" marginheight="0" src="DoApproval.aspx?SystemID=<%=this.SysID %>&DocumentID=<%=this.DocID %>&SequenceID=<%=this.SeqID%>&ApproveNeededID=<%=this.ApproveNeededID%>" SCROLLING="NO" frameborder="0"  longdesc="">
			</frame>
		<frame id = "RequestDetail" name="RequestDetail" marginwidth="0" marginheight="0" src="<%=this.QuerBUrl %>?SystemID=<%=this.SysID %>&DocumentID=<%=this.DocID %>&SequenceID=<%=this.SeqID%>&ApproveNeededID=<%=this.ApproveNeededID%>&LastStep=<%=this.LastStep%>"
			frameborder="0" scrolling="No" longdesc="">
			</frame>
		<frame id="Logs" name="Logs" marginwidth="0" marginheight="0" src="GeneratedLogs.aspx?SystemID=<%=this.SysID %>&DocumentID=<%=this.DocID %>&SequenceID=<%=this.SeqID%>&ApproveNeededID=<%=this.ApproveNeededID%>"
		frameborder="0" scrolling="yes" longdesc="">
		</frame>
		<noframes>
    </noframes>
	</frameset>


</html>
