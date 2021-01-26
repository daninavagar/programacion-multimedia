using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Mesa
    {
        private int numeroMax, numeroActual 
                    , estado; // 0 -> Vacio 1 -> Ocupado 2-> Reservado
        private float importe;
        private DateTime hora;


        public Mesa()
        {
            numeroMax = 4;
            numeroActual = 0;
            estado = 0;
            importe = 0;
            hora = new DateTime(1, 1, 1, 10, 30, 00);
        }

        public void Ocupar()
        {

        }

    }
}
