using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{

    /*
    CREATE TABLE Tienda (
    IdTienda INT IDENTITY(1,1) PRIMARY KEY,
    NombreTienda NVARCHAR(50) NOT NULL,
    Direccion NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200),
    CodigoPostal VARCHAR(5) NOT NULL,
    Web NVARCHAR(MAX),
    Telefono INT,
    UrlImg NVARCHAR (MAX),
);
     */
    public class Tienda
    {
        public int IdTienda { get; set; }
        public string Nombre { get; set; }
        public string Direccion {get; set;}
        public string Descripcion { get; set; }
        public string CodigoPostal { get; set; }
        public string Web { get; set; }
        public int Telefono { get; set; }
        public string ImgUrl { get; set; }



        public Tienda() { }

        public Tienda(int idTienda)
        {
            IdTienda = idTienda;
        }

        public Tienda(int id, string nombre, string descripcion, string urlImagen = "", string direccion = "", string sitioWeb = "", int telefono = 0, string codigoPostal = "")
        {
            IdTienda = id;
            Nombre = nombre;
            Descripcion = descripcion;
            ImgUrl = urlImagen;
            Direccion = direccion;
            Web = sitioWeb;
            Telefono = telefono;
            CodigoPostal = codigoPostal;
        }
        public override string ToString()
        {
            return "Tienda: id: " + IdTienda + " NombreTienda: " + Nombre + " Direccion: " + Direccion + "CodigoPostal: " + CodigoPostal;
        }
    }

}