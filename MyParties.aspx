<%@ Page Title="Crear Grupo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyParties.aspx.cs" Inherits="RPGMeet.MyParties" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        :root {
        --grey: #D9D9D9;
        }
        .bg-grey{
            background-color: var(--grey);
        }

        div[class*="col"] {
            margin: 1vh 0 1vh 0;
        }
        .tarjeta{
            border-radius: 13px 13px 13px 13px;
            -moz-border-radius: 13px 13px 13px 13px;
            -webkit-border-radius: 13px 13px 13px 13px;
            border: 5px;
            -webkit-box-shadow: 0px 0px 87px -37px rgba(0,0,0,1);
            -moz-box-shadow: 0px 0px 87px -37px rgba(0,0,0,1);
            box-shadow: 0px 0px 87px -37px rgba(0,0,0,1);
            background: rgb(255,46,137);
            background: radial-gradient(circle, rgba(255,46,137,1) 0%, rgba(125,184,254,1) 100%);
            max-height:500px;
            overflow-y: scroll;
            overflow-x:hidden;
            margin: 15px 20px;
        }
        .scrollable-panel {
            max-height: 700px; 
            overflow-y: auto; 
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-lg-10 offset-lg-1">
                <h2 class="mb-3 h2">Crear Partida</h2>
                <div class="scrollable-panel grid gap-3 bg-white shadow rounded animate__animated animate__fadeInUp">
                    <asp:Panel class="row" runat="server" ID="PanelPartidas">
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>   
</asp:Content>
