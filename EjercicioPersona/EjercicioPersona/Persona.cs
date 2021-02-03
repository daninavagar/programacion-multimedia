using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    class Persona
    {
        public string nombre, direccion, DNI;
        public int diaNaci, mesNaci, anioNaci, diaAdmi, mesAdmi, anioAdmi, telefono;
        

        public Persona()
        {
            this.nombre = "Diego";
            this.direccion = "calle Sol";
            this.DNI = "07823456P";
            this.diaNaci = 1;
            this.mesNaci = 6;
            this.anioNaci = 2002;
            this.diaAdmi = 14;
            this.mesAdmi = 2;
            this.anioAdmi = 2014;
            this.telefono = 123456789;
        }

        public Persona(string nombre, string DNI, int diaNaci, int mesNaci, int anioNaci)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.diaNaci = diaNaci;
            this.mesNaci = mesNaci;
            this.anioNaci = anioNaci;
        }
     
        public Persona(int diaAdmi, int mesAdmi, int anioAdmi, string nombre, string DNI)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.diaAdmi = diaAdmi;
            this.mesAdmi = mesAdmi;
            this.anioAdmi = anioAdmi;
        }
        public Persona(string nombre, string direccion, string DNI, int diaNaci, int mesNaci, int anioNaci, int diaAdmi, int mesAdmi, int anioAdmi, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.DNI = DNI;
            this.diaNaci = diaNaci;
            this.mesNaci = mesNaci;
            this.anioNaci = anioNaci;
            this.diaAdmi = diaAdmi;
            this.mesAdmi = mesAdmi;
            this.anioAdmi = anioAdmi;
            this.telefono = telefono;
        }

        public void Escribir()
        {
            string formato = "";

            if (formato == "corto")
            {
                
            }
        }

       public string CambiarDNI(string DNI)
        {
            return DNI;
        }

        public string CambiarNombre(string nombre)
        {
            return nombre;
        }

        public int CambiarDia(int diaNaci)
        {
            return diaNaci;
        }

        public int CambiarMes(int mesNaci)
        {
            return mesNaci;
        }

        public int CambiarAño(int anioNaci)
        {
            return anioNaci;
        }

    }
}
