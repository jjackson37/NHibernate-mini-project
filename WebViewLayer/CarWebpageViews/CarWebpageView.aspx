<%@ Page Title="CarWebpageView" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarWebpageView.aspx.cs" Inherits="WebViewLayer.CarWebpageView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cars</h1>
    </div>
    
    <div class="row">
        <div class="col-md-2">
            <ul>
                <li><a href="CarAddWebpageView.aspx">Add</a></li>
                <li><a href="CarDeleteWebpageView.aspx">Delete</a></li>
                <li><a href="CarEditWebpageView.aspx">Edit</a></li>
                <li><a href="CarPassengerWebpageView.aspx">Passengers</a></li>
                <li><a href="CarCalculateFuelWebpageView.aspx">Calculate fuel</a></li>
            </ul>
        </div>
        <div class="col-md-10">
            <asp:Table runat="server" ID="carsTable" style="border: 1px solid black" GridLines="Both" HorizontalAlign="Justify" CellPadding="5" CellSpacing="5">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Id</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Numberplate</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Car type</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Weight</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Milage</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Fuel</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Passenger</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </div>
</asp:Content>
