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
                Tarjeta tarjeta = new Tarjeta(grupo);
                PanelPartidas.Controls.Add(tarjeta.Build());
            }
        }
    }
}