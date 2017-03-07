<%@ Page Title="CarWebpageAddView" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarWebpageAddView.aspx.cs" Inherits="WebViewLayer.CarWebpageViews.CarWebpageAddView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cars</h1>
        <h2>Add</h2>
    </div>

    <div class="row">
        <h3>Vehicle information</h3>
        <div class="col-md-2">
            <br/><label>Vehicle name: </label>
            <br/><label>Number plate: </label>
            <br/><label>Car type: </label>
            <br/><label>Weight(Kg): </label>
            <br/><label>Fuel capacity(l): </label>
            <br/><label>Milage(MpG): </label>
            <br/><label>Passenger capacity: </label>
        </div>
        <div class="col-md-2">
            <br/><asp:TextBox runat="server" ID="vehicleNameTxtBox"></asp:TextBox>
            <br/><asp:TextBox runat="server" ID="numberPlateTxtBox"></asp:TextBox>
            <br/><asp:DropDownList runat="server" ID="carTypeDdl"></asp:DropDownList>
            <br/><asp:TextBox runat="server" ID="weightTxtBox"></asp:TextBox>
            <br/><asp:TextBox runat="server" ID="fuelCapacityTxtBox"></asp:TextBox>
            <br/><asp:TextBox runat="server" ID="milageTxtBox"></asp:TextBox>
            <br/><asp:TextBox runat="server" ID="passengerCapacityTxtBox"></asp:TextBox>
            <br/><br/><asp:Button runat="server" ID="submitBtn" Text="Submit" OnClick="submitBtn_Click"/>
        </div>
    </div>

</asp:Content>
