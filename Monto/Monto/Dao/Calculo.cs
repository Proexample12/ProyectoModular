using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monto.Dao
{
    /// <summary>
    /// calcular monto por paso de valor 
    /// </summary>
    public static class Calculo
    {
        public static double CalcularMonto(double precio)
        {
            return precio *= 1.15;
        }

        /// <summary>
        /// calcular monto por paso de referencia 
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static double CalcularMonto(ref double precio)
        {
            precio *= 1.15;
            return precio;
        }

            
    }
}
