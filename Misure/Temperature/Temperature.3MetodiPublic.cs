using System;

namespace Misure
{
    public partial class Temperature
    {
        #region public

        /// <summary>
        /// Converte un oggetto Temperature nella scala termometrica scelta
        /// </summary>
        /// <param name="SimbOut">Simbolo della scala termometrica di Output</param>
        /// <returns></returns>
        public Temperature ConvertTemp(string SimbOut)
        {
            // Prima Conversione
            // Converte il valore dell'oggetto in gradi Kelvin
            Temperature Temporaneo = ConvertToKelvin();

            return Temporaneo.ConvertFromKelvin(SimbOut);
        }

        public double ConvertValueTemp(string SimbOut)
        {
            // Creo una 2° instanza per evitare modicfiche alla 1°

            Temperature temp = new Temperature();
            temp.Value = this.ValueToKelvin();
            temp.Value = temp.ValueFromKelvin(SimbOut);
            return temp.Value;
        }


        public bool VerificateScala(string simb)
        {
            if (Array.IndexOf(Simboli, simb) == -1)
                return false;
            return true;
        }

        #endregion
    }
}