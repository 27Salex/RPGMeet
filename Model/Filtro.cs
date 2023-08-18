using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Filtro
    {
        
        public bool QuedarLunes { get; set; }
        public bool QuedarMartes { get; set; }
        public bool QuedarMiercoles { get; set; }
        public bool QuedarJueves { get; set; }
        public bool QuedarViernes { get; set; }
        public bool QuedarSabado { get; set; }
        public bool QuedarDomingo { get; set; }
        public int MaxJugador { get; set; }
        public int MinJugador { get; set; }


        public Filtro() { }

    }
}