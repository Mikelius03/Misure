namespace Misure
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Misure.IMisure" />
    public partial class Pressione:IMisure
    {
        #region Campi

        #region static
        /// <summary>
        /// Matrice di Stri ghe contenenti i sinboli delle scale termometriche
        /// </summary>
        public static readonly string[] Simboli        =
        { "Pa", "bar", "torr", "mmH2O", "atm", "kgf", "ata", "Ba" };

        /// <summary>
        /// Matrice di Stri ghe contenenti i nomi delle scale termometriche
        /// </summary>
        public static readonly string[] namUnitTemp =
         {"Pascal", "Bar", "Torr", "millimetri H2O", "Atmosfere",
                "Kilogrammi forza", "atmosfere tec", "barye" };

        /// <summary>
        /// Matrice di Strighe contenente le unità di misura delle scale termometriche
        /// </summary>
        public static readonly string[] SimbUnitTemp =
         {"Pa", "bar", "torr", "mmH2O", "atm", "kgf", "ata", "Ba" };

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

        public double       Value { get => _value;       set => _value       = value; }
        public string  SimbolTemp { get => _SimbolTemp;  set => _SimbolTemp  = value; }
        public string   NomeUnita { get => _NomeUnita;   set => _NomeUnita   = value; }
        public string SimbolUnita { get => _SimbolUnita; set => _SimbolUnita = value; }

        public string[] NameUnitTemp { get => namUnitTemp; }
        public string[] SimbolUnitTemp { get => SimbUnitTemp; }

        #endregion

    }
}
