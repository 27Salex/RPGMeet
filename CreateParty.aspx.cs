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
     - Configurar Segunda Tematica (todo) Acabar de hablar si es necesario
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

            int juego = DalJuego.GetIdByName(DropDownGame.SelectedValue);
            int temaPri = DalTema.GetIdByName(DropDownPri.SelectedValue);
            int temaSec = DalTema.GetIdByName(DropDownPri.SelectedValue); //Mirar que no se duplique el valor
            int gameMaster = int.Parse(Session["UserID"].ToString());
            int localidad = DalLocalidad.GetIdByName(DropDownLoc.SelectedValue);

            Grupo grupo = new Grupo();

            grupo.TituloParitda = titulo;
            grupo.Descripcion = descripcion;
            grupo.EstadoGrupo = 0; // De base va a estar buscando, luego el creador podrá elejir si cerrar o no
            grupo.MaxJugadores = maxPly;

            grupo.QuedarLunes = lunes;
            grupo.QuedarMartes = martes;
            grupo.QuedarMiercoles = miercoles;
            grupo.QuedarJueves = jueves;
            grupo.QuedarViernes = viernes;
            grupo.QuedarSabado = sabado;
            grupo.QuedarDomingo = domingo;

            grupo.FKJuego = juego;
            grupo.FKTemaPrincipal = temaPri;
            grupo.FKTemaSecundario = temaSec; //Mirar que no se pueda insertar el mismo tema en los 2 Dropdowns
            grupo.FKGameMaster = gameMaster;
            grupo.FKLocalidad = localidad;
            
            //Envia el grupo a la base de datos
            DalGrupo.Create(grupo);

            //Mirar donde enviar al User tras crear una partida (Seguramente a "Mis Partidas")
            //Response.Redirect("/Mis Partidas");
        }

        bool CheckCamps() //Mostrar si los campos estan vacios
        {
            bool correctCamps = true;
            
            if (TxtBoxCreateTitle.Text.IsNullOrWhiteSpace())
            {
                correctCamps = false;
                TxtBoxCreateTitle.BackColor = Color.FromArgb(255, 155, 122);
                LbTitleError.Visible = true;
            }
            else
            {
                TxtBoxCreateTitle.BackColor = Color.White;
                LbTitleError.Visible = false;
            }

            if (TxtBoxCreateMaxPly.Text.IsNullOrWhiteSpace())
            {
                correctCamps = false;
                TxtBoxCreateMaxPly.BackColor = Color.FromArgb(255, 155, 122);
                LbMaxPlyError.Visible = true;
            }
            else
            {
                TxtBoxCreateMaxPly.BackColor = Color.White;
                LbMaxPlyError.Visible = false;
            }

            bool anyDaySel = CheckBoxDays.SelectedIndex != -1; //Mira si algún dia esta marcado

            //Dropdowns de tematica principal y juego
            if (DropDownPri.SelectedIndex == 0) //Fuerza a seleccionar un juego, tema prin
            { 
                correctCamps = false;
                LbTemaPriError.Visible = true;
            }
            else
                LbTemaPriError.Visible = false;

            if (DropDownGame.SelectedIndex == 0)
            {
                correctCamps = false;
                LbGameError.Visible = true;
            }
            else
                LbGameError.Visible = false;

            if (!anyDaySel)     //Fuerza a seleccionar un dia minimo de la CheckBoxList
            { 
                correctCamps = false;
                LbDaysError.Visible = true;
            }
            else
                LbDaysError.Visible = false;

            return correctCamps;
        }
    }
}