using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol {
    class Program {
        static void Main(string[] args) {
            var random = new Random();
            var nombresEquipo = new List<string> {
                "Cuervos",
                "Tomateros",
                "Naranjeros",
                "Yaquis",
                "Mayos",
                "Equipo de Rbn",
                "Cañeros"};
            var nombresJugador = new List<string> {
                "Yavé Estrada",
                "Babe Ruth",
                "Barry Bonds",
                "Cy Young",
                "Alex Rodríguez",
                "Mike Trout",
                "El Rbn",
                "Ted Williams",
                "Albert Pujols",
                "Miguel Cabrera",
                "Jackie Robinson",
                "Roberto Clemente",
                "Ricky Henderson",
                "Bob Gibson",
                "Ichiro Suzuki",
                "Pedro Martínez",
                "Benjamín Hill"};
            var numeros = new List<string>();
            for (int i = 0; i < 100; i++) {
                numeros.Add(i.ToString());
            }

            List<Equipo> equipos = new List<Equipo>();

            for (int i = 0; i < 2; i++) {
                int index = random.Next(nombresEquipo.Count);
                equipos.Add(new Equipo(nombresEquipo[index]));
            }
            foreach (Equipo equipo in equipos) {
                for (int i = 0; i < 9; i++) {
                    int index = random.Next(nombresJugador.Count);
                    equipo.Jugadores.Add(new Jugador(nombresJugador[index]));
                    index = random.Next(numeros.Count());
                    equipo.Jugadores[i].Numero = numeros[index];
                }
            }
            equipos[0].EstadioEquipo = new Estadio();
            equipos[0].EstadioEquipo.Nombre = "Tomás Oroz Gaytán";
            foreach (Equipo equipo in equipos) {
                Console.WriteLine("\nEquipo: " + equipo.Nombre);
                foreach (Jugador jugador in equipo.Jugadores) {
                    Console.WriteLine("Jugador: " + jugador.Nombre);
                    Console.WriteLine("Numero de Jugador: " + jugador.Numero);
                }
                if (equipo.EstadioEquipo != null) {
                    Console.WriteLine("Nombre del Estadio: " + equipo.EstadioEquipo.Nombre);
                }
            }
            Console.ReadKey();
        }
    }
}
