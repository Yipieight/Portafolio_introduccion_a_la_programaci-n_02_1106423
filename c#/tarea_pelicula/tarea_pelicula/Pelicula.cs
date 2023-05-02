using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_pelicula
{
    internal class Pelicula
    {
        public string director;
        public string nombre;
        public string genero;
        public int duracion;
        public int año;
        public double calificacion;

        public Pelicula(string director, string nombre, string genero, int duracion, int año, double calificacion)
        {
            this.director = director;
            this.nombre = nombre;
            this.genero = genero;
            this.duracion = duracion;
            this.año = año;
            this.genero = genero;
            this.calificacion = calificacion;
        }

        public void imprimirpelicula()
        {
            Console.WriteLine("La pelicula es: " + nombre);
            Console.WriteLine("El director es: " + director);
            Console.WriteLine("El año de estreno de la pelicula fue en el : " + año);
            Console.WriteLine("La genero es: " + genero);
            Console.WriteLine("La duracion es: " + duracion + " minutos");
            Console.WriteLine("La calificación es de: " + calificacion);
        }
        public bool esPeliculaEpica()
        {
            if (this.duracion >= 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string valoracion()
        {
            if(this.calificacion >= 0 && this.calificacion <= 2)
            {
                return "Muy mala";
            }
            else if (this.calificacion > 2 && this.calificacion <= 5)
            {
                return "Mala";
            }
            else if (this.calificacion > 5 && this.calificacion <= 7)
            {
                return "Regular";
            }
            else if (this.calificacion > 7 && this.calificacion <= 8)
            {
                return "Buena";
            }
            else
            {
                return "Excelente";
            }  
        }
        public bool esSimiliar(Pelicula otrapelicula)
        {
            if (this.genero == otrapelicula.genero && this.calificacion == otrapelicula.calificacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Pelicula pelicula1 = new Pelicula("Gandhi","Richard Attenborought","Drama",191,1982,8.1);
            pelicula1.imprimirpelicula();
            Console.WriteLine("La pelicula " + pelicula1.esPeliculaEpica() + " dura mas de 3 horas");
            Console.WriteLine("La valoración de la pelicula es: " + pelicula1.valoracion() + "\n");

            Pelicula pelicula2 = new Pelicula("Thor", "Kenneth Branagh", "Acción", 115, 2021, 7.0);
            pelicula2.imprimirpelicula();
            Console.WriteLine("La pelicula " + pelicula2.esPeliculaEpica() + " dura mas de 3 horas");
            Console.WriteLine("La valoración de la pelicula es: " + pelicula2.valoracion() + "\n");

            Console.WriteLine("El genero y la calificación de ambas peliculas es " + pelicula1.esSimiliar(pelicula2) + " De similitud");

            Console.ReadKey();
        }
    }
}
