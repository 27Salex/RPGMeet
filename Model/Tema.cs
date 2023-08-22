using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Tema
    {
        public int IdTema { get; set; }
        public string NombreTema { get; set; }

        public Tema() { }
        public Tema(int idTema)
        {
            IdTema = idTema;
        }
        public Tema(int idTema, string nombreTema)
        {
            IdTema = idTema;
            NombreTema = nombreTema;
        }
    }
}