<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateParty.aspx.cs" Inherits="RPGMeet.CreateParty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Crear Partida</h2>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Título"></asp:Label>
            <asp:TextBox ID="TxtBoxCreateTitle" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Título"></asp:Label>
            <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
