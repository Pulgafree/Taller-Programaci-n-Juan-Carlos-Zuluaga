using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioMercancias
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pesoMercancia, valorMercancia, tarifa, promocion, totalAPagar, descuento;
            string diaSemana, tipoPago;
            do
            {
                do
                {
                    pedirDatos(out pesoMercancia, out valorMercancia, out diaSemana, out tipoPago);

                } while (pesoMercancia <= 0 || valorMercancia <= 0 || diaSemana == null || tipoPago == null);

                tarifa = calcularTarifaEnvio(pesoMercancia);
                promocion = calcularPromocion(diaSemana, tipoPago, valorMercancia, tarifa);
                descuento = calcularDescuento(valorMercancia, promocion, tarifa);

                totalAPagar = entregaTotal(tarifa, promocion, descuento);

                mostrarResultado(tarifa, promocion, descuento, totalAPagar);

            } while (true);

        }

        private static void mostrarResultado(decimal tarifa, decimal promocion, decimal descuento, decimal totalAPagar)
        {
            Console.WriteLine("Tarifa: ${0:N0}", tarifa);
            if (promocion > 0)
            {
                Console.WriteLine("Promoción: ${0:N0}", promocion);
            }
            else
            {
                Console.WriteLine("Descuento: ${0:N0}", descuento);
            }
            Console.WriteLine("Total a pagar: ${0:N0}", totalAPagar);
            Console.ReadKey();
        }

        private static decimal entregaTotal(decimal tarifa, decimal promocion, decimal descuento)
        {
            if (promocion > 0) // Al tener promocion, no se usa descuento
            {
                return tarifa - promocion;
            }
            else
            {
                return tarifa - descuento;
            }
        }

        private static void pedirDatos(out decimal pesoMercancia, out decimal valorMercancia, out string diaSemana, out string tipoPago)
        {
            Console.Write("Peso de la mercancía: ");
            try
            {
                pesoMercancia = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                pesoMercancia = 0;
            }
            Console.Write("Valor de la mercancía: ");
            try
            {
                valorMercancia = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                valorMercancia = 0;
            }
            Console.Write("Es lunes [S]í [N]o: ");
            diaSemana = Console.ReadLine().ToLower();

            if (diaSemana != "s" && diaSemana != "n")
            {
                diaSemana = null;
            }

            Console.Write("Tipo de Pago [E]fectivo [T]arjeta: ");
            tipoPago = Console.ReadLine().ToLower();

            if (tipoPago != "e" && tipoPago != "t")
            {
                tipoPago = null;
            }
        }

        private static decimal calcularTarifaEnvio(decimal pesoMercancia)
        {
            if (pesoMercancia > 200)
            {
                return (Math.Floor((pesoMercancia - 200) / 10)) * 2000 + 35000;
            }
            else if (pesoMercancia <= 200 && pesoMercancia > 150)
            {
                return 30000;
            }
            else if (pesoMercancia <= 150 && pesoMercancia >= 100)
            {
                return 25000;
            }
            return 20000;
        }

        private static decimal calcularPromocion(string diaSemana, string tipoPago, decimal valorMercancia, decimal tarifa)
        {

            if (diaSemana == "s" && tipoPago == "t")
            {
                return tarifa * 0.5M;
            }
            else if (tipoPago == "e" && valorMercancia > 1000000)
            {
                return tarifa * 0.4M;
            }
            return 0M;
        }

        private static decimal calcularDescuento(decimal valorMercancia, decimal promocion, decimal tarifa)
        {
            if (promocion == 0) // Si no se aplico ninguna promoción...
            {
                if (valorMercancia > 1000000)
                {
                    return tarifa * 0.3M;
                }
                else if (valorMercancia > 600000 && valorMercancia <= 1000000)
                {
                    return tarifa * 0.2M;
                }
                else if (valorMercancia >= 300000 && valorMercancia <= 600000)
                {
                    return tarifa * 0.1M;
                }
                return 0M;
            }
            return 0M;
        }
    }
}
