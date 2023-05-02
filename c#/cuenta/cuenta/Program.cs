using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta
{
    internal class cuenta
    {
        long numero;
        string nombre, tipo;
        bool activa;
        double saldo;

        public cuenta(long num, string nom, string tip, double sal)
        {
            numero = num;
            nombre = nom;
            tipo = tip;
            saldo = sal;

        }

        public void debitar()
        {
            //entrada
            Console.WriteLine("Ingrese monto a debitar");
            double monto = Convert.ToDouble(Console.ReadLine());
            saldo = saldo - monto;
        }
        public void acreditar()
        {
            //entrada
            Console.WriteLine("Ingrese monto a acreditar");
            double monto = Convert.ToDouble(Console.ReadLine());
            saldo = saldo + monto;

        }
        public void imprimirCuenta()
        {
            Console.WriteLine("cuenta: " + numero + " saldo " + saldo);
        }


        static void Main(string[] args)
        {
            //variable miCuenta de clase o tipo de cuenta
            cuenta miCuenta = new cuenta(123456789, "Maria ", "Monetaria", 100.00);
            miCuenta.acreditar();
            miCuenta.imprimirCuenta();
            miCuenta.debitar();
            miCuenta.imprimirCuenta();
            Console.ReadLine();
        }
    }
}
