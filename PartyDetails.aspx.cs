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
                if (Request.QueryString["Id"] != null)
                {
                    Grupo grupo = DalGrupo.SelectById(Int32.Parse(Request.QueryString["Id"]));
                    string localHtml = $@"
                        <div id=""pnlPartida{grupo.IdGrupo}"" class=""col-md-12 ms-4 me-4 tarjeta bg-light shadow"">
                            <div class=""row"">
                                <div class=""col-12 col-xl-8 text-center d-flex justify-content-center"">
                                    <h2>{grupo.TituloParitda}</h2>
                                </div>
                                <div class=""col-12 col-xl-4 text-end d-flex justify-content-end text-break"">
                                    <h4>Xx_PakitoGameMaster79_xX</h4>
                                </div>
                                <div class=""col-12"">
                                    <h3>Descripción: </h3>
                                    <p class=""text-break h5"">{grupo.Descripcion}</p>
                                </div>
                                <div class=""col-12"">
                                    <h3>Disponibilidad:</h3>
                                    <p class=""text-break h4"">{grupo.GetDiasDisponibles()}</p>
                                </div>
                                <div class=""col-12"">
                                    <h3>Tematica:</h3>
                                    <p class=""text-break h4"">{DalTema.SelectById(grupo.FKTemaPrincipal).NombreTema},{DalTema.SelectById(grupo.FKTemaSecundario).NombreTema}</p>
                                </div>
                                <div class=""col-12"">
                                    <h3>Jugadores:</h3>
                                    <p class=""h4"">0/{grupo.MaxJugadores}</p>
                                </div>
                            </div>
                        </div>";
                    MainContainer.Controls.Add(new LiteralControl(localHtml));
                }
            }
        }
    }
}