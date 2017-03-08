<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarPassengerWebpageView.aspx.cs" Inherits="WebViewLayer.CarWebpageViews.CarPassengerWebpageView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cars</h1>
        <h2>Passengers</h2>
    </div>

    <asp:Panel runat="server" ID="idEntryPanel" Visible="true">
        <label>Id:</label><asp:TextBox runat="server" ID="idTxtBox"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="submitIdBtn" OnClick="submitIdBtn_Click" Text="Submit" />
    </asp:Panel>


    <div class="row">
        <div class="col-md-2">
            <asp:Panel runat="server" ID="linksPanel" Visible="false">
                <ul>
                    <li>
                        <asp:LinkButton runat="server" ID="tableLnkBtn" OnClick="tableLnkBtn_Click">Table</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton runat="server" ID="addLnkBtn" OnClick="addLnkBtn_Click">Add</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton runat="server" ID="deleteLnkBtn" OnClick="deleteLnkBtn_Click">Delete</asp:LinkButton></li>
                </ul>
            </asp:Panel>
        </div>
        <div class="col-md-10">
            <asp:Panel runat="server" ID="tablePanel" Visible="false">
                <asp:Table runat="server" ID="passengerTable" Style="border: 1px solid black" GridLines="Both" HorizontalAlign="Justify" CellPadding="5" CellSpacing="5">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>Id</asp:TableHeaderCell>
                        <asp:TableHeaderCell>First Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Last Name</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </asp:Panel>
            <asp:Panel runat="server" ID="addPanel" Visible="false">
                <label>First name:</label><asp:TextBox runat="server" ID="firstNameTxtBox"></asp:TextBox>
                <label>Last name:</label><asp:TextBox runat="server" ID="lastNameTxtBox"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="addBtn" Text="Submit" OnClick="addBtn_Click" />
            </asp:Panel>
            <asp:Panel runat="server" ID="deletePanel" Visible="false">
                <label>Id:</label><asp:TextBox runat="server" ID="removeIdTxtBox"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="removeBtn" Text="Submit" OnClick="removeBtn_Click" />
            </asp:Panel>
        </div>
    </div>

</asp:Content>
