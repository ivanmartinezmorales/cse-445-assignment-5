<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherService.aspx.cs" Inherits="DemoPages.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>

    <form id="form1" runat="server">
        <h1>Weather Service Demo</h1>
        <p>
            This is the weather service demo</p>
        <p>
            Enter a zip code to start get the weather forecast. The numbers are temperatures, and the conditions are the strings
        </p>
        <p>
            &nbsp;</p>
        <p>
            Forecasts are separated by hour and go out to 4 days, using the open weather API</p>
        <p>
            &nbsp;</p>
        <p>
            ZIP CODE <asp:TextBox ID="ZipCode" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Submit the form to get the weather
        </p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Response:</p>
        <p>
            <asp:Label ID="Response" runat="server"></asp:Label>
        </p>
    </form>

</body>
</html>
