using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Aritmetica
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
        /// Operação soma
        /// </summary>
        
        /// <returns>Reto0rna a soma de dois números.</returns>
        public int Somar(int x,int y)
        {
            return x+y;
        }
        
        /// <summary>
        /// Operação de Subtração
        /// </summary>
        
        /// <returns>Retorna o resultado da subtração de dois números</returns>
        public int Subtrair(int x,int y)
        {
            return x-y;

        }
        public double ConverterTemperatura(ConversãoTemperatura conversao, double temperatura)
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

    }
}