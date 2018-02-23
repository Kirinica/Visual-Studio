<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_Postage_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="lenghtTextBox" runat="server" AutoPostBack="True" OnTextChanged="lenghtTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="waygroup" Text="Ground" OnCheckedChanged="groundRadioButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="waygroup" Text="Air" OnCheckedChanged="airRadioButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="nextdayRadioButton" runat="server" AutoPostBack="True" GroupName="waygroup" Text="Next Day" OnCheckedChanged="nextdayRadioButton_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
