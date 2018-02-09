<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif">
            <h1>Simple Calculator</h1>
        </div>
        <p>
            <span class="auto-style1">First Value: </span>&nbsp;<asp:TextBox ID="firstvalueTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Second Value:&nbsp;
            <asp:TextBox ID="secondvalueTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="additionButton" runat="server" Height="50px" OnClick="additionButton_Click" Text="+" Width="50px" />
&nbsp;
        <asp:Button ID="subtractionButton" runat="server" Height="50px" OnClick="subtractionButton_Click" Text="-" Width="50px" />
&nbsp;
        <asp:Button ID="multiplicationButoon" runat="server" Height="50px" OnClick="multiplicationButoon_Click" Text="*" Width="50px" />
&nbsp;
        <asp:Button ID="divisionButton" runat="server" Height="50px" OnClick="divisionButton_Click" Text="/" Width="50px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="Lime"></asp:Label>
    </form>
</body>
</html>
