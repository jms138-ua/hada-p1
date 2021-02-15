using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Esta clase contiene metodos para convertir
    /// de segundos a minutos y de minutos a segundos
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Convierte de segundos a minutos
        /// </summary>
        /// <param name="s">segundos</param>
        /// <returns>minutos</returns>
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
                return 0;

            return s / 60;
        }

        /// <summary>
        /// Convierte de minutos a segundos
        /// </summary>
        /// <param name="m">minutos</param>
        /// <returns>segundos</returns>
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
    }
}
