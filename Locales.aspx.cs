using RPGMeet.DAL;
using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class Locales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Tienda> tiendas = DalTienda.SelectAll();
            if (!IsPostBack)
            {
                foreach (Tienda tienda in tiendas)
                {
                    string localHtml = $@"
                    <div class=""col-12 col-xl-6 ms-4 me-4 tarjeta shadow"">
                        <div class=""row"">
                            <div class=""col-12 text-center h3"">
                                {tienda.Nombre}
                            </div>
                            <div class=""col-6 text-left align-self-center"">
                                {tienda.Descripcion}
                            </div>
                            <div class=""col-6"">
                                <div class=""imagen-contenedor"">
                                    <img src=""{tienda.ImgUrl}"" style=""height:200px;width:200px;aspect-ratio: 1 / 1;""""/> <!-- Imagen del local -->
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 d-flex m-3 justify-content-end"">
                            <div class=""row"">
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3"">
                                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Google_Maps_icon_%282020%29.svg/800px-Google_Maps_icon_%282020%29.svg.png"" class=""img-fluid icon"" /> <!-- imagen icono de punto de locaclizacion de google -->
                                        </div>
                                        <div class=""col-9"">
                                            {tienda.Direccion}
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3"">
                                            <img src=""https://cdn-icons-png.flaticon.com/512/72/72626.png"" class=""img-fluid icon"" /> <!-- imagen icono de sitio web -->
                                        </div>
                                        <div class=""col-9"">
                                            <a class=""btn btn-info"" href=""{tienda.Web}"">Web</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3"">
                                            <img src=""https://cdn2.iconfinder.com/data/icons/font-awesome/1792/phone-512.png"" class=""img-fluid icon"" /> <!-- imagen icono de sitio web -->
                                        </div>
                                        <div class=""col-9"">
                                            {tienda.Telefono}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>";
                    pnlLocales.Controls.Add(new LiteralControl(localHtml));
                }
            }
        }
    }
}