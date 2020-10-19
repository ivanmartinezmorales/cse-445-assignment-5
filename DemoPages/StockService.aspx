<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockService.aspx.cs" Inherits="DemoPages.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Stock Service Demo</h1>
    <p>
        To use the stock service, add in your favorite stock ticker and hit submit</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            Stock Ticker:
            <asp:TextBox ID="StockName" runat="server"></asp:TextBox>
        </p>
        <div>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
            <br />
            <br />
            Stock data appears below:</div>
        <asp:TextBox ID="StockResponse" runat="server" Height="39px" Width="508px"></asp:TextBox>
    </form>
</body>
</html>
