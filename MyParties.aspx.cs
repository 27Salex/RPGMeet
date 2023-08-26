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
        private List<Grupo> grupos = DalGrupo.SelectAll();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

            foreach (var grupo in grupos)
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
                        b.Click += new EventHandler(BtnApuntarse_Click);
                }

                //Finalmente añadimos el control
                PanelPartidas.Controls.Add(control);
            }
        }
        protected void BtnMore_Click(Object sender, EventArgs e)
        {
            //Obtenemos la id de la partida a la que pertenece el boton pulsado
            Control c = (Control)sender;
            c.ID.Replace("BtnMasInfo", "");
            int idGrupo = int.Parse(c.ID.Replace("BtnMasInfo", ""));
            //Response.Redirect("/PartyDetails?id=" + idGrupo);
        }
        protected void BtnApuntarse_Click(Object sender, EventArgs e)
        {
            //Obtenemos la id de la partida a la que pertenece el boton pulsado
            Control c = (Control)sender;
            int idGrupo = int.Parse(c.ID.Replace("BtnApuntarse", ""));
            //DalGrupo.AgregarJugador(int.Parse(Session["UserID"].ToString(),idGrupo);
        }
    }
}