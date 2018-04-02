using System;

namespace Misure
{
    public partial class Temperature
    {
        #region Override
        public override string ToString()
        {
            return Value.ToString() + " " +
                SimbolUnitTemp[Array.IndexOf(Simboli, SimbolTemp)];
        }
        #endregion
    }
}