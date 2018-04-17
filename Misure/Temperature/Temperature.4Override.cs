﻿namespace Misure
{
    namespace Conversioni
    {
        public partial class Temperature : IMisure
        {
            /// <summary>
            /// Override del metodo ToString()
            /// </summary>
            /// <returns>Stringa riferita all'oggetto instanziato</returns>
            public override string ToString()
            {
                return _value.ToString() + " " + _unitSymbol;
            }
        }
    }
}