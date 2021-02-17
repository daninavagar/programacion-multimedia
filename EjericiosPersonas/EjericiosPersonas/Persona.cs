using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiosPersonas
{
    class Persona
    {
        private string nombre, direccion, DNI;
        private int telefono;
        private Fecha fechaNaci;
        private Fecha fechaAdmi;

        // CONSTRUCTORES
        public Persona()
        {
            nombre = "Jose Luis";
            direccion = "Visual Studio";
            DNI = "12412P";
            fechaNaci = new EjericiosPersonas.Fecha();
            fechaAdmi = new EjericiosPersonas.Fecha();
            telefono = 1234566789;
        }

        public Persona(string nombre, string DNI, Fecha fechaNaci)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.fechaNaci = new Fecha();
        }
        // BUENOS CONSTRUCTORES
        public Persona(string DNI,string nombre, int diaN, int mesN, int anioN)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.fechaNaci = new Fecha(diaN, mesN, anioN);
            this.fechaAdmi = new Fecha();
            
        }

        public Persona(string DNI, int diaA, string nombre, int mesA, int anioA)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.fechaNaci = new Fecha();
            this.fechaAdmi = new Fecha(diaA, mesA, anioA);
        }
        // FIN
        public Persona(string DNI, Fecha fechaAdmi, string nombre)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.fechaAdmi = new Fecha();
        }
        public Persona(string nombre, string direccion, string DNI, Fecha fechaNaci, Fecha fechaAdmi, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.DNI = DNI;
            this.fechaNaci = fechaNaci;
            this.fechaAdmi = fechaAdmi;
            this.telefono = telefono;
        }

        // FUNCIONES 
        public string EscribirFormato(string formato)
        {
            string forma = "";
            string Naci = fechaNaci.Escribir(formato);
            string Admi = fechaAdmi.Escribir(formato);
            if (formato == "corto")
            {
                forma = "Nombre -> " + nombre + "\nDireccion -> " + direccion + "\nDNI -> " + DNI + "\nFecha Nacimiento -> " + Naci + "\nFecha Admision -> " + Admi
                    + "\nTelefono -> " + telefono;
            }
            else
            {
                forma = "Nombre -> " + nombre + "\nDireccion -> " + direccion + "\nDNI -> " + DNI + "\nFecha Nacimiento -> " + Naci + "\nFecha Admision -> " + Admi
                    + "\nTelefono -> " + telefono;
            }
            return forma;
        }

        public string CambiarDNI()
        {
            return DNI;
        }

        public string CambiarNombre()
        {
            return nombre;
        }

        public void CambiarNacimiento()
        {

            fechaNaci.CambiarDia();
            fechaNaci.CambiarMes();
            fechaNaci.CambiarAño();

        }

    }
}
