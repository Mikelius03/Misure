namespace Misure
{
    public partial class Temperature
    {
        #region Campi

        #region static
        /// <summary>
        /// Matrice di Stri ghe contenenti i sinboli delle scale termometriche
        /// </summary>
        public static readonly string[] Simboli        =
        { "k", "C", "F", "R", "De", "r", "N", "Rø" };

        /// <summary>
        /// Matrice di Stri ghe contenenti i nomi delle scale termometriche
        /// </summary>
        public static readonly string[] NameUnitTemp   =
         {"Kelvin","Celsius","Fahrenheit","Rankine","Delisle","Reamuer","Newton","Rømer" };

        /// <summary>
        /// Matrice di Strighe contenente le unità di misura delle scale termometriche
        /// </summary>
        public static readonly string[] SimbolUnitTemp =
         {"k","°C","°F","°R","°De","°r","°N","°Rø" };

        /// <summary>
        /// Matrice di Stri ghe contenenti i limiti inferiori delle scale termometriche
        /// </summary>
        public static readonly double[] AbsValueTemp   =
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

        public double       Value { get => _value;       private set => _value       = value; }
        public string  SimbolTemp { get => _SimbolTemp;  private set => _SimbolTemp  = value; }
        public string   NomeUnita { get => _NomeUnita;   private set => _NomeUnita   = value; }
        public string SimbolUnita { get => _SimbolUnita; private set => _SimbolUnita = value; }
       
        #endregion

    }
}
