using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGMeet.Model
{
    public class Filtro
    {
        public List<string> ListTematicas { get; set; }
        public bool QuedarLunes { get; set; }
        public bool QuedarMartes { get; set; }
        public bool QuedarMiercoles { get; set; }
        public bool QuedarJueves { get; set; }
        public bool QuedarViernes { get; set; }
        public bool QuedarSabado { get; set; }
        public bool QuedarDomingo { get; set; }
       
        public bool QuedarCualquierDia {
            get
            {
                return (!QuedarLunes && !QuedarMartes && !QuedarMiercoles && !QuedarJueves
                         && !QuedarViernes && !QuedarSabado && !QuedarDomingo) ||
                        (QuedarLunes && QuedarMartes && QuedarMiercoles && 
                        QuedarJueves && QuedarViernes && QuedarSabado && QuedarDomingo);
            }
        }
            
        public short MaxJugadores { get; set; }

        public Filtro(bool quedarLunes = false, bool quedarMartes = false,
            bool quedarMiercoles = false, bool quedarJueves = false, bool quedarViernes = false, 
            bool quedarSabado = false, bool quedarDomingo = false,
             short maxJugadores = 50)
        {
            QuedarLunes = quedarLunes;
            QuedarMartes = quedarMartes;
            QuedarMiercoles = quedarMiercoles;
            QuedarJueves = quedarJueves;
            QuedarViernes = quedarViernes;
            QuedarSabado = quedarSabado;
            QuedarDomingo = quedarDomingo;
            MaxJugadores= maxJugadores;
        }
        public override string ToString()
        {
            return $"QuedarLunes: {QuedarLunes}, QuedarMartes: {QuedarMartes}, " +
                   $"QuedarMiercoles: {QuedarMiercoles}, QuedarJueves: {QuedarJueves}, " +
                   $"QuedarViernes: {QuedarViernes}, QuedarSabado: {QuedarSabado}, " +
                   $"QuedarDomingo: {QuedarDomingo}, MaxJugadores: {MaxJugadores}, "+ $"tematicas = {ListTematicas}, ";
        }
    }
}