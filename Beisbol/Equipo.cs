using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol {
    class Equipo {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo() {
            Nombre = "Nuevo Equipo";
            Ciudad = "Ciudad de Origen";
            Entrenador = "Nombre de Entrenador";
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) {
            Nombre = nombre;
            Ciudad = "Ciudad de Origen";
            Entrenador = "Nombre de Entrenador";
            Jugadores = new List<Jugador>();
        }
    }
}
