using System;
using Arrays.Models;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas mesas quieres en el arreglo?");
            int numero = int.Parse(Console.ReadLine());
            //This is the way for declare arrays
            Table[] tables = new Table[numero];
            //Auxiliar Varable
            int i=0;
            do
            {
                //Inicializacion de Objeto Individual
                tables[i] = new Table();
                Console.WriteLine("Cual es la marca de la mesa "+(i+1)+"?");
                tables[i].Brand=Console.ReadLine();
                Console.WriteLine("Cual es el color de la mesa " + (i + 1) + "?");
                tables[i].Color = Console.ReadLine();
                Console.WriteLine("Cual es el material de la mesa " + (i + 1) + "?");
                tables[i].Material= Console.ReadLine();
                Console.WriteLine("Cual es el numero de soportes de la mesa " + (i + 1) + "?");
                tables[i].NumberSupports = byte.Parse(Console.ReadLine());
                Console.WriteLine("Cual es el tamaño de la mesa " + (i + 1) + "?");
                int aSize = 0;
                foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
                {
                    Console.WriteLine(aSize + ") " + size.ToString());
                    aSize++;
                }
                tables[i].Size = (Size)(int.Parse(Console.ReadLine()));
                i=i+1;

            } while (i < numero);
            Console.WriteLine("Fin de programa!");

        }
    }
}
