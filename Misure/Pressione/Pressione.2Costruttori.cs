using System;

namespace Misure
{
    namespace Conversioni
    {
        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="Misure.IMisure" />
        public partial class Pressione : IMisure
        {
            #region Costruttori

            /// <summary>
            /// Costruttore Generico
            /// Crea un oggetto del valore [0.0 K]
            /// </summary>
            public Pressione()
            {
                _value = 0.0;
                _unitSymbol = "Pa";
            }

            /// <summary>
            /// Instanzia un oggetto con unita' "simb" 
            /// e come valore 0.0
            /// </summary>
            /// <param name="simb">Simbolo unita' di Misura</param>
            public Pressione(string simb)
            {
               _value = 0.0;
                _unitSymbol = simb;
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" 
            /// e con "k" come Scala Termometrica
            /// </summary>
            /// <param name="value">Valore della Temperatura</param>
            public Pressione(double value)
            {
                if (value >= 0.0) // Maggiore dello Zero kelvin
                {
                    _value = value;
                }
                else
                {
                    _value = 0.0;
                }

                _unitSymbol = "Pa";
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" e con "simb" come scala termometrica
            /// </summary>
            /// <param name="simb">Simbolo dell'unita'</param>
            /// <param name="valueTemp">Valore della temperatura</param>
            public Pressione(string simb, double valueTemp)
            {
                int index = Array.IndexOf(UnitSymbol, simb);

                if (index == -1)
                    return;

                _unitSymbol = simb;


                if (ValidateValue(simb, valueTemp))
                {
                   _value = valueTemp;
                }
                else
                {
                    _value = 0.0; // AbsValueTemp[index];
                }

            }

            #endregion
        }
    }
}
