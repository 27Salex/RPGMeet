using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class PruebaListaPartidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Partida[] partidas = new Partida[]
            //{
            //    new Partida("Partida 1", "Descripción de la partida 1"),
            //    new Partida("Partida 2", "Descripción de la partida 2"),
            //    new Partida("Partida 3", "Descripción de la partida 3"),
            //    new Partida("Partida 4", "Descripción de la partida 4"),
            //    new Partida("Partida 5", "Descripción de la partida 5"),
            //};
            //foreach (Partida partida in partidas)
            //{
            //    Panel divPartida = new Panel { CssClass = "col-7 bg-grey pt-3 pb-3" };

            //    string contenidoPartida = $@"
            //    <div class=""col-6 rounded-pill my-grey"">
            //        <h2>{partida.Titulo}</h2>
            //    </div>
            //    <div class=""col-6 d-flex justify-content-end"">
            //        <img class=""imagen-perfil joined rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil joined rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil joined rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil joined rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil empty rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil empty rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //        <img class=""imagen-perfil empty rounded-circle"" src=""Img/pngegg.png"" alt=""fotoDePerfil""/>
            //    </div>
            //    <div class=""col-6"">
            //        <h4>Descripcíón breve:</h4>
            //        <p>{partida.Descripcion}</p>
            //    </div>

            //    <div class=""col-6 d-flex justify-content-end"">
            //        <div>
            //            <asp:Label ID=""lblDisponibilidad"" class=""d-block"" runat=""server"" Text=""Disponibilidad: Fin de semana""></asp:Label>

            //            <asp:Label ID=""Label1"" class=""d-block"" runat=""server"" Text=""Tematica: Medieval""></asp:Label>

            //            <asp:Label ID=""Label2"" class=""d-block"" runat=""server"" Text=""Jugadores: 4/7""></asp:Label>
            //        </div>
            //    </div>

            //    <div class=""col-6"">
            //        <asp:Button ID=""Button1"" class=""btn btn-partida"" runat=""server"" Text=""Mas información"" />
            //    </div>
            //    <div class=""col-6 d-flex justify-content-end"">
            //        <asp:Button ID=""Button2"" class=""btn btn-partida"" runat=""server"" Text=""Apuntarse"" />
            //    </div>";

            //    divPartida.Controls.Add(new LiteralControl(contenidoPartida));
            //    contenedorPartidas.Controls.Add(divPartida);
            //}
        }
    }
    public class Partida
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public Partida(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
        }
    }
}