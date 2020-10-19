<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrimeServiceDemo.aspx.cs" Inherits="DemoPages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <h1><strong>Crime Data Service Demo Page</strong></h1>
        <br />
        Enter a latitude and longitude<br />
        <br />
        latitude
        <asp:TextBox ID="Latitude" runat="server"></asp:TextBox>
        <br />
        <br />
        longitude
        <asp:TextBox ID="Longitude" runat="server"></asp:TextBox>
        <br />
        <br />
        hit submit to get crime data<br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="submit" />
        <br />
        <br />
        <br />
        <br />
        Number of crimes for this area:
        <asp:Label ID="Response" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
