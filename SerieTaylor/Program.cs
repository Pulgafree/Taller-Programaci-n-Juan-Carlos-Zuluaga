using System;

namespace SerieTaylor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantTerminos, valorX;
            do
            {
                do
                {
                    pedirDatos(out cantTerminos, out valorX);

                } while (cantTerminos <= 0 || valorX <= 0);

                mostrarResultado(cantTerminos, valorX);

            } while (true);
            
            
        }

        private static void mostrarResultado(int cantTerminos, int valorX)
        {
            
            Console.WriteLine("f(x) = {0}", Taylor(valorX, cantTerminos));
            Console.ReadKey();
        }

        private static void pedirDatos(out int cantTerminos, out int valorX)
        {
            Console.Write("Cuantos términos desea: ");
            try
            {
                cantTerminos = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                cantTerminos = 0;
            }
            
            Console.Write("Digite el valor de x: ");
            try
            {
                valorX = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                valorX = 0;
            }
            
        }

        private static double Taylor(double valorX, int cantTerminos)
        {
            int cursor = 0;
            double parcial, sumatoria = 0;
            while (cursor < cantTerminos)
            {
                parcial = Math.Pow(valorX, cursor) / Factorial(cursor);
                sumatoria += parcial;
                cursor++;
            }
            return sumatoria;
        }

        private static double Factorial(int cantTerminos)
        {
            double cursor = 2;
            double fac = 1;
            while (cursor <= cantTerminos)
            {
                fac *= cursor;
                cursor++;
            }
            return fac;
        }

    }
}
