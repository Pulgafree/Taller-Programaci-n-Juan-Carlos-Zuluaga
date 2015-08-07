using System;

namespace NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Ingrese número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0) // El número es par
                {
                    Console.WriteLine("El número: {0}, es par.", numero);
                }
                else
                {
                    Console.WriteLine("El número: {0}, no es par.", numero);
                }
            } while (true);
        }
    }
}
