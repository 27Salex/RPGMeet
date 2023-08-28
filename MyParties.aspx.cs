using Microsoft.Ajax.Utilities;
using RPGMeet.DAL;
using RPGMeet.Model;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    //TO DO a futuro:
    /*
     - Configurar Segunda Tematica (No repetir con la 1ra tematica)
     */
    public partial class MyParties : System.Web.UI.Page
    {
        private List<Grupo> MisPartidas;
        private List<Grupo> PartidasParticipa;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null && Session["Username"] == null)
            {
                Response.Redirect("/Login");
            }

            MisPartidas = DalGrupo.MisPartidasCreadas(int.Parse(Session["UserID"].ToString()));
            PartidasParticipa = DalGrupo.MisPartidasApuntadas(int.Parse(Session["UserID"].ToString()));

            foreach (var grupo in MisPartidas)
            {
                //Creamos una targeta para poder conseguir el codigo para el control asp
                Tarjeta tarjeta = new Tarjeta(grupo);

                //Creamos el control usando el string
                Control control = ParseControl(tarjeta.Build());

                foreach (Button b in control.Controls.OfType<Button>())
                {
                    //Assignamos un evento segun el tipo de boton
                    if(b.ID.Contains("BtnMasInfo"))
                        b.Click += new EventHandler(BtnMore_Click);
                    if (b.ID.Contains("BtnApuntarse"))
                    {
                        b.Text = "Eliminar";
                        b.CssClass = "btn btn-danger";
                        b.ID = "BtnEliminar" + tarjeta.TargetGrupo.IdGrupo;
                        b.Click += new EventHandler(BtnApuntarse_Click);
                    }
                }

                //Finalmente añadimos el control
                PanelMisPartidas.Controls.Add(control);
            }

            foreach (var grupo in PartidasParticipa)
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
                    {
                        b.Text = "Desapuntarse";
                        b.CssClass = "btn btn-danger";
                        b.ID = "BtnDesapuntarse" + tarjeta.TargetGrupo.IdGrupo;
                        b.Click += new EventHandler(BtnApuntarse_Click);
                    }
                }

                //Finalmente añadimos el control
                PanelPartidasParticipa.Controls.Add(control);
            }
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
            int idGrupo;
            if(c.ID.Contains("BtnDesapuntarse"))
            {
                idGrupo = int.Parse(c.ID.Replace("BtnDesapuntarse", ""));
                if(DalGrupo.BorrarmePartida(int.Parse(Session["UserID"].ToString()),idGrupo))
                    Response.Redirect("/MyParties");
            }
            else if(c.ID.Contains("BtnEliminar"))
            {
                idGrupo = int.Parse(c.ID.Replace("BtnEliminar", ""));
                if (DalGrupo.DeleteGrupo(int.Parse(Session["UserID"].ToString()), idGrupo))
                    Response.Redirect("/MyParties");
                
            }
        }
    }
}