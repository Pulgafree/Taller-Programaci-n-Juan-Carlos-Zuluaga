using System;

namespace CalculaFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                do
                {
                    Console.Write("Ingrese número: ");
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        n = 0;
                    }
                } while (n <= 0);
                
                Console.WriteLine("{0}! es igual a {1}", n, Factorial(n));
                Console.ReadKey();
            } while (true);
            
        }

        private static double Factorial(int n)
        {
            int i = 2;
            double f = 1;
            while (i <= n)
            {
                f *= i;
                i++;
            }
            return f;
        }
    }
}
