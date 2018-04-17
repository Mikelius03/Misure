/// <summary>
/// Libreria per la gestione delle conversioni di Misura
/// </summary>
namespace Misure
{
    namespace Conversioni
    {

        /**
             * \class Lunghezza
             */
        public partial class Lunghezza : IMisure
        {
            #region Campi

            #region static
            /// <summary>
            /// Matrice di Strighe contenente i nomi delle scale termometriche
            /// </summary>
            public static readonly string[] NameUnit =
             {"metro", "centrimetro", "Kilometro", "pollice",
                "piede", "yarda", "miglio terrestre", "miglio nautico" };

            /// <summary>
            /// Matrice di Strighe contenente le unità di misura delle scale termometriche
            /// </summary>
            public static readonly string[] SimbUnit =
             {"m","cm","Km","in","ft","yd","mi","naut_mi" };

            #endregion

            #region private
            private double _value;
            private string _unitMeasure;
            private string _unitSymbol;

            #endregion
            #endregion

            #region Property  

            // Nome e simbolo della grandezza fisica
            public string MeasurementName { get => "Lunghezza"; }
            public string MeasurementSymbol { get => "L"; }

            // valore scalare, Nome e Simbolo del misurazione da convertire
            public double Unit_Value { get => _value; private set => _value = value; }
            public string Unit_Name { get => _unitMeasure; private set => _unitMeasure = value; }
            public string Unit_Symbol { get => _unitSymbol; private set => _unitSymbol = value; }

            // Matrici contenenti rispettivamente, Nomi, Simboli e Valori limite delle unita' di misura

            public string[] UnitName { get => NameUnit; }
            public string[] UnitSymbol { get => SimbUnit; }

            #endregion

        }
    }
}