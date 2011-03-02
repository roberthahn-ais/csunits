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

namespace Cureos.Measures
{
    public interface IMeasureArray
    {
        AmountType[] MeasuredAmounts { get; }

        AmountType[] ReferenceUnitAmounts { get; }

        Quantity MeasuredQuantity { get; }

        Unit MeasuredUnit { get; }

        Unit ReferenceUnit { get; }

        AmountType[] GetAmounts(Unit iUnit);

        string ToString(Unit iUnit);
    }
}