using RPGMeet.Model;
using System;

namespace RPGMeet.Models
{
    public class Grupo
    {

        public int IdGrupo { get; set; }
        public string TituloParitda { get; set; }

        public string Descripcion { get; set; }

        public short EstadoGrupo { get; set; }  // FINALIZADA -1  BUSCANDO 0 START 1
        public short MaxJugadores { get; set; }
        
        public bool EsOnline { get; set; }  // NO IMPLEMENTADO mirar si implementarlo ya que todas seran fisicas
        public bool QuedarLunes { get; set; }
        public bool QuedarMartes { get; set; }
        public bool QuedarMiercoles { get; set; }
        public bool QuedarJueves { get; set; }
        public bool QuedarViernes { get; set; }
        public bool QuedarSabado { get; set; }
        public bool QuedarDomingo { get; set; }
        public int FKJuego { get; set; }
        public int FKTemaPrincipal { get; set; }
        public int FKTemaSecundario { get; set; }
        public int FKGameMaster { get; set; }
        public int FKLocalidad { get; set; }

        //AL IGUAL QUE USUARIO CREAR FKJuego, FKTemaPrincipal, FKTemaSecundario
        public Usuario Creador { get; set; }

        public Grupo() { }

        /// <summary>
        /// Constructor para peticion de allPartidas o PartidasFiltro
        /// </summary>
        /// <param name="IdGrupo"></param>
        /// <param name="TituloParitda"></param>
        /// <param name="MaxJugadores"></param>
        /// <param name="QuedarLunes"></param>
        /// <param name="QuedarMartes"></param>
        /// <param name="QuedarMiercoles"></param>
        /// <param name="QuedarJueves"></param>
        /// <param name="QuedarViernes"></param>
        /// <param name="QuedarSabado"></param>
        /// <param name="QuedarDomingo"></param>
        /// <param name="FKJuego"></param>
        /// <param name="FKTemaPrincipal"></param>
        /// <param name="FKTemaSecundario"></param>
        /// <param name="FKGameMaster"></param>
        /// <param name="creador"></param>
        public Grupo(
            int IdGrupo,
            string TituloParitda,
            string Descripcion,
            short MaxJugadores,
            bool QuedarLunes,
            bool QuedarMartes,
            bool QuedarMiercoles,
            bool QuedarJueves,
            bool QuedarViernes,
            bool QuedarSabado,
            bool QuedarDomingo,
            int FKJuego,
            int FKTemaPrincipal,
            int FKTemaSecundario,
            int FKGameMaster,
            Usuario creador)
        {
            this.IdGrupo = IdGrupo;
            this.TituloParitda = TituloParitda;
            this.Descripcion = Descripcion;
            this.MaxJugadores = MaxJugadores;
            this.QuedarLunes = QuedarLunes;
            this.QuedarMartes = QuedarMartes;
            this.QuedarMiercoles = QuedarMiercoles;
            this.QuedarJueves = QuedarJueves;
            this.QuedarViernes = QuedarViernes;
            this.QuedarSabado = QuedarSabado;
            this.QuedarDomingo = QuedarDomingo;
            this.FKJuego = FKJuego;
            this.FKTemaPrincipal = FKTemaPrincipal;
            this.FKTemaSecundario = FKTemaSecundario;
            this.FKGameMaster = FKGameMaster;

        }

        public Grupo(
            
            string TituloParitda,
            string Descripcion,
            short MaxJugadores,
            bool QuedarLunes,
            bool QuedarMartes,
            bool QuedarMiercoles,
            bool QuedarJueves,
            bool QuedarViernes,
            bool QuedarSabado,
            bool QuedarDomingo,
            int FKJuego,
            int FKTemaPrincipal,
            int FKTemaSecundario,
            int FKGameMaster)
        {
            this.TituloParitda = TituloParitda;
            this.Descripcion = Descripcion;
            this.MaxJugadores = MaxJugadores;
            this.QuedarLunes = QuedarLunes;
            this.QuedarMartes = QuedarMartes;
            this.QuedarMiercoles = QuedarMiercoles;
            this.QuedarJueves = QuedarJueves;
            this.QuedarViernes = QuedarViernes;
            this.QuedarSabado = QuedarSabado;
            this.QuedarDomingo = QuedarDomingo;
            this.FKJuego = FKJuego;
            this.FKTemaPrincipal = FKTemaPrincipal;
            this.FKTemaSecundario = FKTemaSecundario;
            this.FKGameMaster = FKGameMaster;
        }

    }
}
