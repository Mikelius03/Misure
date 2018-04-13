using System;

namespace Misure
{
    namespace Conversioni
    {
        /**
         * \class Temperature
         */
        public partial class Temperature : IMisure
        {
            /// <summary>
            /// Verifica che simb sia un Simbolo dell'unità di misura scelta
            /// </summary>
            /// <param name="simb">Simbolo dell'unità di Misura da verificare</param>
            /// <returns>ttrue se il simbolo è valido, altrimenti false</returns>
            public bool VerificaMisure(string simb)
            {
                if (Array.IndexOf(Simboli, simb) == -1)
                    return false;
                return true;
            }

            /// <summary>
            /// Verifica che il valore della misura sia conforme alla scala
            /// </summary>
            /// <param name="Simb">Simbolo dell'unità di Misura</param>
            /// <param name="value">Valore della misura</param>
            /// <returns>true se il valore e' consentito, altrimenti false</returns>
            public bool ValidateValue(string Simb, double value)
            {
                int index = Array.IndexOf(Simboli, Simb);
                if (index == -1)
                    return false;

                // La scala Delisle diminuisce all'aumentare dell'agitazione termica delle molecole
                if (Simb.Equals("De"))
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
                    else
                        return true;
                }

            }
        }
    }
}