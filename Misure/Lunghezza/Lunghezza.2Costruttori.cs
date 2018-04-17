using System;
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
            #region Costruttori

            /// <summary>
            /// Costruttore Generico
            /// Crea un oggetto del valore [0.0 K]
            /// </summary>
            public Lunghezza()
            {
                _value = 0.0;
                _unitSymbol = "m";
            }

            /// <summary>
            /// Instanzia un oggetto scala termometrica "simb" 
            /// e come valore il relativo valore Assoluto
            /// </summary>
            /// <param name="simb">Simbolo Scala Termometrica</param>
            public Lunghezza(string simb)
            {
                try
                {
                    _value =0.0;
                    _unitSymbol = simb;
                }
                catch
                {
                    _value = 0.0;
                    _unitSymbol = "m";
                }
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" 
            /// e con "k" come Scala Termometrica
            /// </summary>
            /// <param name="value">Valore della Temperatura</param>
            public Lunghezza(double value)
            {
                if (value >= 0.0) // Maggiore dello Zero kelvin
                {
                    _value = value;
                }
                else
                {
                    _value = 0.0;
                }

                _unitSymbol = "m";
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" e con "simb" come scala termometrica
            /// </summary>
            /// <param name="simb">Simbolo dell'unita'</param>
            /// <param name="valueTemp">Valore della temperatura</param>
            public Lunghezza(string simb, double valueTemp)
            {
                try
                {
                    if (ValidateValue(simb, valueTemp))
                    {
                        _value = valueTemp;
                        _unitSymbol = simb;
                    }
                    else
                    {
                        _value = 0.0;
                        _unitSymbol = "m";
                    }
                }
                catch
                {
                    _value = 0.0;
                    _unitSymbol = "m";
                }

                #endregion
            }
        }
    }
}
