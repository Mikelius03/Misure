using System;

namespace Misure
{
    public partial class Temperature
    {
        #region Costruttori

        /// <summary>
        /// Costruttore Generico
        /// </summary>
        public Temperature()
        {
            _value = 0.0;
            _SimbolTemp = "K";
        }

        /// <summary>
        /// Instanzia un oggetto con "simb" come unita' e come valore il relativo valore Assoluto
        /// </summary>
        /// <param name="simb">Unita' della temperatura</param>
        public Temperature(string simb)
        {
            _value = AbsValueTemp[Array.IndexOf(Simboli, simb)];
            _SimbolTemp = simb;
        }

        /// <summary>
        /// Instanzia un oggetto con valore "value" e con "k" come unita'
        /// </summary>
        /// <param name="value">Valore della Temperatura</param>
        public Temperature(double value)
        {
            if (value >= 0.0)
            {
                _value = value;
            }
            else
            {
                _value = 0.0;
            }

            _SimbolTemp = "K";
        }

        /// <summary>
        /// Instanzia un oggetto con valore "value" e con "simb" come unita'
        /// </summary>
        /// <param name="simb">Simbolo dell'unita'</param>
        /// <param name="valueTemp">Valore della temperatura</param>
        public Temperature(string simb, double valueTemp)
        {
            _value = valueTemp;
            _SimbolTemp = simb;
        }
        #endregion
    }
}
