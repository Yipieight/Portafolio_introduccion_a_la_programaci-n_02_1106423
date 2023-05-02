using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matricesgrupo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //José Andrés García Elías 1106423
            //Oscar Daniel Xiquin Cumes 1118423
            //Mario Ricardo de la Cruz Guevara 1176323
            promedoi();
            temperaturatardeymañana();
        }

        public static double[,] temperaturas = new double[7, 2];
        public static string[] dias = new string[7] 
        { 
            "Lunes    ", 
            "Martes   ", 
            "Miercoles", 
            "Jueves   ", 
            "Viernes  ", 
            "Sabado   ", 
            "Domingo  " };

        public static void promedoi()
        {
            Random rand = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temperaturas[i, j] = rand.Next(0, 50);
                }
            }
            Console.WriteLine("Mostrar temperatura \n");
            Console.WriteLine("Dia\t\t|Manana\t|Tarde");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", dias[i], temperaturas[i, 0], temperaturas[i, 1]);
                //Console.WriteLine(te)
            }
            double promedio = 0;
            for (int i = 4; i < 7; i++)
            {

                promedio += temperaturas[i, 0];
                promedio /= 3;
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"El promedio de temperaturas es de {promedio.ToString("F2")} \n");
        }
        public static void temperaturatardeymañana()
        {

            string semana = "";
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                if (temperaturas[i, 1] > 30)
                {
                    semana = semana + ", " + dias[i];
                }
            }
            Console.WriteLine("Los dias con más calor son: " + semana.Replace(" ",""));
            semana = "";
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                if (temperaturas[i, 1] < 30)
                {
                    semana = semana + "," + dias[i];
                }


            }
            Console.WriteLine("Los dias con menos calor son: "+ semana.Replace(" ", ""));

            int contador = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (temperaturas[i, j] < 30)
                    {
                        temperaturas[i, j] = temperaturas[i, j];
                        contador++;

                    }


                }


            }
            Console.WriteLine("La cantidad de dias que tienen una temperatura menor a 30 °C es: " + contador);


            double promedio = 0;

            int cont = 0;
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {

                for (int j = 1; j < temperaturas.GetLength(1); j += 2)
                {
                    if (temperaturas[i, j] > 30)
                    {
                        temperaturas[i, j] = temperaturas[i, j];
                        cont++;

                        promedio = promedio + temperaturas[i, j];



                    }

                }

            }
            promedio = promedio / cont;
            Console.WriteLine("El promedio de las temperaturas mayores a 30°C por la tarde es: " + promedio);


            double prom = 0;
            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {

                for (int j = 1; j < temperaturas.GetLength(1); j += 2)
                {
                    prom = prom + temperaturas[i, j];

                }

            }

            prom = prom / 7;

            if (prom > 30)
            {
                Console.WriteLine("Dadas elas temperaturas por la tarde es una temporada calurosa");

            }
            else
            {
                Console.WriteLine("No es una temporada calurosa");
            }
            Console.ReadKey();
        }

    }
}
