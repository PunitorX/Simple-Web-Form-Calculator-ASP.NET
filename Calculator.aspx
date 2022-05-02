<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplicationAssignment.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #FFFFFF; font-size: medium; color: #000000">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="position: relative">
    <form id="form1" runat="server">
        <div style="text-align: left; font-weight: 700">
            <h1 style="text-align: center">Calculator</h1>
        </div>
        <p style="text-align: center">
&nbsp;First Number:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstNum" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
&nbsp;&nbsp;&nbsp;&nbsp; Second Number:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="secondNum" runat="server"></asp:TextBox>
        </p>
        <div class="auto-style1">
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
            <asp:Button ID="subButton" runat="server" Text="Subtract" OnClick="subButton_Click" />
            <asp:Button ID="multiButton" runat="server" Text="Multiply" OnClick="multiButton_Click" />
            <asp:Button ID="divButtin" runat="server" Text="Divide" OnClick="divButtin_Click" />
            <asp:Button ID="modButtun" runat="server" Text="Modulus" OnClick="modButtun_Click" />
        </div>
        <p style="text-align: center">
            <asp:TextBox ID="resultNum" runat="server"></asp:TextBox>
        &nbsp;
            <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
        </p>
    </form>
</body>
</html>
