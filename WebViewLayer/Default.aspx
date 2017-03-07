<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebViewLayer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>NHibernate project</h1>
        <p class="lead">NHibernate database program</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Car</h2>
            <p>
                Add, remove, edit, passengers, calculate fuel and refuel cars.
            </p>
            <p>
                <a class="btn btn-default" href="CarWebpageViews/CarWebpageView.aspx">Go &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Lorry</h2>
            <p>
                Add, remove, edit, passengers, calculate fuel and refuel lorrys.
            </p>
            <p>
                <a class="btn btn-default" href="LorryWebpageViews/LorryWebpageView.aspx">Go &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Motorbike</h2>
            <p>
                Add, remove, edit, passengers, calculate fuel and refuel motorbikes.
            </p>
            <p>
                <a class="btn btn-default" href="MotorbikeWebpageViews/MotorbikeWebpageView.aspx">Go &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
