using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEscritorios;
            decimal valorAPagar;
            do
            {
                do
                {
                    PedirDatos(out numEscritorios);

                } while (numEscritorios <= 0);

                valorAPagar = CalcularValor(numEscritorios);
                MostrarResultado(valorAPagar);

            } while (true);
            

        }

        static void PedirDatos(out int numEscritorios)
        {
            Console.Write("Números de escritorios: ");
            try
            {
                numEscritorios = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                numEscritorios = -1;
            }
            
        }

        static decimal CalcularValor(int numEscritorios)
        {
            decimal precioEscritorio = 650000 * numEscritorios;

            if (numEscritorios < 5)
            {
                return precioEscritorio * 0.9M;
            }
            else if (numEscritorios < 10)
            {
                return precioEscritorio * 0.8M;
            }

            return precioEscritorio * 0.6M;
        }

        static void MostrarResultado(decimal valorAPagar)
        {
            Console.WriteLine("El valor a pagar es: ${0:N0}", valorAPagar);
            Console.ReadKey();
        }
    }
}
