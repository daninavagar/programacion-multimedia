using System;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comedor comedor;
            int opcion = 0; //, nMesa, nPersonas;
            // float importe;
            // DateTime horaReserva;

            bool exit = false;

            do
            {
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("| RESTAURANTE               |");
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("|  1. Ocupar Mesa.          |");
                    Console.WriteLine("|  2. Apuntar Mesa.         |");
                    Console.WriteLine("|  3. Cobrar Mesa.          |");
                    Console.WriteLine("|  4. Reservar Mesa.        |");
                    Console.WriteLine("|  5. Anular reserva Mesa.  |");
                    Console.WriteLine("|  6. Mostrar Caja.         |");
                    Console.WriteLine("|  7. Salir.                |");
                    Console.WriteLine("+---------------------------+");
                    Console.WriteLine("Introduzca Opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola");
                        break;
                    case 2:
                        Console.WriteLine("Hola");
                        break;
                    case 3:
                        Console.WriteLine("Hola");
                        break;
                    case 4:
                        Console.WriteLine("Hola");
                        break;
                    case 5:
                        Console.WriteLine("Hola");
                        break;
                    case 6:
                        Console.WriteLine("Hola");
                        break;
                    case 7:
                        Console.WriteLine("Adios");
                        exit = true;
                        break;
                }

            } while (!exit);
            Environment.Exit(0); 
        }
    }
}
