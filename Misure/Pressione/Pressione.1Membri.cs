namespace Misure
{
    namespace Conversioni
    {
        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="Misure.IMisure" />
        public partial class Pressione : IMisure
        {
            #region Campi
            #region static
            /// <summary>
            /// Matrice di Stri ghe contenenti i sinboli delle scale termometriche
            /// </summary>
            public static readonly string[] SimbUnit =
            { "Pa", "bar", "torr", "mmH2O", "atm", "kgf", "ata", "Ba" };

            /// <summary>
            /// Matrice di Stri ghe contenenti i nomi delle scale termometriche
            /// </summary>
            public static readonly string[] NameUnit =
             {"pascal", "bar", "millimetri di mercurio", "millimetri H2O", "atmosfere",
                "kilogrammi Forza", "atmosfere tecniche", "barye" };


            #endregion
            #region private
            private double _value;
            private string _unitMeasure;
            private string _unitSymbol;
            #endregion
            #endregion

            #region Property  

            // Nome e simbolo della grandezza fisica
            public string MeasurementName { get => "Pressione"; }
           public string MeasurementSymbol { get => "P"; }

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