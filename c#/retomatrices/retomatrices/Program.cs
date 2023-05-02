using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace retomatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuantos equipos quiere crear");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los nombres de los equipos");
            nombresequipos(numero);
            Console.ReadKey();
        }

        public static void nombresequipos(int numero)
        {
            Random r = new Random();
            object[,] nombresequip = new object[numero,7];
            for (int e = 0; e < 7; e++)
            {
                for(int i = 0; i < numero; i++)
                {
                    if(e == 0)
                    {
                        Console.WriteLine(i + 1 + ". Equipos");
                        nombresequip[i, e] = Console.ReadLine();
                    }
                    if(e != 0)
                    {
                        int ramdom = r.Next(1, 15);
                        nombresequip[i, e] = ramdom;
                        if (ramdom < 10)
                        {
                            nombresequip[i, e] = "0" + nombresequip[i, e];
                        }
                    }
                }
            }
            Console.WriteLine("\nEquipos      |Jugados        |Ganados      |Empatados       |Perdio         |GFavor          |GContra\n");
            for (int e = 0; e < numero; e++)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(nombresequip[e, i] + "\t\t");
                }
                Console.WriteLine();
            }
        }
    }
}
