using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    public static class Conversoes
    {
         /// <summary>
        /// Tipo de conversão de ttemperatura a executar.
        /// </summary>
        public enumn ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo=0,
            MetrosMilhas,
            MilhasMetros

        }

        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatura a converter.</param>
        /// <returns>Retorna o resultado da conversão.</returns>
        public static double ConverterTemperatura(ConversãoTemperatura conversao, double temperatura)
        {
            if (conversao == ConverterTemperatura.CelsiusFahrenheit)
            {
                return (temperatura*1.8000 + 32);
            }
            else if (conversao == ConverterTemperatura.FahrenheitCelsius)
            {
                return ((temperatura-32)/1.8000);
            }
            return -1;
        }

        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar.</param>
        /// <param name="distancia">A distância a converter.</param>
        /// <returns>O resultado da conversão da distância.</returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
                if (conversao == ConversaoDistancia.MetrosMilhas)
                {
                    return distancia*0,0006213712;
                }
                else if (conversao == ConversaoDistancia.MilhasMetros)
                {
                    return distancia*1609.344;
                }

                return -1;


        }
    }
}