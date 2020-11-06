using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Clases
{
    class Circulo
    {
        private double radio;

        public Circulo()
        {
            radio = 20;
        }

        public double Area()
        {
            return 3.1416 * radio * radio;
        }

    }
}
