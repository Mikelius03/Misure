namespace Misure
{
    public partial class Temperature
    {
        #region Membri
        #region static
        public static readonly string[] Simboli        =
        { "K", "C", "F", "R", "De", "r", "N", "Ro" };

        public static readonly string[] NameUnitTemp   =
         {"Kelvin","Celsius","Fahrenheit","Rainke","Delisle","Reamuer","Newton","Romer" };

        public static readonly string[] SimbolUnitTemp =
         {"K","°C","°F","°R","°De","°r","°N","°Ro" };

        public static readonly double[] AbsValueTemp   =
         {0.0, -273.15, -523.67, 0.0, 559.725, -90.14, -218.52, -135.90};
        //    K,      C,       F,    R,     De,      N,       r,       Ro

        #endregion
        
        #region private
        private double _value;
        private string _SimbolTemp;
        private string _NomeUnita;
        private string _SimbolUnita;
        #endregion
        #endregion

        #region Property  
        public double       Value { get => _value; }
        public string  SimbolTemp { get => _SimbolTemp;  }
        public string   NomeUnita { get => _NomeUnita; }
        public string SimbolUnita { get => _SimbolUnita; }
        #endregion

    }
}
