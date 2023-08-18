using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }

        public Localidad() { }

        public Localidad(int idLocalidad)
        {
            IdLocalidad = idLocalidad;
        }

        public Localidad(int idLocalidad, string nombreLocalidad)
        {
            IdLocalidad = idLocalidad;
            NombreLocalidad = nombreLocalidad;
        }
    }
}