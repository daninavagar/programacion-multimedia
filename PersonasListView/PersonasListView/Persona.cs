using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasListView
{
    class Persona
    {
        private string nombre, direccion, dni;
        private int telefono;
        private Fecha fechaNaci, fechaAdmi;


        // PRIMER CONSTRUCTOR
        public Persona()
        {
            nombre = "Daniel";
            direccion = "Calle Programación";
            dni = "111P";
            telefono = 123456;
            fechaNaci = new Fecha();
            fechaAdmi = new Fecha();
        }


        // SEGUNDO CONSTRUCTOR
        public Persona(string Nombre, string DNI, int diaN, int mesN, int anioN)
        {
            nombre = Nombre;      
            dni = DNI;
            fechaNaci = new PersonasListView.Fecha(diaN, mesN, anioN);
            fechaAdmi = new Fecha();
        }


        // TERCER CONSTRUCTOR
        public Persona(int diaA, string DNI, string Nombre, int mesA, int anioA)
        {
            nombre = Nombre;  
            dni = DNI;       
            fechaNaci = new Fecha();
            fechaAdmi = new PersonasListView.Fecha(diaA, mesA, anioA);
        }

        // CUARTO CONSTRUCTOR
         public Persona(string Nombre, string Direccion, string DNI, int Telefono,
                        int DiaN, int MesN, int AnioN, int DiaA, int MesA, int AnioA)
        {
            nombre = Nombre;
            direccion = Direccion;
            dni = DNI;
            telefono = Telefono;
            fechaNaci = new Fecha(DiaN, MesN, AnioN);
            fechaAdmi = new Fecha(DiaA, MesA, AnioA);
        }


        // FUNCIONES
        public string EscribirFormato(string formato)
        {
            string forma;
            string Naci = fechaNaci.Escribir(formato);
            string Admi = fechaAdmi.Escribir(formato);

            if (formato.ToLower() == "corto")
                forma = "Nombre -> " + nombre + "\nDireccion -> " + direccion + "\nDNI -> " + dni 
                    + "\nFecha Nacimiento -> " + Naci + "\nFecha Admision -> " + Admi+ "\nTelefono -> " + telefono;
            else
                forma = "Nombre -> " + nombre + "\nDireccion -> " + direccion + "\nDNI -> " + dni
                    + "\nFecha Nacimiento -> " + Naci + "\nFecha Admision -> " + Admi + "\nTelefono -> " + telefono;

            return forma;
        }

        public string CambiarDNI()
        {
            return dni;
        }

        public string CambiarNombre()
        {
            return nombre;
        }

        public void CambiarNacimiento()
        {

            fechaNaci.CambiarDia();
            fechaNaci.CambiarMes();
            fechaNaci.CambiarAnio();

        }


    }
}
