using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace parametros
{
    //internal class Program
    //{
    //    public int sumar(ref int x,int y)
    //    {
    //        int res = x + y;
    //        x++;
    //        Console.WriteLine("Valor de x " + x);
    //        return res;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int a = 5;
    //        int b = 10;
    //        Program p = new Program();
    //        Console.WriteLine("Resultado " + p.sumar(ref a,b));
    //        Console.WriteLine("a: " + a);
    //        Console.ReadLine();
    //    }
    //}
    //internal class program1
    //{ 
    //    public double calcularCircuferencia(double radio, ref double circ)
    //    {
    //        double area = Math.PI * Math.Pow(radio, 2);
    //        double circuferencia = 2 * Math.PI * radio;
    //        circ = circuferencia;
    //        return area;
    //    }
    //    static void Main(string[] args)
    //    {
    //        program1 c = new program1();
    //        Console.WriteLine("Ingrese un radio");
    //        double r = Convert.ToDouble(Console.ReadLine());
    //        double a, ci = 0;
    //        a = c.calcularCircuferencia(r, ref ci);
    //        Console.WriteLine("Area " + a + " Circuferencia " + ci);

    //        //otra forma
    //        //entrada es un dato fijo
    //        a = c.calcularCircuferencia(7, ref ci);
    //        Console.WriteLine("Area " + a + " Circuferencia " + ci);
    //        Console.ReadLine();


    //    }
    //}
    //internal class program2
    //{
    //    public void mostrarfecha(int dia, int mes, int año)
    //    {
    //        Console.WriteLine(dia + "/" + mes + "/" + año);
    //    }
    //    static void Main(string[] args)
    //    {
    //        program2 fecha = new program2();

    //        Console.WriteLine("Ingrese dia");
    //        int d = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Ingrese mes");
    //        int m = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Ingrese año");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        fecha.mostrarfecha(d, m, a);

    //        Console.ReadLine();

    //    }
    //}

    //public class Cafetera
    //{
    //   public string identificador;
    //   public int capacidadMaximaTazas;
    //   public int tazasDisponiblesActualmente;
    //   public int tazasServidas;

    //    public Cafetera(string identi, int capacidadMaxtaz)
    //    {
    //        identificador = identi;
    //        capacidadMaximaTazas = capacidadMaxtaz; 
    //        tazasDisponiblesActualmente = 0;
    //        tazasServidas = 0;
    //    }

    //    public void HacerCafe()
    //    {
    //        tazasDisponiblesActualmente = capacidadMaximaTazas;   
    //    }

    //    public bool ServirTaza(int cantidad)
    //    {
    //        if (cantidad <= tazasDisponiblesActualmente)
    //        {
    //            tazasDisponiblesActualmente -= cantidad;
    //            tazasServidas += cantidad;
    //            return true;
    //        }
    //        return false;
    //    }

    //    public double ObtenerPorcentajeDisponibilidad()
    //    {
    //        return (double)tazasDisponiblesActualmente / capacidadMaximaTazas * 100;
    //    }

    //    public void MostrarEstado()
    //    {
    //        Console.WriteLine("Identificador de inventario: " + identificador);
    //        Console.WriteLine("Capacidad máxima en cantidad de tazas: " + capacidadMaximaTazas);
    //        Console.WriteLine("Porcentaje de disponibilidad: " + ObtenerPorcentajeDisponibilidad() + "%");
    //        Console.WriteLine("Tazas servidas: " + tazasServidas);
    //    }


    //    public static void Main(string[] args)
    //    {
    //        Cafetera miCafetera = new Cafetera("200", 10);
    //        miCafetera.HacerCafe();
    //        miCafetera.ServirTaza(4);
    //        miCafetera.MostrarEstado();

    //        Console.ReadKey();
    //    }
    //}

        public class cafeteria
        {
            int codigo;
            int capacidad, disponibilidad;
            bool lleno;
            public void hacercafe()
            {
                lleno = true;
                disponibilidad = capacidad;
            }
            public void servircafe(int cantTazas)
            {
                if (disponibilidad >= cantTazas)
                {
                    disponibilidad -= cantTazas;
                }
                else
                {
                    Console.WriteLine("No tenemos suficientes tazas disponibles");
                }
            }
            public double obtenerporcentaje()
            {
                double porcentaje = ((double)disponibilidad / capacidad) * 100;
                return porcentaje;
            }
            public void mostrarestado()
            {
                string texto = codigo + " capacidad: " + capacidad + " tazas servidas: " + (capacidad - disponibilidad) + 
                    " obtener porcentaje de disponibilidad: " + obtenerporcentaje()+ "%";
                Console.WriteLine(texto);
            }

            public cafeteria(int elCodigo, int laCapacidad)
            {
                codigo = elCodigo;
                capacidad = laCapacidad;
            
            }
            public static void Main()
            {
                Console.WriteLine("Ingrese capacidad de la cafetera");
                int cap = Convert.ToInt32(Console.ReadLine());
                string opcion = "";

                cafeteria cafe = new cafeteria(1, cap);
                cafe.hacercafe();
                do
                {
                    Console.WriteLine("Cuantas tazas quiere servir?");
                    int tz = Convert.ToInt32(Console.ReadLine());
                    cafe.servircafe(tz);
                    cafe.mostrarestado();

                    Console.WriteLine("Desea ingresar más tazas?");
                    opcion = Console.ReadLine().ToLower();
                }
                while (opcion == "s" || opcion == "si");
            
                Console.ReadKey();
            }

        }
}
