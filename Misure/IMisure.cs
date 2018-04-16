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

            // Nome e simbolo della grandezza fisica
            string MeasurementName      { get; }
            string MeasurementSymbol    { get; }

            // valore scalare, Nome e Simbolo del misurazione da convertire
            double Unit_Value  { get; }
            string Unit_Name   { get; }
            string Unit_Symbol { get; }

            // Matrici con i nomi e simboli delle diverse unita' di misura
            string[] UnitName { get; }
            string[] UnitSymbol { get; }

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
            void ImpostaObject(string a, double b);
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
