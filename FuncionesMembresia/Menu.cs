using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesMembresia {
    class Menu {
        // Constructor.
        public Menu() {
            Interfaz();
        }

        // Interfaz de la consola.
        public void Interfaz() {
            BiblioFuzzy b = new BiblioFuzzy();
            int u = 0, li = 0, ld = 30, lsi = 10, lsd = 20, lc = 15;

            Console.Title = "BiblioFuzzy";
            Console.WriteLine("********** Trapecio Abierto por la Izquierda **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", TAI(u): " + b.TrapecioAbiertoIzq(u, li + 10, ld - 10));
            }

            Console.WriteLine("\n********** Trapecio Abierto por la Derecha **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", TAD(u): " + b.TrapecioAbiertoDer(u, li + 10, ld - 10));
            }

            Console.WriteLine("\n********** Triangular **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", Triang(u): " + b.Triangular(u, li + 10, lc, ld - 10));
            }

            Console.WriteLine("\n********** Trapezoidal **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", Trap(u): " + b.Trapezoidal(u, li + 5, lsi, lsd, ld - 5));
            }

            Console.WriteLine("\n********** Curva Z **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", CZ(u): " + b.Curva_Z(u, li + 5, ld - 5));
            }

            Console.WriteLine("\n********** Curva S **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", CS(u): " + b.Curva_S(u, li + 5, ld - 5));
            }

            Console.WriteLine("\n********** Triangular Suave **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", TS(u): " + b.TriangularSuave(u, li + 5, lc, ld - 5));
            }

            Console.WriteLine("\n********** Trapezoidal Suave **********");
            for (u = li; u < ld; u++) {
                Console.WriteLine("Para u=" + u + ", TrapS(u): " + b.TrapezoidalSuave(u, li + 5, lsi, lsd, ld - 5));
            }
            PresioneSalir();
        }

        // Mensaje final para terminar la ejecución.
        public void PresioneSalir() {
            Console.Write("\nPresione para salir...");
            Console.ReadKey();
        }
    }
}