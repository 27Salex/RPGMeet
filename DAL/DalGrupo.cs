using RPGMeet.Model;
using RPGMeet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RPGMeet.DAL
{
    public class DalGrupo
    {
        private static SqlConnection conexion = Conexion.Instance().Connection;

        public static Grupo ReaderGrupo(SqlDataReader reader)
        {
            Grupo grupo = new Grupo();

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
            //grupo.Creador = DalUsuario.SelectById(grupo.FKGameMaster);
           
            return grupo;
        }

        public static List<Grupo> SelectAll()
        {
            String selectQuery = "SELECT * FROM Grupo";
            List<Grupo> list = new List<Grupo>();


            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderGrupo(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo SelectAll\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }

        public static Grupo SelectById(int idGrupo)
        {
            String selectQuery = "SELECT * FROM grupo WHERE IdGrupo = @id";
            Grupo grupoBuscado = null;

            try
            {
                conexion.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, conexion);
                selectCommand.Parameters.AddWithValue("@id", idGrupo);
                SqlDataReader reader = selectCommand.ExecuteReader();

                reader.Read();
                grupoBuscado = ReaderGrupo(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo SelectById\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return grupoBuscado;
        }



        public static bool Create(Grupo grupo)
        {
            /*
            String insertQuery =@"
INSERT INTO Grupo (TituloParitda,  EstadoGrupo, MaxJugadores, EsOnline, FKGameMaster, FKTemaPrincipal, FKJuego) 
VALUES (@TituloParitda, @EstadoGrupo, @MaxJugadores,@EsOnline, @FKGameMaster, @FKTemaPrincipal, @FKJuego); 
SELECT CAST(SCOPE_IDENTITY() AS INT)";
            */

            //POL: Creo que con el cambio en base de datos y modelo no se crean las partidas, comentaré el code anterior por si acaso
            String insertQuery = @"INSERT INTO Grupo (TituloParitda, Descripcion, EstadoGrupo, MaxJugadores,
QuedarLunes, QuedarMartes, QuedarMiercoles, QuedarJueves, QuedarViernes, QuedarSabado, QuedarDomingo,
FKJuego, FKTemaPrincipal, FKTemaSecundario, FKGameMaster, FKLocalidad)

VALUES (@TituloParitda, @Descripcion, @EstadoGrupo, @MaxJugadores,
@QuedarLunes, @QuedarMartes, @QuedarMiercoles, @QuedarJueves, @QuedarViernes, @QuedarSabado, @QuedarDomingo,
@FKJuego, @FKTemaPrincipal, @FKTemaSecundario, @FKGameMaster, @FKLocalidad)";


            // SELECT CAST(SCOPE_IDENTITY() AS INT)  al final de la sentencia sql esto devuelve el ultimo id insertado 
            try
            {
                conexion.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, conexion);
                insertCommand.Parameters.AddWithValue("@TituloParitda", grupo.TituloParitda);
                insertCommand.Parameters.AddWithValue("@Descripcion", grupo.Descripcion); //new line
                insertCommand.Parameters.AddWithValue("@EstadoGrupo", grupo.EstadoGrupo);
                insertCommand.Parameters.AddWithValue("@MaxJugadores", grupo.MaxJugadores);
                //insertCommand.Parameters.AddWithValue("@EsOnline", grupo.EsOnline); //No se aplica
                insertCommand.Parameters.AddWithValue("@QuedarLunes", grupo.QuedarLunes); //new line
                insertCommand.Parameters.AddWithValue("@QuedarMartes", grupo.QuedarMartes); //new line
                insertCommand.Parameters.AddWithValue("@QuedarMiercoles", grupo.QuedarMiercoles); //new line
                insertCommand.Parameters.AddWithValue("@QuedarJueves", grupo.QuedarJueves); //new line
                insertCommand.Parameters.AddWithValue("@QuedarViernes", grupo.QuedarViernes); //new line
                insertCommand.Parameters.AddWithValue("@QuedarSabado", grupo.QuedarSabado); //new line
                insertCommand.Parameters.AddWithValue("@QuedarDomingo", grupo.QuedarDomingo); //new line
                insertCommand.Parameters.AddWithValue("@FKJuego", grupo.FKJuego);
                insertCommand.Parameters.AddWithValue("@FKTemaPrincipal", grupo.FKTemaPrincipal);
                insertCommand.Parameters.AddWithValue("@FKTemaSecundario", grupo.FKTemaSecundario); //new line
                insertCommand.Parameters.AddWithValue("@FKGameMaster", grupo.FKGameMaster);
                insertCommand.Parameters.AddWithValue("@FKLocalidad", grupo.FKLocalidad); //new line

                SqlDataReader reader = insertCommand.ExecuteReader();

                /*
                int UltimoId = (int)insertCommand.ExecuteScalar();

                grupo.IdGrupo = UltimoId;
                */
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo Create\n" + ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;

        }

        public static List<Grupo> AplicarFiltros(Filtro filtro) //--
        {
            String selectQuery = "SELECT * FROM Grupo WHERE MaxJugadores <= @maxJugadores";
            List<int> temasId = new List<int>();
            string ids = "";
            List<Grupo> list = new List<Grupo>();

            if(filtro.ListTematicas.Count > 0) //Mira si hay temas
            {         
                foreach (string tema in filtro.ListTematicas) //Consigue los todos los Ids          
                    temasId.Add(DalTema.GetIdByName(tema));
                for(int i = 0; i<temasId.Count(); i++) //Pasa los Ids a un formato para la Query
                    ids += temasId[i] + ",";
                ids = ids.Remove(ids.Length -1); //Elimina la ultima coma (no se podria ejecutar la Query si estubiera)

                selectQuery += " AND FKTemaPrincipal IN (" + ids + ") OR FKTemaSecundario IN (" + ids +") "; //Carga este fragmento a la mainQuery
            }

            if (!filtro.QuedarCualquierDia)
            {
                if (filtro.QuedarLunes)
                {
                    selectQuery += " AND QuedarLunes = " + filtro.QuedarLunes;
                }
                if (filtro.QuedarMartes)
                {
                    selectQuery += " AND QuedarMartes = " + filtro.QuedarMartes;
                }
                if (filtro.QuedarMiercoles)
                {
                    selectQuery += " AND QuedarMiercoles = " + filtro.QuedarMiercoles;
                }
                if (filtro.QuedarJueves)
                {
                    selectQuery += " AND QuedarJueves = " + filtro.QuedarJueves;
                }
                if (filtro.QuedarViernes)
                {
                    selectQuery += " AND QuedarViernes = " + filtro.QuedarViernes;
                }
                if (filtro.QuedarSabado)
                {
                    selectQuery += " AND QuedarSabado = " + filtro.QuedarSabado;
                }
                if (filtro.QuedarDomingo)
                {
                    selectQuery += " AND QuedarDomingo = " + filtro.QuedarDomingo;
                }
            }

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@maxJugadores", filtro.MaxJugadores);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderGrupo(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo SelectAll\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            Console.WriteLine(selectQuery);
            return list;
        }

        public static List<Grupo> MisPartidasCreadas( int id_User)
        {
            String selectQuery = "SELECT * FROM Grupo WHERE FKGameMaster = @idMaster";
            List<Grupo> list = new List<Grupo>();
           

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@idMaster", id_User);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderGrupo(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo MisPartidasCreadas\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }



        public static List<Grupo> MisPartidasApuntadas(int id_User)
        {
            String selectQuery = "SELECT * FROM Grupo WHERE IdGrupo IN (SELECT FKGrupo FROM UsuarioGrupo WHERE FKUsuario = @id_User)";
            List<Grupo> list = new List<Grupo>();


            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@id_User", id_User);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    list.Add(ReaderGrupo(reader));

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo MisPartidasApuntadas\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }



        public static bool ApuntarmePartida(int idUsuario, int idGrupo)
        {
           
            String insertQuery = "INSERT INTO UsuarioGrupo (FKUsuario,FKGrupo)VALUES(@idUsuario, @idGrupo)";

            try
            {
                conexion.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, conexion);
                insertCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                insertCommand.Parameters.AddWithValue("@idGrupo", idGrupo); 
               
                SqlDataReader reader = insertCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo ApuntarmePartida\n" + ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;

        }
        public static bool BorrarmePartida(int idUsuario, int idGrupo)
        {


            String deleteQuery = "DELETE FROM UsuarioGrupo WHERE FKUsuario = @idUsuario AND FKGrupo = @idGrupo ";

            try
            {
                conexion.Open();

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conexion);
                deleteCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                deleteCommand.Parameters.AddWithValue("@idGrupo", idGrupo);

                SqlDataReader reader = deleteCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo ApuntarmePartida\n" + ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;

        }


        public static bool DeleteGrupo(int idUsuario, int idGrupo)
        {


            String deleteQuery = "DELETE FROM Grupo WHERE FKGameMaster = @idUsuario AND idGrupo = @idGrupo ";

            try
            {
                conexion.Open();

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conexion);
                deleteCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                deleteCommand.Parameters.AddWithValue("@idGrupo", idGrupo);

                SqlDataReader reader = deleteCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalGrupo ApuntarmePartida\n" + ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;

        }

        /*
         
        borrar usuario, 
        y un filtro para buscar partidas por nomrbe
         */
    }
}