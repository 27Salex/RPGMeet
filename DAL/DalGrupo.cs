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
            String insertQuery =@"
INSERT INTO Grupo (TituloParitda,  EstadoGrupo, MaxJugadores, EsOnline, FKGameMaster, FKTemaPrincipal, FKJuego) 
VALUES (@TituloParitda, @EstadoGrupo, @MaxJugadores,@EsOnline, @FKGameMaster, @FKTemaPrincipal, @FKJuego); 
SELECT CAST(SCOPE_IDENTITY() AS INT)";

            // SELECT CAST(SCOPE_IDENTITY() AS INT)  al final de la sentencia sql esto devuelve el ultimo id insertado 
            try
            {
                conexion.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, conexion);
                insertCommand.Parameters.AddWithValue("@TituloParitda", grupo.TituloParitda);
                insertCommand.Parameters.AddWithValue("@EstadoGrupo", grupo.EstadoGrupo);
                insertCommand.Parameters.AddWithValue("@MaxJugadores", grupo.MaxJugadores);
                insertCommand.Parameters.AddWithValue("@EsOnline", grupo.EsOnline);
                insertCommand.Parameters.AddWithValue("@FKGameMaster", grupo.FKGameMaster);
                insertCommand.Parameters.AddWithValue("@FKTemaPrincipal", grupo.FKTemaPrincipal);
                insertCommand.Parameters.AddWithValue("@FKJuego", grupo.FKJuego);


                int UltimoId = (int)insertCommand.ExecuteScalar();

                grupo.IdGrupo = UltimoId;

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: DalUsuario Register\n" + ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
            return true;

        }

    }
}