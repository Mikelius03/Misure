/// <summary>
/// Libreria per la gestione delle conversioni di Misura
/// </summary>
namespace Misure
{
    namespace Conversioni
    {
        public interface IMisure
        {
            #region Proprieta'
            ///
            double Value { get; set; }
            string SimbolTemp { get; set; }
            string NomeUnita { get; set; }
            string SimbolUnita { get; set; }
            string[] NameUnitTemp { get; }
            string[] SimbolUnitTemp { get; }
            #endregion

            #region Metodi        
            #region Verifiche
            /// <summary>
            /// Verifica che simb sia un Simbolo dell'unità di misura scelta
            /// </summary>
            /// <param name="simb">Simbolo dell'unità di Misura da verificare</param>
            /// <returns>ttrue se il simbolo è valido, altrimenti false</returns>
            bool VerificaMisure(string simb);

            /// <summary>
            /// Verifica che il valore della misura sia conforme alla scala
            /// </summary>
            /// <param name="Simb">Simbolo dell'unità di Misura</param>
            /// <param name="value">Valore della misura</param>
            /// <returns>true se il valore e' consentito, altrimenti false</returns>
            bool ValidateValue(string Simb, double value);
            #endregion

            #region ReturnObject
            /// <summary>
            /// Converte l'instanza in gradi Kelvin
            /// </summary>
            /// <returns>Nuova Instanza in gradi "Simb"</returns>
            object ObjectFromMisure(string Simb);

            /// <summary>
            /// Converte l'oggetto instanziato in gradi Kelvin
            /// </summary>
            /// <returns>Nuova instanza in gradi Kelvin</returns>
            object ObjectToMisure();

            /// <summary>
            /// Converte un oggetto Temperature nella scala termometrica scelta
            /// </summary>
            /// <param name="SimbOut">Simbolo della scala termometrica di Output</param>
            /// <returns></returns>
            object ObjectMisureToMisure(string SimbOut);
            #endregion

            #region ReturnValue
            /// <summary>
            /// Converte l'instanza in gradi Kelvin
            /// </summary>
            /// <returns>Nuova Instanza in gradi "Simb"</returns>
            double ValueFromMisure(string Simb);

            /// <summary>
            /// Converte l'oggetto instanziato in gradi Kelvin
            /// </summary>
            /// <returns>Nuova instanza in gradi Kelvin</returns>
            double ValueToMisure();


            double ValueMisureToMisure(string SimbOut);
            #endregion

            #region Override
            /// <summary>
            /// Ovveride del metodo ToString()
            /// </summary>
            /// <returns>Stringa riferita all'oggetto instanziato</returns>
            string ToString();
            #endregion
            #endregion
        }
    }
}
