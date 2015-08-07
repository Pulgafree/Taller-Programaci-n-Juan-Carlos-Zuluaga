using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int creditos, estratoEstudiante;
                decimal valorCredito, valorSubsidio, valorMatricula;
                do
                {
                    pedirDatos(out creditos, out valorCredito, out estratoEstudiante);
                } while (creditos <= 0 || valorCredito <= 0 || estratoEstudiante <= 0);
                
                valorMatricula = calcularMatricula(creditos, valorCredito, estratoEstudiante);
                valorSubsidio = calcularSubsidio(estratoEstudiante);
                mostrarResultado(valorMatricula, valorSubsidio);
            } while (true);
        }

        private static void mostrarResultado(decimal valorMatricula, decimal valorSubsidio)
        {
            Console.WriteLine("Costo de la matrícula: ${0:N0}", valorMatricula);
            Console.WriteLine("Valor del subsidio: ${0:N0} \n", valorSubsidio);
            Console.ReadKey();
        }

        private static decimal calcularSubsidio(int estratoEstudiante)
        {
            if (estratoEstudiante == 1)
            {
                return 200000;
            }
            else if (estratoEstudiante == 2)
            {
                return 100000;
            }

            return 0;
        }

        private static void pedirDatos(out int creditos, out decimal valorCredito, out int estratoEstudiante)
        {
            Console.Write("Número de créditos: ");
            try
            {
                creditos = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                creditos = -1;
            }
            

            Console.Write("Valor crédito: ");
            try
            {
                valorCredito = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                valorCredito = -1;
            }
            

            Console.Write("Estrato del estudiante: ");
            try
            {
                estratoEstudiante = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                estratoEstudiante = -1;
            }
            
        }

        private static decimal calcularMatricula(int creditos, decimal valorCredito, int estratoEstudiante)
        {
            decimal valorMatricula = 1.0M;

            if (creditos >=20)
            {
                valorMatricula = (valorCredito * 20 + (creditos - 20) * valorCredito * 2);
            }
            else
            {
                valorMatricula = (creditos * valorCredito);
            }

            switch (estratoEstudiante)
            {
                case 1:
                    return valorMatricula * 0.2M;
                case 2:
                    return valorMatricula * 0.5M;
                case 3:
                    return valorMatricula * 0.7M;                    
                default:
                    return valorMatricula;
            }
        }
    }
}
