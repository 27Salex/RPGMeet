using Microsoft.Ajax.Utilities;
using RPGMeet.DAL;
using RPGMeet.Model;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class Partidas : System.Web.UI.Page
    {
        string GetDiasDisponibles(Grupo grupo)
        {
            List<string> disponibilidad = new List<string>();
            if (grupo.QuedarLunes)
                disponibilidad.Add("Lunes");

            if (grupo.QuedarMartes)
                disponibilidad.Add("Martes");

            if (grupo.QuedarMiercoles)
                disponibilidad.Add("Miércoles");

            if (grupo.QuedarJueves)
                disponibilidad.Add("Jueves");

            if (grupo.QuedarViernes)
                disponibilidad.Add("Viernes");

            if (grupo.QuedarSabado)
                disponibilidad.Add("Sábado");

            if (grupo.QuedarDomingo)
                disponibilidad.Add("Domingo");

            return string.Join(", ", disponibilidad);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Grupo> grupos = DalGrupo.SelectAll();

            foreach (Grupo grupo in grupos)
            {
                string localHtml = $@"
                <div id=""pnlPartida{grupo.IdGrupo}"" class=""col-md-12 ms-4 me-4 tarjeta bg-grey"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h4>{grupo.TituloParitda}</h4>
                        </div>
                        <div class=""col-6 rounded-pill"">
                            <h4>Descripción: </h4>
                            <p class=""text-break"">{grupo.Descripcion}</p>
                        </div>
                        <div class=""col-6 d-flex justify-content-end"">
                            <div class=""row"">
                                <div class=""col-12 col-md-6 d-flex justify-content-md-end"">
                                    <p>Disponibilidad:</p>
                                </div>
                                <div class=""col-12 col-md-6"">
                                    <p class=""text-break"">{GetDiasDisponibles(grupo)}</p>
                                </div>
                                <div class=""col-12 col-md-6 d-flex justify-content-md-end"">
                                    <p>Tematica:</p>
                                </div>
                                <div class=""col-12 col-md-6"">
                                    <p class=""text-break"">{DalTema.SelectById(grupo.FKTemaPrincipal).NombreTema},{DalTema.SelectById(grupo.FKTemaSecundario).NombreTema}</p>
                                </div>
                                <div class=""col-12 col-md-6 d-flex justify-content-md-end"">
                                    <p>Jugadores:</p>
                                </div>
                                <div class=""col-12 col-md-6"">
                                    <p>0/{grupo.MaxJugadores}</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <button class=""btn btn-partida"">Mas información</button>
                        </div>
                        <div class=""col-6 d-flex justify-content-end"">
                            <button class=""btn btn-partida"">Apuntarse</button>
                        </div>
                    </div>
                </div>";

                LiteralControl literalControl = new LiteralControl(localHtml);

                rowPartidas.Controls.Add(literalControl);
            }
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
                short numDefecto = 10;
                filtro.MaxJugadores = numDefecto;
            }
            else 
            {
                filtro.MaxJugadores = short.Parse(txtMaxJugadores.Text);
            }
           
            // LABEL DE PRUEBAS
            

            foreach (ListItem tematicas in cbListTematica.Items ) 
            {
                if (tematicas.Selected== true)
                {
                    filtro.ListTematicas.Add(tematicas.Value);
                }
            }
        }
    }
}