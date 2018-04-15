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
            #region Costruttori

            /// <summary>
            /// Costruttore Generico
            /// Crea un oggetto del valore [0.0 K]
            /// </summary>
            public Temperature()
            {
                _value = 0.0;
                _unitSymbol = "k";
            }

            /// <summary>
            /// Instanzia un oggetto scala termometrica "simb" 
            /// e come valore il relativo valore Assoluto
            /// </summary>
            /// <param name="simb">Simbolo Scala Termometrica</param>
            public Temperature(string simb)
            {
                _value = UnitAbsValue[Array.IndexOf(UnitSymbol, simb)];
                _unitSymbol = simb;
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" 
            /// e con "k" come Scala Termometrica
            /// </summary>
            /// <param name="value">Valore della Temperatura</param>
            public Temperature(double value)
            {
                if (value >= 0.0) // Maggiore dello Zero kelvin
                {
                    _value = value;
                }
                else
                {
                    _value = 0.0;
                }

                _unitSymbol = "k";
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" e con "simb" come scala termometrica
            /// </summary>
            /// <param name="simb">Simbolo dell'unita'</param>
            /// <param name="valueTemp">Valore della temperatura</param>
            public Temperature(string simb, double valueTemp)
            {
                if (VerificaMisure(simb))
                   _unitSymbol = simb;
                else
                    return;


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
