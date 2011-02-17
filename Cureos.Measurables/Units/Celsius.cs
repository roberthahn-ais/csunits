// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

#if SINGLE
using AmountType = System.Single;
#elif DECIMAL
using AmountType = System.Decimal;
#elif DOUBLE
using AmountType = System.Double;
#endif

namespace Cureos.Measurables.Units
{
    public sealed class Celsius : GenericUnit
    {
        #region FIELDS

        public static readonly Celsius Instance = new Celsius();

        #endregion

        #region CONSTRUCTORS

        private Celsius()
            : base("�C", Kelvin.Instance, t => t + (AmountType)273.15, t => t - (AmountType)273.15)
        {

        }

        #endregion
    }
}