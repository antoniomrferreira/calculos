using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Aritmetica
    {
       

        /// <summary>
        /// Operação soma
        /// </summary>
        
        /// <returns>Reto0rna a soma de dois números.</returns>
        public static int Somar(int x,int y)
        {
            return x+y;
        }
        
        /// <summary>
        /// Operação de Subtração
        /// </summary>
        
        /// <returns>Retorna o resultado da subtração de dois números</returns>
        public static int Subtrair(int x,int y)
        {
            return x-y;

        }
       

       /// <summary>
        /// Operação de Multiplicação
        /// </summary>
        
        /// <returns>Retorna o resultado da multiplicação de dois números</returns>
        public static int Multiplicar(int x,int y)
        {
            return x*y;

        }
    }
}