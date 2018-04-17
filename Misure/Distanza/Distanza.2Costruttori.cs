using System;
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
            #region Costruttori

            /// <summary>
            /// Costruttore Generico
            /// Crea un oggetto del valore [0.0 K]
            /// </summary>
            public Distanza()
            {
                _value = 0.0;
                _unitSymbol = "k";
            }

            /// <summary>
            /// Instanzia un oggetto scala termometrica "simb" 
            /// e come valore il relativo valore Assoluto
            /// </summary>
            /// <param name="simb">Simbolo Scala Termometrica</param>
            public Distanza(string simb)
            {
                try
                {
                    _value = UnitAbsValue[Array.IndexOf(UnitSymbol, simb)];
                    _unitSymbol = simb;
                }
                catch
                {
                    _value = 0.0;
                    _unitSymbol = "k";
                    MessageBox.Show("Simbolo Sconosciuto, l'oggetto sara instanziato a 0.0 k");
                }
            }

            /// <summary>
            /// Instanzia un oggetto con valore "value" 
            /// e con "k" come Scala Termometrica
            /// </summary>
            /// <param name="value">Valore della Temperatura</param>
            public Distanza(double value)
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
            public Distanza(string simb, double valueTemp)
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
                        _unitSymbol = "k";
                    }
                }
                catch
                {
                    _value = 0.0;
                    _unitSymbol = "k";
                    throw;
                }

                #endregion
            }
        }
    }
}
