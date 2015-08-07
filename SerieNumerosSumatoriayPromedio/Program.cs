using System;

namespace SerieNumerosSumatoriayPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            do
            {
                do
                {
                    pediDatos(out cantidad);
                } while (cantidad <= 0);
                
                mostrarCalculo(cantidad);

            } while (true);
            

        }

        private static void mostrarCalculo(int cantidad)
        {
            int sumaN, promedioN, cursor;
            sumaN = 0; cursor = 1;
            while (cursor <= cantidad)
            {
                Console.Write("{0,8}", cursor);
                sumaN += cursor;
                cursor ++;
            }
            promedioN = sumaN / cantidad;

            Console.WriteLine("\nLa suma es: {0}", sumaN);
            Console.WriteLine("El promedio es: {0} \n", promedioN); // Está perdiendo precisión
            Console.ReadKey();
        }

        private static void pediDatos(out int cantidad)
        {
            Console.Write("Cuantos números desea: ");
            try
            {
                cantidad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                cantidad = 0;
            }

        }
    }
}
