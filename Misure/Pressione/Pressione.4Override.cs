using System;

namespace Misure
{
    namespace Conversioni
    {
        public partial class Pressione : IMisure
        {
            #region Override
            public override string ToString()
            {
                return _value.ToString() + " " +_unitSymbol;
            }
            #endregion
        }
    }
}