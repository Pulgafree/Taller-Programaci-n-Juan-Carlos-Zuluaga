using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NúmeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerN, segundoN, tercerN;
            do
            {
                Console.Write("Ingrese el primer número: ");
                primerN = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                segundoN = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el tercer número: ");
                tercerN = Convert.ToInt32(Console.ReadLine());

                if (primerN > segundoN && primerN > tercerN)
                {
                    Console.WriteLine("El número mayor es {0}", primerN);
                }

                if (segundoN > primerN && segundoN > tercerN)
                {
                    Console.WriteLine("El número mayor es {0}", segundoN);
                }

                if (tercerN > primerN && tercerN > segundoN)
                {
                    Console.WriteLine("El número mayor es {0}", tercerN);
                }
            } while (true);
        }
    }
}
