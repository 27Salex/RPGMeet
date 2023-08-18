using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGMeet
{
    //TO DO:
    /*
     - Juego recibe parametros de base de datos
     - Tematicas recibe parametros de base de datos
     - Comprobacion de errores
            - Evitar Campos Vacios
            - Marcar Campos Obligatorios
     - Recojer Id de GM (Del Session)
     */
    public partial class CreateParty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void CreateGroup()
        {
            string titulo = TxtBoxCreateTitle.Text;
            string descripcion = TxtAreaCreateDesc.Text;
            int maxPly = int.Parse(TxtBoxCreateMaxPly.Text);
            /*
             Cada bool en referente a cada dia
            */
            
        }

        protected void BtnCreateParty_Click(object sender, EventArgs e)
        {

        }
    }
}