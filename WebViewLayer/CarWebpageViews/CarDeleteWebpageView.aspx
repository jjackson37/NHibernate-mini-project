<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarDeleteWebpageView.aspx.cs" Inherits="WebViewLayer.CarWebpageViews.CarDeleteWebpageView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cars</h1>
        <h2>Delete</h2>
    </div>

    <div class="row">
        <div class="col-md-4">
            <label>Id: </label><asp:TextBox runat="server" ID="idTxtBox"></asp:TextBox>
            <br/><asp:Button runat="server" ID="submitBtn" Text="Submit" OnClick="submitBtn_Click"/>
        </div>
    </div>

</asp:Content>
