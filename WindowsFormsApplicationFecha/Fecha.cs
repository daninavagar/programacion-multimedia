using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationFecha
{
    class Fecha
    {
        public int dia, mes, anio;

        public Fecha()
        {
            this.dia = 1;
            this.mes = 1;
            this.anio = 1900;
        }

        public Fecha(int dia)
        {
            this.dia = dia;
            this.mes = DateTime.Today.Month;
            this.anio = DateTime.Today.Year;
        }

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public int CambiarDia(int dia)
        {
            return dia;
        }

        public int CambiarMes(int mes)
        {
            return mes;
        }

        public int CambiarAño(int año)
        {
            return año;
        }

        public bool EsBisiesto()
        {

            if (this.anio % 4 == 0 && this.anio % 400 != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Fecha DiaSiguiente()
        {
            dia++;
            if (dia == 32 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10))
            {
                dia = 1;
                mes++;
            } else if (dia == 31 && (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11))
            {
                dia = 1;
                mes++;
            } else if (dia == 31 && mes == 12)
            {
                dia = 1;
                mes = 1;
                anio++;
            }
            return this;
        }
    }
}
