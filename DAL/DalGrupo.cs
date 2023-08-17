using RPGMeet.Model;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RPGMeet.DAL
{
    public class DalGrupo
    {

        public static Grupo ReaderGrupo(SqlDataReader reader)
        {
            Grupo grupo = new Grupo();

            /*
            
         
             **/
            grupo.IdGrupo = (int)reader["Idgrupo"];
            grupo.TituloParitda = reader["TituloParitda"].ToString();
            grupo.Descripcion = reader["Descripcion"].ToString();
            grupo.MaxJugadores = (short)reader["MaxJugadores"];
            grupo.QuedarLunes = (bool)reader["QuedarLunes"];
            grupo.QuedarMartes = (bool)reader["QuedarMartes"];
            grupo.QuedarMiercoles = (bool)reader["QuedarMiercoles"];
            grupo.QuedarJueves = (bool)reader["QuedarJueves"];
            grupo.QuedarViernes = (bool)reader["QuedarViernes"];
            grupo.QuedarSabado = (bool)reader["QuedarSabado"];
            grupo.QuedarDomingo = (bool)reader["QuedarDomingo"];

            grupo.FKJuego = (int)reader["FKJuego"];
            grupo.FKTemaPrincipal = (int)reader["FKTemaPrincipal"];
            grupo.FKTemaSecundario = (int)reader["FKTemaSecundario"];
            grupo.FKGameMaster = (int)reader["FKGameMaster"];


            // REALIZAR LO MISMO DE CREADOR PARA LOS TEMAS 
            grupo.Creador = DalUsuario.SelectById(grupo.FKGameMaster);
           
            return grupo;
        }
    }
}