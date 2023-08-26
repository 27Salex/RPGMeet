using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Panel Build()
        {
            //crear y meter en rowTargetGrupos
            Panel pnlTargetGrupo = new Panel();
            pnlTargetGrupo.CssClass = "col-sm-12 col-md-6 col-xl-5 ms-4 me-4 tarjeta bg-info";
            Panel pnlTargetGrupoRow = new Panel();
            pnlTargetGrupoRow.CssClass = "row";

            Panel pnlTituloTargetGrupo = new Panel();
            pnlTituloTargetGrupo.CssClass = "col-12 h4";

            Label lblTituloTargetGrupo = new Label();
            lblTituloTargetGrupo.Text = TargetGrupo.TituloParitda;

            Panel pnlDescripcion = new Panel();
            pnlDescripcion.CssClass = "col-6 rounded-pill";

            Label lblDescripcionTitle = new Label();
            lblDescripcionTitle.CssClass = "h4 d-block";
            lblDescripcionTitle.Text = "Descripción: ";

            Label lblDescripcion = new Label();
            lblDescripcion.Text = TargetGrupo.Descripcion;

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
            pnlBtnInfo.ID = "pnlBtnInfo" + TargetGrupo.IdGrupo;
            pnlBtnInfo.CssClass = "col-6";

            Button btnInfo = new Button();
            btnInfo.CssClass = "btn btn-info";
            btnInfo.Text = "Mas información";

            pnlBtnInfo.Controls.Add(btnInfo);

            Panel pnlBtnApuntarse = new Panel();
            pnlBtnApuntarse.CssClass = "col-6 d-flex justify-content-end";

            Button btnApuntarse = new Button();
            btnApuntarse.CssClass = "btn btn-info";
            btnApuntarse.Text = "Apuntarse";

            pnlBtnApuntarse.Controls.Add(btnApuntarse);

            pnlTargetGrupo.Controls.Add(pnlTargetGrupoRow);
            pnlTargetGrupoRow.Controls.Add(pnlTituloTargetGrupo);
            pnlTargetGrupoRow.Controls.Add(pnlDescripcion);
            pnlTargetGrupoRow.Controls.Add(pnlInfoCorta);
            pnlTargetGrupoRow.Controls.Add(pnlBtnInfo);
            pnlTargetGrupoRow.Controls.Add(pnlBtnApuntarse);

            pnlTituloTargetGrupo.Controls.Add(lblTituloTargetGrupo);
            pnlDescripcion.Controls.Add(lblDescripcion);

            return pnlTargetGrupo;
        }
    }
}