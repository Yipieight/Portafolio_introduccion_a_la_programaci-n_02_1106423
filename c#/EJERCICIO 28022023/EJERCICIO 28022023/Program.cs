using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_28022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO HOJA EN CLASE
            //EJERCICIO NO.1

            //int limite = 1;
            //int numero = 1;

            //Console.WriteLine("Ingrese un numero positivo");
            //numero = Convert.ToInt32(Console.ReadLine());

            //while (limite > 0 && limite <= numero)
            //{
            //    Console.WriteLine(limite);
            //    limite++;
            //}
            //Console.ReadKey();

            //EJERCICIO 2

            //int numero = 0, numero2 = 0;
            //int promedio = 0;
            //char ns = 's';

            //while (ns == 's')
            //{
            //    Console.WriteLine("Ingrese un numero positivo entero");
            //    numero2 = Convert.ToInt32(Console.ReadLine());
            //    numero = numero2 + numero;
            //    promedio++;
            //    Console.WriteLine("Desea continuar? s = si , n = no");
            //    ns = Convert.ToChar(Console.ReadLine());

            //    if (ns == 'n')
            //    {
            //        promedio = numero / promedio;
            //        Console.WriteLine("La suma de los numeros es " + numero);
            //        Console.WriteLine("El promedio de los numero es " + promedio);
            //    }
            //}

            Console.ReadKey();

            //EJERCICIO 3

            double total;
            double producto = 0;
            int cantidad;

            Console.WriteLine("Ingrese el valor del producto");
            producto = Convert.ToDouble(Console.ReadLine());

            while (producto >= 0)
            {
                Console.WriteLine("ingrese una cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());

                total = producto * cantidad;

                Console.WriteLine("El total a pagar es " + total);
                Console.WriteLine("La cantidad es " + cantidad);

                Console.WriteLine("Ingrese el valor del producto");
                producto = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("");
            Console.WriteLine("¡Gracias por usar nuestra app!");
            Console.ReadKey();






        }
    }
}
