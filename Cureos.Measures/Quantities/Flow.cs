// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures.Quantities
{
    /// <summary>
    /// Implementation of the gas flow quantity
    /// </summary>
    public struct Flow : IQuantity<Flow>
    {
        #region FIELDS

        private static readonly QuantityDimension _dimension = (QuantityDimension.Length ^ 3) * (QuantityDimension.Time ^ -1);

        /// <summary>
        /// Standard Cubic Centimeter per Minute, indicating cc/min at 0°C at 1 atmospheric pressure.
        /// </summary>
        public static readonly Unit<Flow> StandardCubicCentimeterPerMinute = new Unit<Flow>("sccm");        
        
        /// <summary>
        /// Standard Liter per Minute, indicating L/min at 0°C at 1 atmospheric pressure.       
        /// </summary>
        public static readonly Unit<Flow> StandardLiterPerMinute = new Unit<Flow>("slm", Factors.Milli);

        #endregion

        #region Implementation of IQuantity<Pressure>

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
        public IUnit<Flow> StandardUnit
        {
            get { return StandardCubicCentimeterPerMinute; }
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
