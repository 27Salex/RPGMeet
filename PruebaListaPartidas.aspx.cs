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
            List<Partida> partidas = new List<Partida>
            {
            };

            for (int i = 0; i < 99; i++)
            {
                partidas.Add(new Partida($"Partida {i}", $"Descripción de la partida {i}\n Vivamus molestie tristique justo, nec tincidunt velit bibendum quis. Nulla ac justo quis mauris consectetur aliquam. Vivamus et volutpat leo. Suspendisse ac porta nisi. Curabitur sed aliquam dui. Ut sodales sodales nibh, ac porttitor dui bibendum non. Etiam auctor lectus eget neque congue dictum. Praesent accumsan metus vitae arcu imperdiet, eu sodales sem congue."));
            }
            foreach (Partida partida in partidas)
            {
                //crear y meter en rowPartidas
                Panel pnlPartida = new Panel();
                pnlPartida.CssClass = "col-md-12 col-xl-5 ms-4 me-4 tarjeta bg-grey";
                Panel pnlPartidaRow = new Panel();
                pnlPartidaRow.CssClass = "row";

                Panel pnlTituloPartida = new Panel();
                pnlTituloPartida.CssClass = "col-12 h4";

                Label lblTituloPartida = new Label();
                lblTituloPartida.Text = partida.Titulo;

                Panel pnlDescripcion = new Panel();
                pnlDescripcion.CssClass = "col-6 rounded-pill";

                Label lblDescripcionTitle = new Label();
                lblDescripcionTitle.CssClass = "h4 d-block";
                lblDescripcionTitle.Text = "Descripción: ";
                
                Label lblDescripcion = new Label();
                lblDescripcion.Text = partida.Descripcion;

                Panel pnlInfoCorta = new Panel();
                pnlInfoCorta.CssClass = "col-6 d-flex justify-content-end";

                Panel innerRow = new Panel();
                innerRow.CssClass = "row";

                string[] labelsText = { "Disponibilidad:", "Tematica:", "Jugadores:" };
                string[] labelsValues = { "Fin de semana", "Medieval", "4/7" };

                for (int i = 0; i < labelsText.Length; i++)
                {
                    Panel labelCol = new Panel();
                    labelCol.CssClass = "col-12 col-md-6 d-flex justify-content-md-end";

                    Label label = new Label();
                    label.Text = labelsText[i];
                    labelCol.Controls.Add(label);

                    Panel valueCol = new Panel();
                    valueCol.CssClass = "col-12 col-md-6";

                    Label valueLabel = new Label();
                    valueLabel.Text = labelsValues[i];
                    valueCol.Controls.Add(valueLabel);

                    innerRow.Controls.Add(labelCol);
                    innerRow.Controls.Add(valueCol);
                }

                pnlInfoCorta.Controls.Add(innerRow);

                Panel pnlBtnInfo = new Panel();
                pnlBtnInfo.ID = "pnlBtnInfo";
                pnlBtnInfo.CssClass = "col-6";

                Button btnInfo = new Button();
                btnInfo.CssClass = "btn btn-partida";
                btnInfo.Text = "Mas información";

                pnlBtnInfo.Controls.Add(btnInfo);

                Panel pnlBtnApuntarse = new Panel();
                pnlBtnApuntarse.CssClass = "col-6 d-flex justify-content-end";

                Button btnApuntarse = new Button();
                btnApuntarse.CssClass = "btn btn-partida";
                btnApuntarse.Text = "Apuntarse";

                pnlBtnApuntarse.Controls.Add(btnApuntarse);

                pnlPartida.Controls.Add(pnlPartidaRow);
                pnlPartidaRow.Controls.Add(pnlTituloPartida);
                pnlPartidaRow.Controls.Add(pnlDescripcion);
                pnlPartidaRow.Controls.Add(pnlInfoCorta);
                pnlPartidaRow.Controls.Add(pnlBtnInfo);
                pnlPartidaRow.Controls.Add(pnlBtnApuntarse);

                pnlTituloPartida.Controls.Add(lblTituloPartida);
                pnlDescripcion.Controls.Add(lblDescripcion);

                rowPartidas.Controls.Add(pnlPartida);
            }
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