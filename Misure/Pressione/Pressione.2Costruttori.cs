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
                Value = 0.0;
                SimbolTemp = "Pa";
            }

            /// <summary>
            /// Instanzia un oggetto scala termometrica "simb" 
            /// e come valore il relativo valore Assoluto
            /// </summary>
            /// <param name="simb">Simbolo Scala Termometrica</param>
            public Pressione(string simb)
            {
                Value = AbsValueTemp[Array.IndexOf(Simboli, simb)];
                SimbolTemp = simb;
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
                    Value = value;
                }
                else
                {
                    Value = 0.0;
                }

                SimbolTemp = "Pa";
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" e con "simb" come scala termometrica
            /// </summary>
            /// <param name="simb">Simbolo dell'unita'</param>
            /// <param name="valueTemp">Valore della temperatura</param>
            public Pressione(string simb, double valueTemp)
            {
                int index = Array.IndexOf(Simboli, simb);

                if (index == -1)
                    return;

                SimbolTemp = simb;


                if (ValidateValue(simb, valueTemp))
                {
                    Value = valueTemp;
                }
                else
                {
                    Value = 0.0; // AbsValueTemp[index];
                }

            }

            #endregion
        }
    }
}
