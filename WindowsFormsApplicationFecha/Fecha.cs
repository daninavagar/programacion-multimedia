using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationFecha
{
    class Fecha
    {
        private int dia, mes, anio;

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

        public void escribir(string hora)
        {
            hora = Convert.ToString(dia, mes);

        }

        public int CambiarDia()
        {
            this.dia = 15;
            return dia;
        }

        public void CambiarMes()
        {
            this.mes = 1;
        }

        public void CambiarAño()
        {
            this.anio = 2000;
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

        public void DiaSiguiente()
        {
            this.dia++;
            if (this.dia == 31 && (this.mes == 1 || this.mes == 3 || this.mes == 5 || this.mes == 7 || this.mes == 8 || this.mes == 10))
            {
                this.dia = 1;
                this.mes++;
            } else if (this.dia == 30 && (this.mes == 2 || this.mes == 4 || this.mes == 6 || this.mes == 9 || this.mes == 11))
            {
                this.dia = 1;
                this.mes++;
            } else if (this.dia == 31 && this.mes == 12)
            {
                this.dia = 1;
                this.mes = 1;
                this.anio++;
            }
        }
    }
}
