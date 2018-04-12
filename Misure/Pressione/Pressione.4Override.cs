﻿using System;

namespace Misure
{
    public partial class Pressione : IMisure
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