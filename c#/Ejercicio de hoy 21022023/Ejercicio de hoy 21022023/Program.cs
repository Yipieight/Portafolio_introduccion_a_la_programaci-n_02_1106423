using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_hoy_21022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, impuestos;

            Console.WriteLine("Ingrese un sueldo");
            sueldo = Convert.ToDouble(Console.ReadLine());

            if(sueldo >= 3000)
            {
                Console.WriteLine("El sueldo que ingreso debe abonar impuestos.");
                impuestos = sueldo * 0.05;
                Console.WriteLine("La cantadidad de impuestos de pagar es Q" + impuestos);
            }

            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }

            Console.ReadKey(); 

        }
    }
}
