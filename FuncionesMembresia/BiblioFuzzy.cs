using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesMembresia {
    class BiblioFuzzy {
        // Atributo privado de valor.
        private double val;
        
        //Constructor vacio.
        public BiblioFuzzy() { }

        // Métodos de Membresía.
        public double TrapecioAbiertoDer(double u, double a, double b) {
            if (a <= u && u <= b) {
                val = (u - a) / (b - a);
            }
            else if (u > b) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u < a)
            }
            return val;
        }

        public double TrapecioAbiertoIzq(double u, double a, double b) {
            if (a <= u && u <= b) {
                val = (b - u) / (b - a);
            }
            else if (u < a) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u > b)
            }
            return val;
        }

        public double Triangular(double u, double a, double b, double c) {
            if (a <= u && u < b) {
                val = (u - a) / (b - a);
            }
            else if (b <= u && u <= c) {
                val = (c - u) / (c - b);
            }
            else {
                val = 0.0; // (u < a || u > c)
            }
            return val;
        }

        public double Trapezoidal(double u, double a, double b, double c, double d) {
            if (a <= u && u < b) {
                val = (u - a) / (b - a);
            }
            else if (c < u && u <= d) {
                val = (d - u) / (d - c);
            }
            else if (b <= u && u <= c) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u < a || u > d)
            }
            return val;
        }

        public double Curva_S(double u, double a, double b) {
            if (a <= u && u <= b) {
                val = (1 + Math.Cos(((u - b) / (b - a)) * Math.PI)) / 2.0;
            }
            else if (u > b) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u < a)
            }
            return val;
        }

        public double Curva_Z(double u, double a, double b) {
            if (a <= u && u <= b) {
                val = (1 + Math.Cos(((u - a) / (b - a)) * Math.PI)) / 2.0;
            }
            else if (u < a) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u > b)
            }
            return val;
        }

        public double TriangularSuave(double u, double a, double b, double c) {
            if (a <= u && u < b) {
                val = (1 + Math.Cos(((u - b) / (b - a)) * Math.PI)) / 2.0;
            }
            else if (b <= u && u <= c) {
                val = (1 + Math.Cos(((b - u) / (c - b)) * Math.PI)) / 2.0;
            }
            else {
                val = 0.0; // (u < a || u > c)
            }
            return val;
        }

        public double TrapezoidalSuave(double u, double a, double b, double c, double d) {
            if (a <= u && u < b) {
                val = (1 + Math.Cos(((u - b) / (b - a)) * Math.PI)) / 2.0;
            }
            else if (c < u && u <= d) {
                val = (1 + Math.Cos(((c - u) / (d - c)) * Math.PI)) / 2.0;
            }
            else if (b <= u && u <= c) {
                val = 1.0;
            }
            else {
                val = 0.0; // (u < a || u > d)
            }
            return val;
        }

        // Operadores Lógicos Fuzzy.
        public double CompAND(double ma_u, double mb_u) {
            return Math.Min(ma_u, mb_u);
        }

        public double CompOR(double ma_u, double mb_u) {
            return Math.Max(ma_u, mb_u);
        }

        public double Niega(double ma_u) {
            return 1.0 - ma_u;
        }

        // Implicación Fuzzy.
        public double ImplicaZadeh(double ma_x, double mb_y) {
            return Math.Max(Math.Min(ma_x, mb_y), Niega(ma_x));
        }

        public double ImplicaMamdani(double ma_x, double mb_y) {
            return Math.Min(ma_x, mb_y);
        }

        public double ImplicaGodel(double ma_x, double mb_y) {
            return val = (ma_x <= mb_y) ? val = 1 : val = mb_y;
        }
    }
}