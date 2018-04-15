/// <summary>
/// Libreria per la gestione delle conversioni di Misura
/// </summary>
namespace Misure
{
    namespace Conversioni
    {

        /**
             * \class Temperature
             */
        public partial class Temperature : IMisure
        {
            #region Campi

            #region static
            /// <summary>
            /// Matrice di Strighe contenente i nomi delle scale termometriche
            /// </summary>
            public static readonly string[] NameUnit =
             {"Kelvin","Celsius","Fahrenheit","Rankine","Delisle","Reamuer","Newton","Rømer" };    

            /// <summary>
            /// Matrice di Strighe contenente le unità di misura delle scale termometriche
            /// </summary>
            public static readonly string[] SimbUnit =
             {"k","°C","°F","°R","°De","°r","°N","°Rø" };

            /// <summary>
            /// Matrice di Strighe contenente i limiti inferiori delle scale termometriche
            /// </summary>
            public static readonly double[] AbsValue =
                {0.0, -273.15, -459.67, 0.0, 559.725,  -218.52, -90.1395, -135.904};
            //    K,      C,       F,    R,    De,         r,      N,        Ro
            #endregion

            #region private
            private double _value;
            private string _unitMeasure;
            private string _unitSymbol;

            #endregion
            #endregion

            #region Property  

            // Nome e simbolo della grandezza fisica
            public string MeasurementName { get => "Temperatura";}
            public string MeasurementSymbol { get => "T"; }

            // valore scalare, Nome e Simbolo del misurazione da convertire
            public double Unit_Value  { get => _value;       private set => _value       = value; }
            public string Unit_Name   { get => _unitMeasure; private set => _unitMeasure = value; }
            public string Unit_Symbol { get => _unitSymbol;  private set => _unitSymbol  = value; }

            // Matrici contenenti rispettivamente, Nomi, Simboli e Valori limite delle unita' di misura

            public string[] UnitName     { get => NameUnit; }
            public string[] UnitSymbol   { get => SimbUnit; }
            public double[] UnitAbsValue { get => AbsValue; }

            #endregion

        }
    }
}