using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace vectores
{
    internal class vectores
    {
        static void Main(string[] args)
        {
            vectores.ejemplo2();            
        }

        public static void ejemplo1()
        {
            double[] nota = new double[10];

            for (int i = 0; i < 10; i++)
            {
                nota[i] = 0;
            }

            nota[4] = 65;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(i + " > " + nota[i]);
            }
            Console.ReadKey();
        }
        
        public static void ejemplo2()
        {
            int[] numeros = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0;

            for(int i = 0; i < 10; i++)
            {
                suma = suma + numeros[i];
            }
            Console.ReadKey();
        }

        public static void ejemplo3()
        {
            int[] numeros = new int[50];
            Random r = new Random(); 
            for (int i = 0; i < 50; i++)
            {
                numeros[i] = r.Next(1,50);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
