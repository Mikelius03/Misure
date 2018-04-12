/// <summary>
/// Libreria per la gestione delle conversioni di Misura
/// </summary>
namespace Misure
{
    
/**
     * \class Temperature
     */
    public partial class Temperature : IMisure
    {
        #region Campi

        #region static
        /// <summary>
        /// Matrice di Strighe contenente i simboli delle scale termometriche
        /// </summary>
        public static readonly string[] Simboli =
        { "k", "C", "F", "R", "De", "r", "N", "Rø" };

        /// <summary>
        /// Matrice di Strighe contenente i nomi delle scale termometriche
        /// </summary>
        public static readonly string[] NamUnitTemp =
         {"Kelvin","Celsius","Fahrenheit","Rankine","Delisle","Reamuer","Newton","Rømer" };

        /// <summary>
        /// Matrice di Strighe contenente le unità di misura delle scale termometriche
        /// </summary>
        public static readonly string[] SimbUnitTemp =
         {"k","°C","°F","°R","°De","°r","°N","°Rø" };

        /// <summary>
        /// Matrice di Strighe contenente i limiti inferiori delle scale termometriche
        /// </summary>
        public static readonly double[] AbsValueTemp =
            {0.0, -273.15, -459.67, 0.0, 559.725,  -218.52, -90.1395, -135.904};
        //    K,      C,       F,    R,    De,         r,      N,        Ro

        #endregion

        #region private
        private double _value;
        private string _SimbolTemp;
        private string _NomeUnita;
        private string _SimbolUnita;
        #endregion

        #endregion

        #region Property  

        public double Value { get => _value; set => _value = value; }
        public string SimbolTemp { get => _SimbolTemp; set => _SimbolTemp = value; }
        public string NomeUnita { get => _NomeUnita; set => _NomeUnita = value; }
        public string SimbolUnita { get => _SimbolUnita; set => _SimbolUnita = value; }
        public string[] NameUnitTemp { get => NamUnitTemp; }
        public string[] SimbolUnitTemp { get => SimbUnitTemp; }

        #endregion

    }
}
