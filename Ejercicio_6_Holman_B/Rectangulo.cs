using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Holman_B
{
    internal class Rectangulo
    {
        double lado1;
        double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }
        public Rectangulo()
        {

        }

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
    }
}
