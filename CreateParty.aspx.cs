using Microsoft.Ajax.Utilities;
using RPGMeet.DAL;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            //Cargar Dropdown: Juego y Tematicas
        }

        protected void BtnCreateParty_Click(object sender, EventArgs e)
        {
            bool notEmpty = CheckCamps();
            if(notEmpty)
                CreateGroup();
        }

        //Genera el grupo con los datos del form
        void CreateGroup()
        {
            string titulo = TxtBoxCreateTitle.Text;
            string descripcion = TxtAreaCreateDesc.Text;
            short maxPly = short.Parse(TxtBoxCreateMaxPly.Text);

            bool lunes = CheckBoxDays.Items[0].Selected;
            bool martes = CheckBoxDays.Items[1].Selected;
            bool miercoles = CheckBoxDays.Items[2].Selected;
            bool jueves = CheckBoxDays.Items[3].Selected;
            bool viernes = CheckBoxDays.Items[4].Selected;
            bool sabado = CheckBoxDays.Items[5].Selected;
            bool domingo = CheckBoxDays.Items[6].Selected;

            int temaPri = DropDownPri.SelectedIndex;
            int temaSec = DropDownSec.SelectedIndex;
            int juego = DropDownGame.SelectedIndex;

            Grupo grupo = new Grupo();

            grupo.TituloParitda = titulo;
            grupo.EstadoGrupo = 1;
            grupo.MaxJugadores = maxPly;
            grupo.FKGameMaster = 1;
            grupo.FKTemaPrincipal = 1;
            grupo.FKJuego = 1;

            //Envia el grupo a la base de datos
            //DalGrupo.Create(grupo);
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps = true;
            
            if (TxtBoxCreateTitle.Text.IsNullOrWhiteSpace())
            {
                TxtBoxCreateTitle.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxCreateTitle.BackColor = Color.White;
            }

            if (TxtBoxCreateMaxPly.Text.IsNullOrWhiteSpace())
            {
                TxtBoxCreateMaxPly.BackColor = Color.FromArgb(255, 155, 122);
                correctCamps = false;
            }
            else
            {
                TxtBoxCreateMaxPly.BackColor = Color.White;
            }
            //Dropdowns de tematica principal y juego
            
            return correctCamps;
        }
    }
}