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
            List<Local> locales = new List<Local>
            {
                new Local("Nombre del local 1", "Descripción del local 1", "UrlImagen1", "Dirección 1", "SitioWeb1", "Teléfono 1"),
                new Local("Nombre del local 2", "Descripción del local 2", "UrlImagen2", "Dirección 2", "SitioWeb2", "Teléfono 2"),
                // Agregar más locales aquí...
            };

            foreach (Local local in locales)
            {
                Panel pnlLocal = new Panel();
                pnlLocal.CssClass = "col-12 col-xl-6 ms-4 me-4 tarjeta bg-light shadow";

                Panel row1 = new Panel();
                row1.CssClass = "row";

                Panel nombrePanel = new Panel();
                nombrePanel.CssClass = "col-12 text-center h3";

                Label lblNombre = new Label();
                lblNombre.Text = local.Nombre;

                nombrePanel.Controls.Add(lblNombre);

                // Crear otros paneles y controles para el resto de la información de la tarjeta...

                row1.Controls.Add(nombrePanel);
                // Agregar otros paneles a row1...

                pnlLocal.Controls.Add(row1);
                // Agregar row1 y otros paneles al pnlLocal...

                pnlLocales.Controls.Add(pnlLocal); // Agregar la tarjeta al panel pnlLocales en tu página ASP.NET
            }
        }
    }
}