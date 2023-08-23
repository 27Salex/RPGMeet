using Microsoft.Ajax.Utilities;
using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class ListaDePartidasFiltros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
       

        protected void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            Filtro filtro = new Filtro();

            // CODIGO PARA EL FILTRO DE DIAS DISPONIBLES

            foreach (ListItem dia in chkListDisponibilidad.Items)
            {
                switch (dia.Value)
                {
                    case "Lunes":
                        filtro.QuedarLunes = dia.Selected;
                        break;
                    case "Martes":
                        filtro.QuedarMartes = dia.Selected;
                            break;
                    case "Miercoles":
                        filtro.QuedarMiercoles = dia.Selected;
                        break;
                    case "Jueves":
                        filtro.QuedarJueves = dia.Selected;
                        break;
                    case "Viernes":
                        filtro.QuedarViernes = dia.Selected;
                        break;
                    case "Sabado":
                        filtro.QuedarSabado = dia.Selected;
                        break;
                    case "Domingo":
                        filtro.QuedarDomingo = dia.Selected;
                        break;
                }
               
            }
            //CODIGO PARA EL FILTRO DEL NUMERO DE JUGADORES

            if  (string.IsNullOrEmpty(txtMaxJugadores.Text))
           {
                short numDefecto = 50;
                filtro.MaxJugadores = numDefecto;
            }
            else 
            {
                filtro.MaxJugadores = short.Parse(txtMaxJugadores.Text);
            }
           
            // LABEL DE PRUEBAS
            lblPrueba.Text=filtro.ToString();
           /* filtro.ListTematicas.Clear();

            foreach (ListItem tematicas in cbListTematica.Items ) 
            {
                if (tematicas.Selected) 
                {
                    filtro.ListTematicas.Add(tematicas.Value);
                }
            }*/
        }


        
    }
}