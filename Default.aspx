<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPGMeet._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <!-- meter este style en el sire.master/head acciendo referencia a la carpeta de estilos Home.css -->
        <style>
            .imagen-perfil
            {
                width: 50px;
                height: 50px;
                margin-right: 10px;
                margin-bottom: 10px;
            }
        </style>
        <div class="row">
        <!-- Presentación de la web -->
        <div class="col-md-12 mt-3 mb-3">
            <section class="row">
                <!-- Texto -->
                <div class="col-md-6">
                    <h5>Nombre App</h5>
                    <p>lorem Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas "Letraset", las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum.</p>
                </div>
                <!-- Imagen -->
                <div class="col-md-6">
                </div>
                <!-- Cambiar ID de este botón <3 -->
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </section>
        </div>

        <div class="col-md-12 mt-3 mb-3">
            <section class="row">
                <!-- Texto -->
                <div class="col-md-6">
                    <!-- Cambiar ID del label <3 -->
                    <asp:Label ID="lbl" runat="server" CssClass="h5">Titulo partida</asp:Label>
                </div>
                <div class="col-md-6 d-flex flex-wrap justify-content-end">
                    <!-- Imagen del perfil del usuario redondeada -->
                    <div class="d-flex flex-wrap justify-content-center w-50">
                        <asp:Image ID="Image1" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image2" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image3" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image4" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image5" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image6" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                        <asp:Image ID="Image7" runat="server" CssClass="rounded-circle imagen-perfil" ImageUrl="~/Img/pngegg.png"/>
                    </div>
                </div>
                
                <!-- Texto -->
                <div class="col-md-6">
                    <!-- Cambiar ID del label <3 -->
                    <asp:Label ID="Label1" runat="server" CssClass="h6">Descripción breve</asp:Label>
                </div>
                <div class="col-md-6 d-flex flex-wrap justify-content-end">
                    <!-- Imagen del perfil del usuario redondeada -->
                    <div>
                        <asp:Label runat="server" CssClass="d-block">Disponibilidad: Fin de semana</asp:Label>
                        <asp:Label runat="server" CssClass="d-block">Tematica: Medieval</asp:Label>
                        <asp:Label runat="server" CssClass="d-block">Jugadores: 4/7</asp:Label>
                    </div>
                </div>
            </section>
        </div>
</div>
    </main>
</asp:Content>
