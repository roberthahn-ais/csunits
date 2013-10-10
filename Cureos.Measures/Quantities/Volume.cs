﻿// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures.Quantities
{
    /// <summary>
    /// Implementation of the volume quantity
    /// </summary>
    public struct Volume : IQuantity<Volume>
    {
        #region FIELDS

        private static readonly QuantityDimension _dimension = QuantityDimension.Length ^ 3;

        public static readonly Unit<Volume> CubicMeter = new Unit<Volume>("m³");
        public static readonly Unit<Volume> Liter = new Unit<Volume>("l", Factors.Cube(Factors.Deci));
        public static readonly Unit<Volume> MilliLiter = new Unit<Volume>("ml", Factors.Cube(Factors.Deci) * Factors.Milli);
        public static readonly Unit<Volume> CubicDeciMeter = new Unit<Volume>("dm³", Factors.Cube(Factors.Deci));
        public static readonly Unit<Volume> CubicCentiMeter = new Unit<Volume>("cm³", Factors.Cube(Factors.Centi));
        public static readonly Unit<Volume> CubicMilliMeter = new Unit<Volume>("mm³", Factors.Cube(Factors.Milli));
        public static readonly Unit<Volume> USLiquidGallon = new Unit<Volume>("gal", Factors.CubicMetersPerUSLiquidGallon);

        #endregion

        #region Implementation of IQuantity<Q>

        /// <summary>
        /// Gets the physical dimension of the quantity in terms of SI units
        /// </summary>
        public QuantityDimension Dimension
        {
            get { return _dimension; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        IUnit IQuantity.StandardUnit
        {
            get { return StandardUnit; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        public IUnit<Volume> StandardUnit
        {
            get { return CubicMeter; }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing a fully qualified type name.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return GetType().Name;
        }

        #endregion
    }
}
