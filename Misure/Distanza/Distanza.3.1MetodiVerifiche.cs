﻿using System;
using System.Windows.Forms;

namespace Misure
{
    namespace Conversioni
    {
        /**
         * \class Distanza
         */
        public partial class Distanza : IMisure
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
                try
                {
                    int index = Array.IndexOf(UnitSymbol, Simb);
                    if (index <= -1)
                        return false;

                    // La scala Delisle diminuisce all'aumentare dell'agitazione termica delle molecole
                    if (Simb.Equals("De"))
                    {
                        if (UnitAbsValue[index] < value)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (UnitAbsValue[index] > value)
                            return false;
                        else
                            return true;
                    }
                }
                catch
                {
                    throw new NullReferenceException();
                }


            }
        }
    }
}