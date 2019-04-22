<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlLiteTest.aspx.cs" Inherits="WebApplication2.SqlLiteTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>测试</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Start" runat="server" Text="Start" OnClick="Start_Click" />
            <asp:Label ID="LbNote" runat="server" Text="流程"></asp:Label>
            <asp:GridView ID="GdView1" runat="server"></asp:GridView>
        </div>
        <asp:Label ID="LbResult" runat="server" Text="结果："></asp:Label>
    </form>
</body>
</html>
