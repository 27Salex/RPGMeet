using RPGMeet.DAL;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class PartidaInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grupo grupo;
                if (Request.QueryString["Id"] != null)
                {
                    grupo = DalGrupo.SelectById(Int32.Parse(Request.QueryString["Id"]));
                    lblTituloPartida.Text = grupo.TituloParitda;
                    lblJuego.Text = DalJuego.SelectById(grupo.FKJuego).NombreJuego;
                    lblDescripcion.Text = grupo.Descripcion;
                    lblDiasDisponibles.Text = grupo.GetDiasDisponibles();
                    lblTemas.Text = $"{DalTema.SelectById(grupo.FKTemaPrincipal).NombreTema}, {DalTema.SelectById(grupo.FKTemaSecundario).NombreTema}";
                    lblJugadores.Text = $"0/{grupo.MaxJugadores}";
                    lblGameMasterNombre.Text = DalUsuario.SelectById(grupo.FKGameMaster).Username;
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parties.aspx");
        }
    }
}