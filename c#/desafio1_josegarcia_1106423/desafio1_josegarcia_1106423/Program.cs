using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace desafio1_josegarcia_1106423
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //problema 2

            bool emple = true;
            int repeticiones = 0;
            int empleados = 0;
            int i = 0;
            int suma = 0;
            while (emple == true)
            {
                try
                {
                    Console.WriteLine("Cuantos empleados desea ingresar");
                    empleados = int.Parse(Console.ReadLine());
                    if (empleados <= 0)
                    {
                        Console.WriteLine("Debe colocar un numero mayor que 0");
                    }
                    else
                    { 
                        emple = false;
                        while (repeticiones != empleados)
                        {
                            Console.WriteLine("Cuantos dias elaboro el empleado en la semana: 1 entre 7");
                            try
                            {
                                int semana = int.Parse(Console.ReadLine());

                                Console.WriteLine("Cuanto ganara por hora el empleado");
                                int dinero = int.Parse(Console.ReadLine());
                                if (semana > 0 && semana <= 7)
                                {
                                    int repeticiones2 = 0;
                                    while (repeticiones2 != semana)
                                    {
                                        i++;
                                        Console.WriteLine("Cuantas horas trabajo en el dia " + i );
                                        try
                                        {
                                            int horas = int.Parse(Console.ReadLine());
                                            if (horas > 0 && horas <= 24)
                                            {
                                                suma = suma + dinero * horas;
                                                repeticiones2++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Debe colocar la hora entre 1 y 24");
                                                i--;
                                            }
                                        }
                                        catch (Exception ex1)
                                        {
                                            Console.WriteLine(ex1.Message);
                                        }
                                    }
                                    Console.WriteLine("El empleado a la semana gano " + suma);

                                }
                                else if (semana <= 0 || semana > 7)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Debe colocar un dia entre 1 y 7...");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } 
        }
    }
}
