using System;

/// <summary>
/// 
/// </summary>
namespace Misure
{

    /// <summary>
    /// 455
    /// </summary>
    /// <seealso cref="Misure.IMisure" />
    public partial class Pressione : IMisure
    {
        #region static

        /// <summary>
        /// Verifica che il valore della misura sia conforme alla scala
        /// </summary>
        /// <param name="Simb">Simbolo dell'unità di Misura</param>
        /// <param name="value">Valore della misura</param>
        /// <returns>
        /// true se il valore e' consentito, altrimenti false
        /// </returns>
        public bool ValidateValue(string Simb, double value)
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