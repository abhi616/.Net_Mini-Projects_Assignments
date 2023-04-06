<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Click.aspx.cs" Inherits="AspWebApi.frm_Click" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tb_Count" runat="server" Width="137px">0</asp:TextBox>
        <asp:Button ID="btn_Click" runat="server" onclick="btn_Click_Click" 
            Text="Click Me" />
    
    </div>
    </form>
</body>
</html>
