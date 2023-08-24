using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    internal class Local
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public string Direccion { get; set; }
        public string SitioWeb { get; set; }
        public string Telefono { get; set; }

        public Local(int id,string nombre, string descripcion, string urlImagen = "", string direccion = "", string sitioWeb = "", string telefono = "123 45 67 89")
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            UrlImagen = urlImagen;
            Direccion = direccion;
            SitioWeb = sitioWeb;
            Telefono = telefono;
        }
    }

}