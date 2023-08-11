<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SingUp.aspx.cs" Inherits="RPGMeet.SingUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:ImageButton ID="ImageButton1" runat="server" />
</div>
<div>
    <h2>Crear Cuenta</h2>
</div>
<div>
    <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label>
    <asp:TextBox ID="TxtBoxRegisterUser" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label2" runat="server" Text="Mail:"></asp:Label>
    <asp:TextBox ID="TxtBoxRegisterMail" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
    <asp:TextBox ID="TxtBoxRegisterPsw" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label4" runat="server" Text="Confirmar Contraseña:"></asp:Label>
    <asp:TextBox ID="TxtBoxRegisterPswCon" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label5" runat="server" Text="Localidad"></asp:Label>
    <select id="SelectRegisterLoc">
        <option>Lleida</option>
        <option>Girona</option>
        <option>Barcelona</option>
        <option>Tarragona</option>
    </select>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
</div>
</asp:Content>
