using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackRPG.Model
{
    using System;
    using System.Data.SqlClient;

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Username { get; set; }
        public int? FKLocalidad { get; set; }
        public int? FKFotoPerfil { get; set; }


        public Usuario() { }

        public Usuario(int idUsuario) 
        {
            IdUsuario = idUsuario;
        }

        //Constructor para crear Usuarios a partir del formulario 
        public Usuario( string email, string pass, string username, int localidad)
        {
            Email = email;
            Pass = pass;
            Username = username;
            FKLocalidad = localidad;

        }

        public override string ToString()
        {
            return "Usuario: id: " + IdUsuario + " Email: " + Email + " Pass: " + Pass + " Username: " + Username + " FKLocalidad: " + FKLocalidad + "FKFotoPerfil: " + FKFotoPerfil;
        }

    }

    

}
