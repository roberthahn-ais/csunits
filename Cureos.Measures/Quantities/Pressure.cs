// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures.Quantities
{
	/// <summary>
	/// Implementation of the pressure quantity
	/// </summary>
	public struct Pressure : IQuantity<Pressure>
	{
		#region FIELDS

	    private static readonly QuantityDimension _dimension = (QuantityDimension.Length ^ -1) * QuantityDimension.Mass *
	                                                           (QuantityDimension.Time ^ -2);

		public static readonly Unit<Pressure> Pascal = new Unit<Pressure>("Pa");
	    public static readonly Unit<Pressure> KiloPascal = new Unit<Pressure>(UnitPrefix.Kilo);
	    public static readonly Unit<Pressure> MegaPascal = new Unit<Pressure>(UnitPrefix.Mega);
	    public static readonly Unit<Pressure> GigaPascal = new Unit<Pressure>(UnitPrefix.Giga);
	    public static readonly Unit<Pressure> MilliPascal = new Unit<Pressure>(UnitPrefix.Milli);
	    public static readonly Unit<Pressure> MicroPascal = new Unit<Pressure>(UnitPrefix.Micro);
	    public static readonly Unit<Pressure> NanoPascal = new Unit<Pressure>(UnitPrefix.Nano);

		public static readonly Unit<Pressure> Torr = new Unit<Pressure>("Torr", Factors.PascalsPerTorr);
		public static readonly Unit<Pressure> MilliTorr = new Unit<Pressure>("mTorr", Factors.PascalsPerTorr * Factors.Milli);
		
		public static readonly Unit<Pressure> Bar = new Unit<Pressure>("bar", Factors.PascalsPerBar);
		public static readonly Unit<Pressure> KiloBar = new Unit<Pressure>("kbar", Factors.PascalsPerBar * Factors.Kilo);
		public static readonly Unit<Pressure> MegaBar = new Unit<Pressure>("Mbar", Factors.PascalsPerBar * Factors.Mega);
		public static readonly Unit<Pressure> MilliBar = new Unit<Pressure>("mbar", Factors.PascalsPerBar * Factors.Milli);

		public static readonly Unit<Pressure> TechnicalAtmosphere = new Unit<Pressure>("at", Factors.PascalsPerTechnicalAtmosphere);
		public static readonly Unit<Pressure> StandardAtmosphere = new Unit<Pressure>("atm", Factors.PascalsPerStandardAtmosphere);

		public static readonly Unit<Pressure> PoundsPerSquareInch = new Unit<Pressure>("psi", Factors.PascalsPerPoundsPerSquareInch);
		public static readonly Unit<Pressure> PoundsPerSquareInchGage = new Unit<Pressure>("psig", Factors.PascalsPerPoundsPerSquareInch);

		public static readonly Unit<Pressure> PoundsPerSquareInchAbsolute = new Unit<Pressure>(
			"psia",
			a => a * Factors.PascalsPerPoundsPerSquareInch + Factors.PascalsPerStandardAtmosphere,
			a => (a - Factors.PascalsPerStandardAtmosphere) / Factors.PascalsPerPoundsPerSquareInch);

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
		public IUnit<Pressure> StandardUnit
		{
			get { return Pascal; }
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
