using System;

namespace Misure
{
    public partial class Temperature
    {
        #region static

        /// <summary>
        /// Versione per oggetti non istanziati
        /// </summary>
        /// <param name="Simb">Simbolo dell'unità di misura</param>
        /// <param name="value">Valore della misura</param>
        /// <returns>Tue:valido - false:Non valido</returns>
        public static bool ValiateTemp(string Simb, double value)
        {
            int index = Array.IndexOf(Simboli, Simb);
            if (index == -1)
                return false;

            // La scala Delisle diminuisce all'aumentare dell'agitazione termica delle molecole
            if (Simb.Equals("De") )
            {
                if (AbsValueTemp[index] < value)
                    return false;
                else
                    return true;
            }
            else
            {
                if (AbsValueTemp[index] > value)
                    return false;

                return true;
            }

        }
        #endregion
    }
}