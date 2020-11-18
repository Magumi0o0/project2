<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookise1.aspx.cs" Inherits="project2.page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="ISBN"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Set Cookie" />
        </p>
    </form>
</body>
</html>
