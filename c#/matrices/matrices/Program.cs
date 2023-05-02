using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    internal class Ejemplos
    {
        static void Main(string[] args)
        {
            ejemplo2();
        }

        public static void ejemplo1()
        {
            double[] notas = new double[3];
            string[] nombres = new string[3];
            double[] paraganar = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota");
                notas[i] = double.Parse(Console.ReadLine());
                //proceso de para ganar



                if (notas[i] >= 65)
                {
                    Console.WriteLine($"{nombres[i]} gano la clase");
                }
                else
                {
                    Console.WriteLine($"{nombres[i]} perdio la clase");
                }

                if (notas[i] < 65)
                {
                    paraganar[i] = 65 - notas[i];
                }
                else
                {
                    paraganar[i] = 0;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" A {nombres[i]} B le falta para ganar {paraganar[i]}");
            }
            Console.ReadKey();
        }

        public static void ejemplo2()
        {
            // filas = estudiantes, columnas = asignatura
            Random r = new Random();
            //notas de estudiantes
            double[,] notas = new double[5, 6];
            //nombre de estudiantes
            string[] nombres = new string[5];

            //llenar 
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Ingrese nombre");
                nombres[f] = Console.ReadLine();
                for (int c = 0; c < 6; c++)
                {
                    notas[f,c] = r.Next(1, 100);
                }
            }

            //Promedio por estudiante
            double[] promedioest = new double[5];
            for (int f = 0;f<5;f++)
            {
                double promedio = 0;
                for (int c = 0; c<6; c++)
                {
                    promedio = promedio + notas[f, c];
                }
                promedio = promedio / 6;
                promedioest[f] = promedio;
            }

            for (int f = 0; f < 5; f++)
            {
                Console.Write(nombres[f] + " ");

                for (int c = 0; c < 6; c++)
                {
                    Console.Write(notas[f,c]+" - ");
                }
                Console.WriteLine("Promedio: " + promedioest[f].ToString("F2"));
                Console.WriteLine();
            }

            double[] promedioclase = new double[6];
            
            for (int f = 0; f < 6; f++)
            {
                double promedio = 0;

                for (int i = 0; i < 5; i++)
                {
                    promedio = promedio + notas[i,f];
                }
                promedioclase[f] = promedio/5;
                Console.Write("Clase: " + promedioclase[f]+"\t");
            }

            Console.ReadKey();

        }
    }
}
