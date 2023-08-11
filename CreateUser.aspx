<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="RPGMeet.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
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
        </div>
    </form>
</body>
</html>
