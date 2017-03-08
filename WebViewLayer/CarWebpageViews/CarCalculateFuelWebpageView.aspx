<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarCalculateFuelWebpageView.aspx.cs" Inherits="WebViewLayer.CarWebpageViews.CarCalculateFuelWebpageView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cars</h1>
        <h2>Calculate fuel</h2>
    </div>

    <div class="row">
        <div class="col-md-4">
            <label>Id:</label>
            <br/><label>Distance(miles):</label>
            <br/><asp:Button runat="server" id="refuelBtn" Text="Refuel" OnClick="refuelBtn_Click"/>
        </div>
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="idTxtBox"></asp:TextBox>
            <br/><asp:TextBox runat="server" ID="distanceTxtBox"></asp:TextBox>
            <br/><asp:Button runat="server" ID="submitBtn" OnClick="submitBtn_Click" Text="Simulate"/>
        </div>
    </div>

</asp:Content>
