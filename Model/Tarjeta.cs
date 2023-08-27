using RPGMeet.DAL;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet.Model
{
    public class Tarjeta
    {
        public Grupo TargetGrupo { get; set; }
        public Tarjeta() 
        {

        }
        public Tarjeta(Grupo Grupo)
        {
            TargetGrupo = Grupo;
            
        }
        public string Build()
        {
            //{ TargetGrupo.IdGrupo}
            //
            //{ TargetGrupo.Descripcion}
            //{ DalTema.SelectById(TargetGrupo.FKTemaPrincipal).NombreTema},{ DalTema.SelectById(TargetGrupo.FKTemaSecundario).NombreTema}
            //0 /{ TargetGrupo.MaxJugadores}

            string localAsp = $@"
                <div id=""pnlPartida{TargetGrupo.IdGrupo}"" class=""text-dark col-sm-12 col-md-6 col-xl-5 mx-auto tarjeta animate__animated animate__fadeIn"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <label>Titulo:</label>
                            <h4 class=""h2"">{TargetGrupo.TituloParitda}</h4>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 col-sm-12"">
                            <label>Descripción:</label>                            
                            <textarea class=""form-control-plaintext text-glass"" readonly="""" style=""Resize:none;"">{TargetGrupo.Descripcion}</textarea>
                        </div>
                        <div class=""col-md-6 col-sm-12"">
                            <label>Temas:</label>
                            <div class=""form-control-plaintext text-glass"">{DalTema.SelectById(TargetGrupo.FKTemaPrincipal).NombreTema},<br>{DalTema.SelectById(TargetGrupo.FKTemaSecundario).NombreTema}</div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 col-sm-12"">
                            <label>Máximo de Jugadores:</label>                            
                            <div class=""form-control-plaintext text-glass"">0/{TargetGrupo.MaxJugadores}</div>
                        </div>
                        <div class=""col-md-6 col-sm-12"">
                            <label>Juego:</label>
                            <div class=""form-control-plaintext text-glass"">{DalJuego.SelectById(TargetGrupo.FKJuego).NombreJuego}</div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12"">
                            <label>Disponibilidad:</label>                            
                            <div class=""form-control-plaintext text-glass"">{GetDiasDisponibles(TargetGrupo)}</div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <asp:button runat=""server"" id=""BtnMasInfo{TargetGrupo.IdGrupo}"" value=""{TargetGrupo.IdGrupo}"" class=""btn btn-info"" text=""Mas información""></asp:button>
                        </div>
                        <div class=""col-6"">
                            <asp:button runat=""server"" id=""BtnApuntarse{TargetGrupo.IdGrupo}"" value=""{TargetGrupo.IdGrupo}"" text=""Apuntarme"" class=""btn btn-info""></asp:button>
                        </div>
                    </div>
                </div>";

            return localAsp;
        }
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
    }
}