using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLOS_do_while_02032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// entrada de datos
            //double nota = 0;

            //double promedio = 0, suma = 0; int cont = 0;

            //char respuesta;
            //do
            //{

            //    Console.WriteLine("Ingrese nota");

            //    nota = Convert.ToInt32(Console.ReadLine());

            //    suma = suma + nota; // acumulador

            //    cont++; // contador cont = cont+1

            //    Console.WriteLine("Desea ingresar otra nota? s =si, n = no");
            //    respuesta = Convert.ToChar(Console.ReadLine());


            //}
            //while (respuesta == 's'); 
            //promedio = suma / cont;
            //Console.WriteLine("El promedio es " + promedio)
            //Console.ReadKey();

            //FOR

            //for (int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //FOR EJEMPLO 2

            Console.WriteLine("Ingrese un numero entero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplos: ");
            //for (int i = 0; i<=100; i++)
            //{
            //    if (i % num == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            for (int i = num; i < 100 ; i = i + num)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
