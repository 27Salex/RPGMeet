using Microsoft.Ajax.Utilities;
using RPGMeet.DAL;
using RPGMeet.Model;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class Partidas : System.Web.UI.Page
    {
        private static Filtro filtro;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Grupo> grupos;
            if (Session["Filtro"] == null)
                grupos = DalGrupo.SelectAll();
            else
                grupos = DalGrupo.AplicarFiltros((Filtro)Session["Filtro"]);

            foreach (var grupo in grupos)
            {
                //Creamos una targeta para poder conseguir el codigo para el control asp
                Tarjeta tarjeta = new Tarjeta(grupo);

                //Creamos el control usando el string
                Control control = ParseControl(tarjeta.Build());

                foreach (Button b in control.Controls.OfType<Button>())
                {
                    //Assignamos un evento segun el tipo de boton
                    if (b.ID.Contains("BtnMasInfo"))
                        b.Click += new EventHandler(BtnMore_Click);
                    if (b.ID.Contains("BtnApuntarse"))
                        b.Click += new EventHandler(BtnApuntarse_Click);
                }

                //Finalmente añadimos el control
                PanelPartidas.Controls.Add(control);
            }
            

            if(!IsPostBack)
            {
                
                foreach (Tema tema in DalTema.SelectAll())
                {
                    ListItem item = new ListItem("&nbsp;&nbsp;" + tema.NombreTema);
                    item.Value = tema.NombreTema;
                    cbListTematica.Items.Add(item);
                }
                foreach (Juego juego in DalJuego.SelectAll())
                {
                    ListItem item = new ListItem("&nbsp;&nbsp;" + juego.NombreJuego);
                    item.Value = juego.NombreJuego;
                    cbListJuego.Items.Add(item);
                }
            }
            else
                valorJugadores.InnerHtml = "&nbsp;&nbsp;" + txtMaxJugadores.Text;
        }

        protected void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            filtro = new Filtro();
            // CODIGO PARA EL FILTRO DE DIAS DISPONIBLES

            filtro.QuedarLunes = chkListDisponibilidad.Items[0].Selected;
            filtro.QuedarMartes = chkListDisponibilidad.Items[1].Selected;
            filtro.QuedarMiercoles = chkListDisponibilidad.Items[2].Selected;
            filtro.QuedarJueves = chkListDisponibilidad.Items[3].Selected;
            filtro.QuedarViernes = chkListDisponibilidad.Items[4].Selected;
            filtro.QuedarSabado = chkListDisponibilidad.Items[5].Selected;
            filtro.QuedarDomingo = chkListDisponibilidad.Items[6].Selected;
            //CODIGO PARA EL FILTRO DEL NUMERO DE JUGADORES

            filtro.MaxJugadores = short.Parse(txtMaxJugadores.Text);
            
            foreach (ListItem tema in cbListTematica.Items ) 
            {
                if (tema.Selected== true)
                {
                    filtro.ListTematicas.Add(tema.Value);
                }
            }
            foreach (ListItem juego in cbListTematica.Items)
            {
                if (juego.Selected == true)
                {
                    filtro.ListTematicas.Add(juego.Value);
                }
            }
            Session.Add("Filtro", filtro);
            Response.Redirect("/Parties");
        }
        protected void BtnMore_Click(Object sender, EventArgs e)
        {
            //Obtenemos la id de la partida a la que pertenece el boton pulsado
            Control c = (Control)sender;
            c.ID.Replace("BtnMasInfo", "");
            int idGrupo = int.Parse(c.ID.Replace("BtnMasInfo", ""));
            Response.Redirect("/PartyDetails?ID=" + idGrupo);
        }
        protected void BtnApuntarse_Click(Object sender, EventArgs e)
        {
            //Obtenemos la id de la partida a la que pertenece el boton pulsado
            Control c = (Control)sender;
            int idGrupo = int.Parse(c.ID.Replace("BtnApuntarse", ""));
            DalGrupo.ApuntarmePartida(int.Parse(Session["UserID"].ToString()),idGrupo);
        }
    }
}