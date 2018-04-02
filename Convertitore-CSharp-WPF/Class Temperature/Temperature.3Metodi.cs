using System;

namespace Misure
{
    public partial class Temperature
    {
        #region private

        /// <summary>
        /// Verifica che il valore dell'oggeto sia maggiore del valore minimo consentito per l'unita (equivalente a 0 K)
        /// </summary>
        /// <returns>true:valore accettato - false:valore rifiutato</returns>
        private bool ValidateTemp()
        {
            if (AbsValueTemp[Array.IndexOf(Simboli, _SimbolTemp)] > _value)
                return false;

            return true;
        }
        private double ConvertFromKelvin()
        {
            switch (_SimbolTemp)
            {
                case "K":
                    return _value;

                case "C":
                    return _value - 273.15;

                case "F":
                    return _value * (9.0 / 5.0) - 459.67;

                case "R":
                    return _value * (9.0 / 5.0);

                case "De":
                    return (373.15 - _value) * (3.0 / 2.0);

                case "N":
                    return (_value - 273.15) * (33.0 / 100.0);

                case "r":
                    return (_value - 273.15) * (4.0 / 5.0);

                case "Ro":
                    return (_value - 273.15) * (21.0 / 40.0) + 7.5;
            }
            return 0.0;
        }
        private double ConvertToKelvin()
        {
            switch (_SimbolTemp)
            {
                case "K":
                    return _value;

                case "C":
                    return _value + 273.15;

                case "F":
                    return (_value + 459.67) * (5.0 / 9.0);

                case "R":
                    return _value * (5.0 / 9.0);

                case "De":
                    return 373.15 - (_value * (2.0 / 3.0));

                case "N":
                    return _value * (100.0 / 33.0) + 273.15;

                case "r":
                    return (_value * (5.0 / 4.0)) + 273.15;

                case "Ro":
                    return ((_value - 7.5) * (40.0 / 21.0)) + 273.15;
            }
            return AbsValueTemp[0];
        }

        #endregion

        #region public
        
        public double ConvertTemp(string SimbOut)
        {
            _value = ConvertToKelvin();
            _SimbolTemp = SimbOut;
            _value = ConvertFromKelvin();
            return _value;
        }

        #endregion

        #region static

        /// <summary>
        /// Versione per oggetti non istanziati
        /// </summary>
        /// <param name="Simb">Simbolo dell'unità di misura</param>
        /// <param name="value">Valore della misura</param>
        /// <returns>Tue:valido - false:Non valido</returns>
        public static bool ValiateTemp(string Simb, double value)
        {
            if (AbsValueTemp[Array.IndexOf(Simboli, Simb)] > value)
                return false;

            return true;

        }
        /*
        public double ConvertTemp(string SimbIn, double valueIn, string SimboOut)
        {
            _value = ConvertToKelvin();
            return ConvertFromKelvin();
        }
        */
        #endregion
    }
}