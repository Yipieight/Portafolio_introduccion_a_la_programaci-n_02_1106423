using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1

            //int num = 0;
            //long suma = 0;
            //Random r = new Random();
            //for (int i = 1; i < 100; i++)
            //{
            //    num = r.Next();
            //    suma = suma + num;
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("La suma total es: " + suma);
            //Console.ReadKey();

            //EJERCICIO 2

            double estatura;
            double suma = 0;
            int promedio = 0;
            char sino = 's';

            do
            {

                Console.WriteLine("Ingrese una estatura (cm)+");
                estatura = Convert.ToDouble(Console.ReadLine());
                suma = suma + estatura;
                promedio++;
                Console.WriteLine("¿Quiere seguir agregando? s = si, n = no");
                sino = Convert.ToChar(Console.ReadLine());

            }
            while (sino == 's');

            Console.WriteLine("El promedio de las estaturas es: " + (suma / promedio) + " cm");

            Console.ReadKey();
        }
    }
}
