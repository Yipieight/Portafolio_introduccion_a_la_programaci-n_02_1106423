using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hoja_de_trabajo_José_García_1106423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double resta = 0;
            for (int i = 1; i >= 1 && i <= 12; i++)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("¿Cuanto quiere depositar en el mes " + "(" + i + ")");
                    Console.Write("Q");
                    double deposito = double.Parse(Console.ReadLine());
                    Console.WriteLine("¿Cuanto dinero quiere ahorrar del deposito de este mes " + "(" + i + ")");
                    Console.Write("Q");
                    double ahorro = double.Parse(Console.ReadLine());
                    if (ahorro < deposito && ahorro >= 0)
                    {
                        resta = deposito - ahorro;
                        suma = suma + ahorro;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("El ahorro es mayor que el deposito, vuelta hacerlo...");
                        i--;
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    i--;
                }
                while (i == 12)
                {
                    i++;
                    Console.WriteLine("El total del ahorra del todo el año es Q" + suma);
                }
            }
            Console.ReadLine();

            int contarmayor = 0;
            int contarmayor300 = 0;
            int contarmenor = 0;
            bool repeticion = false;
            double suma = 0;
            while (repeticion == false)
            {
                try
                {   
                    Console.Clear();
                    Console.WriteLine("Ingrese el valor de la venta");
                    Console.Write("Q");
                    double nventas = double.Parse(Console.ReadLine());
                    if (nventas <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("El valor que ingreso no es valido");
                        Console.ReadLine();
                    }
                    else
                    {
                        suma++;
                        Console.WriteLine("¿Desea ingresar mas ventas? (s = si o n = no)");
                        char sino = char.Parse(Console.ReadLine().ToLower());
                        if (nventas > 1300)
                        {
                            contarmayor++;
                        }
                        else if (nventas > 300 && nventas <= 1300)
                        {
                            contarmayor300++;
                        }
                        else
                        {
                            contarmenor++;
                        }
                        if (sino == 'n')
                        {
                            Console.Clear();
                            Console.WriteLine("----------------------Categorias-------------------------");
                            Console.WriteLine("Categoria (1) de > Q1300 son: " + contarmayor);
                            Console.WriteLine("Categoria (2) de > Q300 y <= Q1300 son: " + contarmayor300);
                            Console.WriteLine("Categoria (3) de < Q300 son: " + contarmenor);
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("La cantidad de ventas es: " + suma);
                            repeticion = true;
                        }
                        else if (sino == 's')
                        {

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Debe colocar s = si o n = no");
                            Console.ReadLine();
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

            }
            Console.ReadLine();
        }
    }
}
