﻿using System;
using System.Windows.Forms;

namespace Misure
{
    namespace Conversioni
    {
        /**
         * \class Lunghezza
         */
        public partial class Lunghezza : IMisure
        {
            /// <summary>
            /// Verifica che simb sia un Simbolo dell'unità di misura scelta
            /// </summary>
            /// <param name="simb">Simbolo dell'unità di Misura da verificare</param>
            /// <returns>ttrue se il simbolo è valido, altrimenti false</returns>
            public bool VerificaMisure(string simb)
            {
                if (Array.IndexOf(UnitSymbol, simb) == -1)
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
                if (0.0 > value)
                    return false;
                else
                    return true;
            }
        }
    }
}