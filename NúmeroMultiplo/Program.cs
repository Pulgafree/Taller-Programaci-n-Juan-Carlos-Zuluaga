using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NúmeroMultiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerN, segundoN;

            do
            {
                Console.Write("Ingrese el primer número: ");
                primerN = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                segundoN = Convert.ToInt32(Console.ReadLine());

                if (primerN % segundoN == 0)
                {
                    Console.WriteLine("El número: {0} es múltiplo de: {1}. \n", primerN, segundoN);
                }
                else
                {
                    Console.WriteLine("El número: {0} no es múltiplo de: {1}. \n", primerN, segundoN);
                }
            } while (true);
        }
    }
}
