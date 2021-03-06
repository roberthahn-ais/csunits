﻿// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures
{
    /// <summary>
    /// Interface representing a pair of measures given in two (potentially different) quantities
    /// </summary>
    /// <typeparam name="Q1">Quantity type of the first measure</typeparam>
    /// <typeparam name="Q2">Quantity type of the second measure</typeparam>
    public interface IMeasureDoublet<Q1, Q2> where Q1 : struct, IQuantity<Q1> where Q2 : struct, IQuantity<Q2>
    {
        /// <summary>
        /// Gets the first measure in the measure pair
        /// </summary>
        IMeasure<Q1> X { get; }

        /// <summary>
        /// Gets the second measure in the measure pair
        /// </summary>
        IMeasure<Q2> Y { get; }
    }
}