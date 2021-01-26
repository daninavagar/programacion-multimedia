using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasExamen
{
    class Program
    {
        public static string invertir(string nombre)
        {
            string invertido = "";
            for (int i=nombre.Length-1; i >= 0; i--)
            {
                invertido += nombre[i];
            }

            return invertido;
        }


        public static void suma(int n1, int n2, ref int result)
        {
            result = n1 + n2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            string prueba;
            // a. Iniciarlziar la cadena a vacío
            prueba = null;
            //b. Rellenar una cadena con una palabra.
            prueba = "victor";
            //c. Escribir la cadena por pantalla.
            Console.WriteLine("La cadena es : " + prueba);
            //d. Invertir la cadena.
            string nombre;
            nombre = prueba;
            string invertido = invertir(nombre);
            Console.WriteLine("La cadena invertida es: " + invertido);
            //e. Convertir la cadena a Mayusculas.
            string mayus = prueba.ToUpper();
            Console.WriteLine("La cadena en mayus: " + mayus);
            //f. Convertir la cadena en Minusculas.
            string minus = prueba.ToLower();
            Console.WriteLine("La cadena en minus: " + minus);
            //g. Rotar un carácter a la derecha de la cadena. El primero al segundo, este al tercero y el ultimo al primero.
            //g.Rotar un carácter a la izquierda de la cadena.El ultimo al penultimo, el penultimo al antepenultimo.



            Console.WriteLine("====================================================");
            int n1 = 5, n2 = 10, result = 0;
            suma(n1, n2, ref result);
            
            Console.ReadKey();
        }
    }
}
