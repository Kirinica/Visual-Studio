<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <h1><strong>Asset Performance Tracker</strong></h1>
        <p>
            &nbsp;</p>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <br />
    </form>
</body>
</html>
