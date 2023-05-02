using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos_28022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO NUMERO 1

            //string nit;
            //int codigo;
            //char respuesta = 's'; //s = si , n = no

            //Console.WriteLine("Ingrese nit del cliente");
            //nit = Console.ReadLine();

            //while (respuesta == 's')
            //{
            //    Console.WriteLine("Ingresec¿ codigo del producto");
            //    codigo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Desea ingresar otro producto? s = si, n = no ");
            //    respuesta = Convert.ToChar(Console.ReadLine());
            //}
            //Console.WriteLine("Gracias por su compra");
            //Console.ReadKey();

            //EJEMPLO NUMERO 2

            int n = 50;
            while (n >= 50 && n < 100)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

            //EJERCICIO HOJA EN CLASE

            int limite = 1;
            int numero = 1;

            Console.WriteLine("Ingrese un numero positivo");
            numero = Convert.ToInt32(Console.ReadLine());

            while (limite > 0 && limite <= numero)
            {
                Console.WriteLine(limite);
                limite++;
            }
            Console.ReadKey();
        }
    }
}
