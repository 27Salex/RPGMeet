using RPGMeet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    public partial class Tiendaes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Tienda> locales = new List<Tienda>
            {
                new Tienda(0,"Kaburi" , "Tienda especializado en juegos de mesa, de rol, merchandising o cartas, con un café donde probar los artículos.", "https://www.carrerdesants.cat/media/carrerdesants/image/fotos//993_Foto.1648810055.png", "Pg. de St. Joan, 11, 08010 Barcelona", "www.kaburi.es", 932459508),
            };

            for (int i = locales.Count; i < 19; i++)
            {
                locales.Add(new Tienda(i ,$"Tienda {i}", $"Descripción del local {i}\n Vivamus molestie tristique justo, nec tincidunt velit bibendum quis. Nulla ac justo quis mauris consectetur aliquam. Vivamus et volutpat leo. Suspendisse ac porta nisi. Curabitur sed aliquam dui. Ut sodales sodales nibh, ac porttitor dui bibendum non. Etiam auctor lectus eget neque congue dictum. Praesent accumsan metus vitae arcu imperdiet, eu sodales sem congue.", "https://www.carrerdesants.cat/media/carrerdesants/image/fotos//993_Foto.1648810055.png", "Pg. de St. Joan, 11, 08010 Barcelona", "www.kaburi.es", 932459508));
            }
            if (!IsPostBack)
            {
                /*
                foreach (Tienda local in locales)
                {

                    string localHtml = $@"
                    <div class=""col-12 col-xl-6 ms-4 me-4 tarjeta bg-light shadow"">
                        <div class=""row"">
                            <div class=""col-12 text-center h3"">
                                {local.Nombre}
                            </div>
                            <div class=""col-6 text-left align-self-center"">
                                {local.Descripcion}
                            </div>
                            <div class=""col-6"">
                                <img src=""{local.UrlImagen}"" class=""img-fluid rounded-2"" /> <!-- Imagen del local -->
                            </div>
                        </div>
                        <div class=""col-12 d-flex justify-content-end"">
                            <div class=""row"">
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3 d-inline"">
                                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Google_Maps_icon_%282020%29.svg/800px-Google_Maps_icon_%282020%29.svg.png"" class=""img-fluid icon"" /> <!-- imagen icono de punto de locaclizacion de google -->
                                        </div>
                                        <div class=""col-9 d-inline"">
                                            {local.Direccion}
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3 d-inline"">
                                            <img src=""https://cdn-icons-png.flaticon.com/512/72/72626.png"" class=""img-fluid icon"" /> <!-- imagen icono de sitio web -->
                                        </div>
                                        <div class=""col-9 d-inline"">
                                            <a>{local.SitioWeb}</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-4"">
                                    <div class=""row"">
                                        <div class=""col-3 d-inline"">
                                            <img src=""https://cdn2.iconfinder.com/data/icons/font-awesome/1792/phone-512.png"" class=""img-fluid icon"" /> <!-- imagen icono de sitio web -->
                                        </div>
                                        <div class=""col-9 d-inline"">
                                            {local.Telefono}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>";

                    pnlTiendas.Controls.Add(new LiteralControl(localHtml));
                }*/
            }
        }
    }
}