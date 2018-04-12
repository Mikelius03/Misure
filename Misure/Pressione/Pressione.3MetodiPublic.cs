using System;

namespace Misure
{
    public partial class Pressione : IMisure
    {
        #region public

        /// <summary>
        /// Converte un oggetto Temperature nella scala termometrica scelta
        /// </summary>
        /// <param name="SimbOut">Simbolo della scala termometrica di Output</param>
        /// <returns></returns>
        public object ConvertTemp(string SimbOut)
        {
            // Prima Conversione
            // Converte il valore dell'oggetto in gradi Kelvin
            Pressione Temporaneo =(Pressione)ObjectToMisure();

            return Temporaneo.ObjectFromMisure(SimbOut);
        }

        public double ConvertValueTemp(string SimbOut)
        {
            // Creo una 2° instanza per evitare modicfiche alla 1°

            Pressione temp = new Pressione();
            temp.Value = this.ValueToMisure();
            temp.Value = temp.ValueFromMisure(SimbOut);
            return temp.Value;
        }


        public bool VerificaMisura(string simb)
        {
            if (Array.IndexOf(Simboli, simb) == -1)
                return false;
            return true;
        }

        #endregion
    }
}