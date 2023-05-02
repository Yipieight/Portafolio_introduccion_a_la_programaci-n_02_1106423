using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones_pseudocodigo
{
    internal class Mate
    {
        //funcion
        public double alCuadrado()
        {
            double num, val;
            Console.WriteLine("Ingrese numero a elevar");
            num = Convert.ToInt32(Console.ReadLine());
            val = num * num; 
            return val;
        }

        //procedimiento
        public void mostrarPar()
        {
            double num;
            Console.WriteLine("Ingrese un número a evaluar");
            num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero " + num + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + num + " es impar");
            }
        }
        static void Main(string[] args)
        {
            Mate lamate = new Mate();
            double res = lamate.alCuadrado();
            Console.WriteLine("Resultado " + res);
            lamate.mostrarPar();
            Console.ReadLine();
        }
    }
}
