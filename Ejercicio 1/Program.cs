using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar los dos valores
            Console.WriteLine("Ingrese el primer valor");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            int valor2 = int.Parse(Console.ReadLine());

            Operaciones op1 = new Operaciones(valor1, valor2);//Se genera la instancia u objeto y se realiza la operación internamente para mostar la salida por consola.

            Console.ReadKey();
        }
    }
}
