using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiosPersonas
{
    class Fecha
    {
        private int dia, mes, anio;

        public Fecha()
        {
            this.dia = 1;
            this.mes = 5;
            this.anio = 2005;
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

        public string Escribir(string formato)
        {
            string forma;
            if (formato.ToLower() == "corto")
            {
                forma = dia.ToString() + "/" + mes.ToString() + "/" + anio.ToString();
            }
            else
            {
                forma = "Dia " + dia.ToString() + " del mes " + mes.ToString() + " del año " + anio.ToString();
            }
            return forma;
        }

        public int CambiarDia()
        {
            return dia;
        }

        public int CambiarMes()
        {
            return mes;
        }
        public int CambiarAño()
        {
            return anio;
        }

        public bool EsBisiesto()
        {
            if (anio % 4 == 0 && anio % 400 != 0)
            {
                return true;
            }
            else
                return false;

        }

        public Fecha DiaSiguiente()
        {
            dia++;
            if (dia == 32 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10))
            {
                dia = 1;
                mes++;
            }
            else if (dia == 31 && (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11))
            {
                dia = 1;
                mes++;
            }
            else if (dia == 32 && mes == 12)
            {
                dia = 1;
                mes = 1;
                anio++;
            }

            return this;
        }

    }
}
