using System;

namespace Misure
{
    public partial class Temperature : IMisure
    {
        /// <summary>
        /// Ovveride del metodo ToString()
        /// </summary>
        /// <returns>Stringa riferita all'oggetto instanziato</returns>
        public override string ToString()
        {
            return Value.ToString() + " " +
                SimbolUnitTemp[Array.IndexOf(Simboli, SimbolTemp)];
        }
    }
}