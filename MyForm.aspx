﻿<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="MyForm.aspx.cs" Inherits="MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
    </div>

    </form>
</body>
</html>
