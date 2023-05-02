using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace instagram
{
    internal class instagram
    {
        string Usuario;
        int Publicaciones;
        int Seguidores;

        public instagram(string usuario, int publicaciones,int seguidores)
        {
            Usuario = usuario;
            Publicaciones = publicaciones;
            Seguidores = seguidores;
        }

        public void subirpubliaciones()
        {
            Console.WriteLine("Ingrese cuantas publicaciones quiere publicar");
            int subirpublicaciones = Convert.ToInt32(Console.ReadLine());
            Publicaciones = Publicaciones + subirpublicaciones;
        }
        public void informacion()
        {
            Console.WriteLine(Usuario + " numero de publicaciones: " + Publicaciones + " y numero de seguidores " + Seguidores);       
        }


        static void Main(string[] args)
        {
            instagram cuentas = new instagram("@Josecito", 20,5000);
            cuentas.subirpubliaciones();
            cuentas.informacion();
            Console.Read();
        }
        
    }
}
