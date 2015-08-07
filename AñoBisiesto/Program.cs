using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBisiesto
{
    class Program
    {
        static bool esBisiesto(int año)
        {
            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        static int verificarEntero()
        {
            int numero;
            string cadena;

            cadena = Console.ReadLine();

            try
            {
                numero = Convert.ToInt32(cadena);
            }
            catch (Exception)
            {
                return -1;
            }
            return numero;
        }
        static void Main(string[] args)
        {
            int año, añoActual;
            string tiempoVerbal;

            do
            {
                do
                {
                    Console.Write("Ingrese el año: ");
                    año = verificarEntero();

                } while (año <= 0);

                añoActual = DateTime.Now.Year;

                if (año > añoActual)
                {
                    tiempoVerbal = "será";
                }
                else if (año < añoActual)
                {
                    tiempoVerbal = "fue";
                }
                else
                {
                    tiempoVerbal = "es";
                }

                if (esBisiesto(año))
                {
                    Console.WriteLine("El año: {0}, si {1} bisiesto. \n", año, tiempoVerbal);
                }
                else
                {
                    Console.WriteLine("El año: {0}, no {1} bisiesto. \n", año, tiempoVerbal);
                }

            } while (true);
        }
    }
}
