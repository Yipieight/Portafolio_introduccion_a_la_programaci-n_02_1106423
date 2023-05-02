using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Archivo
{
    internal class Libro
    {
        public int codigo;
        public string nombrelibro;
        public int paginas;
        public int leerpaginas;
        public int leerlibross;
        public int paginasactual;
        public double porcentaje;

        public Libro(int codigo, string nombrelibro, int paginas)
        {
            this.codigo = codigo;
            this.nombrelibro = nombrelibro;
            this.paginas = paginas;
            leerpaginas = this.paginas;
        }

        public void paginasacumuladas()
        {
            leerpaginas = this.paginas;
        }
        public void leerlibros(int paginasleer)
        {

            if (leerpaginas >= paginasleer)
            {
                leerlibross -= paginasleer;
            }
            else
            {
                Console.WriteLine("Te has pasado de paginas leidas");
            }
        }
        public double obtenerporcentaje()
        {
            porcentaje = ((double)leerpaginas / this.paginas) * 100;
            return porcentaje;
        }
        public int paginaactual(int paginas)
        {
            
            if(leerpaginas >= paginas)
            {
                paginasactual += paginas;
                return paginasactual;
            }
            else
            {
                return paginasactual;
            }
        }
        public void mostrarlibro()
        {
            Console.WriteLine("El codigo del libro es " + this.codigo + ". El nombre del libro es " + this.nombrelibro);
            Console.WriteLine("La cantidad de paginas es " + this.paginas + ". El porcentaje de la lectura es " + obtenerporcentaje());
            Console.WriteLine("Paginas actuales es " + paginasactual);
        }
        public void estadodellibro()
        {

        }

        static void Main(string[] args)
        {
            int paginasleer;
            string opcion;
            Libro libro1 = new Libro(100, "El principito", 120);
            do
            {
                Console.WriteLine("Cuantas paginas va a leer");
                paginasleer = int.Parse(Console.ReadLine());
                libro1.leerlibros(paginasleer);
                libro1.obtenerporcentaje();
                libro1.paginaactual(paginasleer);
                libro1.mostrarlibro();
                Console.WriteLine("Desea ingresar más paginas leidas");
                opcion = Console.ReadLine().ToLower();
            }
            while (opcion == "s" || opcion == "si");
            

        }   
    }
}
