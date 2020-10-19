<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoPages._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>CSE 445 Group 8 Assignment 5</h1>
    <table>
<thead>
  <tr>
    <th>Provider Name</th>
    <th>Service Name</th>
    <th>Service Link</th>
    <th>Service Description</th>
    <th>Resources Used</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>Ivan Martinez Morales</td>
    <td>NewsFocus</td>
    <td>
        <asp:HyperLink ID="HyperLInk2" runat="server" NavigateUrl="~/NewsFocus.aspx">News Focus Service</asp:HyperLink>
    </td>
    <td>Leverage NewsAPI in order to pull up URLs of articles of different topics</td>
    <td>NewsAPI</td>
  </tr>
  <tr>
    <td>Ivan Martinez Morales</td>
    <td>WeatherService</td>
    <td>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/WeatherService.aspx">Weather Service</asp:HyperLink>
      </td>
    <td>Leverage OpenWeatherAPI to get forecast data</td>
    <td>OpenWeatherAPI</td>
  </tr>
  <tr>
    <td>Christopher Canales</td>
    <td>CrimeService</td>
    <td>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CrimeServiceDemo.aspx">Crime Data Service</asp:HyperLink>
        </td>
    <td>Leverage Crime APIs in order to get crime data for a given lat/lon</td>
    <td>CrimeAPI</td>
  </tr>
  <tr>
    <td>Christopher Canales</td>
    <td>StockQuoteService</td>
    <td>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/StockService.aspx">Stock Service</asp:HyperLink>
      </td>
    <td>Leverage open APIs in order to return Stock Quote Data</td>
    <td>StockAPI</td>
  </tr>
</tbody>
</table>


</asp:Content>
