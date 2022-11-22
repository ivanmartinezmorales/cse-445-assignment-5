<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFocus.aspx.cs" Inherits="DemoPages.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            News Focus Service</p>
        <p>
            Insert topics separated by comma</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubmitFormButton" runat="server" OnClick="SubmitFormButton_Click" Text="Submit" />
        <br />
        <br />
        <br />
        <asp:Label ID="Response" runat="server"></asp:Label>
    </form>
</body>
</html>
