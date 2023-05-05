using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Holman_B
{
    internal class Circulo
    {
        double radio;

        public Circulo(double radio)
        {
            this.Radio = radio;
        }
        public Circulo()
        {

        }

        public double Radio { get => radio; set => radio = value; }
    }
}
