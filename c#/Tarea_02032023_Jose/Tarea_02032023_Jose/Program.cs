using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_02032023_Jose
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREA DE LA SEMANA 7 JOSE ANDRES GARCIA ELIAS 1106423
            //EJERCICIO 1

            //int limit = 1;
            //int contar = 0;
            //double numero = 0;
            //double sumar = 0;
            //double promedio = 0;

            //do
            //{
            //    Console.WriteLine("(" + limit + ")" + "Ingrese una nota");
            //    try
            //    {
            //        numero = double.Parse(Console.ReadLine());

            //        if (numero > 0)
            //        {
            //            sumar = sumar + numero;
            //            contar++;
            //            limit++;
            //            Console.Clear();
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Debe ingresar un numero > 0");
            //        }
            //    }
            //    catch
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Debe ingresar un numero...");
            //    }

            //}
            //while (limit != 11);
            //promedio = sumar / contar;
            //Console.WriteLine("El promedio total es " + promedio);

            //Console.ReadKey();

            //EJERCICIO 2
            int num = 0;
            int totrep = 0, rep1 = 0, conrep = 0;
            // (abre) La variable "limite" es el numero que indica cuantos numeros primos debe colocar
            int limite = 12;
            // (cierra)
            int numeracion = 0;

            for (int i = 0; i >= 0 && i < limite; i++)
            {
                bool total = false;
                while (total != true)
                {
                    while (totrep != i)
                    {
                        rep1++;
                        totrep = rep1;
                        num = i % rep1;
                        if (num == 0)
                        {
                            conrep++;
                        }
                    }
                    totrep = 0;
                    rep1 = 0;

                    //If y Else: evalua cual es primo y cual no, if lo muestra en pantall y else lo omite
                    if (conrep == 2)
                    {
                        numeracion++;
                        Console.WriteLine("(" + numeracion + ") " + "Primo = " + i);
                        conrep = 0;
                        total = true;
                    }
                    else if (conrep > 2 || conrep <= 1)
                    {
                        conrep = 0;
                        total = true;
                        limite++;

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
