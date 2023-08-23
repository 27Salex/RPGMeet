using Microsoft.Ajax.Utilities;
using RPGMeet.DAL;
using RPGMeet.Model;
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
     - Comprobacion de errores
            - Evitar Campos Vacios
            - Marcar Campos Obligatorios
     - Recojer Id de GM (Del Session)
     - Configurar Segunda Tematica (todo)
     - Pasar Objeto Grupo con todos los valores

     */
    public partial class CreateParty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] == null && Session["Username"] == null)
            {
                Response.Redirect("/Login");
            }

            if (!IsPostBack)
            {
                List<string> localidades = new List<string>();
                List<string> juegos = new List<string>();
                List<string> temas = new List<string>();

                localidades.Add("Selecciona una opción");
                juegos.Add("Selecciona una opción");
                temas.Add("Selecciona una opción");

                foreach(Localidad localidad in DalLocalidad.SelectAll())
                {
                    localidades.Add(localidad.NombreLocalidad);
                }
            
                foreach(Juego juego in DalJuego.SelectAll())
                {
                    juegos.Add(juego.NombreJuego);
                }
            
                foreach(Tema tema in DalTema.SelectAll())
                {
                    temas.Add(tema.NombreTema);
                }

                DropDownLoc.DataSource = localidades;
                DropDownGame.DataSource = juegos;
                DropDownPri.DataSource = temas;
                DropDownSec.DataSource = temas;
                DropDownLoc.DataBind();
                DropDownGame.DataBind();
                DropDownPri.DataBind();
                DropDownSec.DataBind();
            }
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
            grupo.EstadoGrupo = 1; //Hardcoded
            grupo.MaxJugadores = maxPly;
            grupo.FKGameMaster = int.Parse(Session["UserID"].ToString()); //Hardcoded Por session
            grupo.FKTemaPrincipal = DalJuego.GetIdByName(DropDownPri.SelectedValue); //Revisar al incorporar el otro dropdown
            grupo.FKJuego = DalJuego.GetIdByName(DropDownGame.SelectedValue);

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

            bool anyDaySel = CheckBoxDays.SelectedIndex != -1; //Mira si algún dia esta marcado
            
            //Dropdowns de tematica principal y juego
            if(DropDownPri.SelectedIndex == 0) //Fuerza a seleccionar un juego, tema prin y Loc
                correctCamps = false;
            if(DropDownGame.SelectedIndex == 0)
                correctCamps = false;
            if(DropDownLoc.SelectedIndex == 0)
                correctCamps = false;
            if (!anyDaySel)
                correctCamps = false;

            return correctCamps;
        }
    }
}