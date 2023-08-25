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
            grupo.Creador = DalUsuario.SelectById(grupo.FKGameMaster);
           
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

        public static List<Grupo> AplicarFiltros(Filtro filtro) //Parece que la Query devuelve bien, Mirar si el True es acceptado en la base de datos
        {
            String selectQuery = "SELECT * FROM Grupo WHERE MaxJugadores = @maxJugadores";
            List<Grupo> list = new List<Grupo>();

            SqlCommand insertCommand = new SqlCommand(selectQuery, conexion);
            insertCommand.Parameters.AddWithValue("@maxJugadores", filtro.MaxJugadores);

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
            }       //Añadir la busqueda por tema

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
            Console.WriteLine(selectQuery);
            return list;
        }

    }
}