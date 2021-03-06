// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;

#if SINGLE
using AmountType = System.Single;
#elif DECIMAL
using AmountType = System.Decimal;
#elif DOUBLE
using AmountType = System.Double;
#endif

namespace Cureos.Measures
{
    /// <summary>
    /// Representation of a physical unit of a specific quanity
    /// </summary>
    /// <typeparam name="Q">Quantity type with which the unit is associated</typeparam>
    public sealed class Unit<Q> : IUnit<Q> where Q : struct, IQuantity<Q>
    {
        #region CONSTRUCTORS

        /// <summary>
        /// Initialize a physical unit object that is the standard unit of the specific quantity
        /// </summary>
        /// <param name="iSymbol">Unit display symbol</param>
        public Unit(string iSymbol) :
            this(iSymbol, a => a, a => a)
        {
        }

        /// <summary>
        /// Convenience constructor for initializing prefixed non-standard unit
        /// </summary>
        /// <param name="iPrefix">Prefix to use in unit naming and scaling vis-a-vis standard unit</param>
        public Unit(UnitPrefix iPrefix) :
            this(String.Format("{0}{1}", iPrefix.GetSymbol(), default(Q).StandardUnit), iPrefix.GetFactor())
        {
        }

        /// <summary>
        /// Initialize a physical unit object
        /// </summary>
        /// <param name="iSymbol">Unit display symbol</param>
        /// <param name="iToStandardUnitFactor">Amount converter factor from this unit to quantity's standard unit</param>
        public Unit(string iSymbol, AmountType iToStandardUnitFactor) :
            this(iSymbol, a => a * iToStandardUnitFactor, a => a / iToStandardUnitFactor)
        {
        }

        /// <summary>
        /// Initializes a physical unit object
        /// </summary>
        /// <param name="iSymbol">Unit display symbol</param>
        /// <param name="iAmountToStandardUnitConverter">Amount converter function from this unit to quantity's standard unit</param>
        /// <param name="iAmountFromStandardUnitConverter">Amount converter function from quantity's standard unit to this unit</param>
        public Unit(string iSymbol, Func<AmountType, AmountType> iAmountToStandardUnitConverter,
            Func<AmountType, AmountType> iAmountFromStandardUnitConverter)
        {
            Symbol = iSymbol;
            DisplayName = String.Empty;
            AmountToStandardUnitConverter = iAmountToStandardUnitConverter;
            AmountFromStandardUnitConverter = iAmountFromStandardUnitConverter;
        }

        #endregion

        #region Implementation of IUnit<Q>

        /// <summary>
        /// Gets the quantity associated with the unit
        /// </summary>
        IQuantity IUnit.Quantity
        {
            get { return Quantity; }
        }

        /// <summary>
        /// Gets the typed quantity associated with the unit
        /// </summary>
        public IQuantity<Q> Quantity
        {
            get { return default(Q); }
        }

        /// <summary>
        /// Gets the display symbol of the unit
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// Gets or sets the fully qualified display name of the unit
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets the amount converter function from the current unit to the standard unit 
        /// of the specified quantity
        /// </summary>
        public Func<AmountType, AmountType> AmountToStandardUnitConverter { get; private set; }

        /// <summary>
        /// Gets the amount converter function from the standard unit of the specified quantity
        /// to the current unit
        /// </summary>
        public Func<AmountType, AmountType> AmountFromStandardUnitConverter { get; private set; }

        #endregion

        #region METHODS

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="Symbol">unit symbol</see>
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return Symbol;
        }

        #endregion
    }
}