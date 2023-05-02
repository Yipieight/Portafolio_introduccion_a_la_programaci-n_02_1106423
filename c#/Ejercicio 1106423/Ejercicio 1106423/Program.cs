using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1106423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double altura;
            string categoria;

            //Seleccionar un valor a la categoria 
            Console.WriteLine("Ingrese la categoria");
            categoria = Console.ReadLine();

            //Condicional para ver el tipo de categoria
            if(categoria == "B")
            {
                Console.WriteLine("Ingre se una altura (metros)");
                altura = Convert.ToDouble(Console.ReadLine());

                //condicional para uso de juegos
                if (altura > 1.5)
                {
                    Console.WriteLine("Si puede subir a un juego");
                }
                else
                {
                    Console.WriteLine("No puedo subir al juego");
                }//endif de altura
            }//endif de categoria


            Console.ReadKey();
        }
    }
}
