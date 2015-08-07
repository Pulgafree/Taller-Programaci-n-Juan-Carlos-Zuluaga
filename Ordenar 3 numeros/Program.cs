using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_3_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<int> numeros = new List<int>();

                Console.Write("Ingrese el primer número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ingrese el segundo número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ingrese el tercer número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));

                numeros.Sort();
                numeros.Reverse();

                Console.WriteLine("El número mayor es: {0}", numeros[0]);
                Console.WriteLine("El número del medio es: {0}", numeros[1]);
                Console.WriteLine("El número menor es: {0}", numeros[2]);
                
            } while (true);
        }
    }
}
