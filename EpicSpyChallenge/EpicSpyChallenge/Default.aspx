<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpyChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <h1>Spy New Assignment Form</h1>
            <br />
            <br />
            Spy Code Name:&nbsp; <asp:TextBox ID="spycodenameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:&nbsp;
            <asp:TextBox ID="newassignmentnameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="previousassignmentCalendar" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment:<asp:Calendar ID="newassignmentCalendar" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="enddatenewassignmentCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="assignspyButton" runat="server" OnClick="assignspyButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
