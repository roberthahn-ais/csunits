// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;

namespace Cureos.Measures
{
    /// <summary>
    /// Convenience class providing factors and support methods for applying amount conversion factors in e.g.
    /// physical unit definition
    /// </summary>
    public static class Factors
    {
#if DOUBLE
        public const double Yotta = 1.0e24;
        public const double Zetta = 1.0e21;
        public const double Exa = 1.0e18;
        public const double Peta = 1.0e15;
        public const double Tera = 1.0e12;
        public const double Giga = 1.0e9;
        public const double Mega = 1.0e6;
        public const double Kilo = 1.0e3;
        public const double Hecto = 1.0e2;
        public const double Deka = 1.0e1;
        public const double Deci = 1.0e-1;
        public const double Centi = 1.0e-2;
        public const double Milli = 1.0e-3;
        public const double Micro = 1.0e-6;
        public const double Nano = 1.0e-9;
        public const double Pico = 1.0e-12;
        public const double Femto = 1.0e-15;
        public const double Atto = 1.0e-18;
        public const double Zepto = 1.0e-21;
        public const double Yocto = 1.0e-24;
        public const double SecondsPerMinute = 60.0;
        public const double SecondsPerHour = SecondsPerMinute * 60.0;
        public const double SecondsPerDay = SecondsPerHour * 24.0;
        public const double SecondsPerWeek = SecondsPerDay * 7.0;
        public const double SecondsPerJulianYear = SecondsPerDay * 365.25;
        public const double KelvinCelsiusIntercept = 273.15;
        public const double KelvinFahrenheitIntercept = 459.67;
        public const double KelvinFahrenheitSlope = 5.0 / 9.0;
        public const double CoulombsPerElementaryCharge = 1.6021765314e-19;
        public const double JoulesPerElectronVolt = CoulombsPerElementaryCharge;
        public const double MetersPerAngstrom = 1.0e-10;
        public const double MetersPerInch = 0.0254;
        public const double MetersPerFoot = MetersPerInch * 12.0;
        public const double MetersPerYard = MetersPerFoot * 3.0;
        public const double MetersPerMile = MetersPerYard * 1760.0;
        public const double MetersPerNauticalMile = 1852.0;
        public const double SquareMetersPerBarn = 1.0e-28;
        public const double CubicMetersPerUSLiquidGallon = 3.78541178e-3;
        public const double KiloGramsPerElectronMass = 9.109382616e-31;
        public const double KiloGramsPerAtomicMassUnit = 1.6605388628e-27;
        public const double BecquerelPerCurie = 3.7e10;
        public const double PascalsPerTorr = 101325 / 760;
        public const double PascalsPerStandardAtmosphere = 1.01325e5;
        public const double PascalsPerTechnicalAtmosphere = 0.980665e5;
        public const double PascalsPerBar = 100000;
        public const double PascalsPerPoundsPerSquareInch = 6.8948e3;
        public static readonly double RadiansPerDegree = Math.PI / 180.0;
        public static readonly double RadiansPerMinute = RadiansPerDegree / 60.0;
        public static readonly double RadiansPerSecond = RadiansPerMinute / 60.0;

        public static double Square(double a) { return a * a; }
        public static double Cube(double a) { return a * a * a; }
#elif SINGLE
        public const float Yotta = 1.0e24f;
        public const float Zetta = 1.0e21f;
        public const float Exa = 1.0e18f;
        public const float Peta = 1.0e15f;
        public const float Tera = 1.0e12f;
        public const float Giga = 1.0e9f;
        public const float Mega = 1.0e6f;
        public const float Kilo = 1.0e3f;
        public const float Hecto = 1.0e2f;
        public const float Deka = 1.0e1f;
        public const float Deci = 1.0e-1f;
        public const float Centi = 1.0e-2f;
        public const float Milli = 1.0e-3f;
        public const float Micro = 1.0e-6f;
        public const float Nano = 1.0e-9f;
        public const float Pico = 1.0e-12f;
        public const float Femto = 1.0e-15f;
        public const float Atto = 1.0e-18f;
        public const float Zepto = 1.0e-21f;
        public const float Yocto = 1.0e-24f;
        public const float SecondsPerMinute = 60.0f;
        public const float SecondsPerHour = SecondsPerMinute * 60.0f;
        public const float SecondsPerDay = SecondsPerHour * 24.0f;
        public const float SecondsPerWeek = SecondsPerDay * 7.0f;
        public const float SecondsPerJulianYear = SecondsPerDay * 365.25f;
        public const float KelvinCelsiusIntercept = 273.15f;
        public const float KelvinFahrenheitIntercept = 459.67f;
        public const float KelvinFahrenheitSlope = 5.0f / 9.0f;
        public const float CoulombsPerElementaryCharge = 1.6021765314e-19f;
        public const float JoulesPerElectronVolt = CoulombsPerElementaryCharge;
        public const float MetersPerAngstrom = 1.0e-10f;
        public const float MetersPerInch = 0.0254f;
        public const float MetersPerFoot = MetersPerInch * 12.0f;
        public const float MetersPerYard = MetersPerFoot * 3.0f;
        public const float MetersPerMile = MetersPerYard * 1760.0f;
        public const float MetersPerNauticalMile = 1852.0f;
        public const float SquareMetersPerBarn = 1.0e-28f;
        public const float CubicMetersPerUSLiquidGallon = 3.78541178e-3f;
        public const float KiloGramsPerElectronMass = 9.109382616e-31f;
        public const float KiloGramsPerAtomicMassUnit = 1.6605388628e-27f;
        public const float BecquerelPerCurie = 3.7e10f;
        public const float PascalsPerTorr = 101325 / 760;
        public const float PascalsPerStandardAtmosphere = 1.01325e5;
        public const float PascalsPerTechnicalAtmosphere = 0.980665e5;
        public const float PascalsPerBar = 100000;
        public const float PascalsPerPoundsPerSquareInch = 6.8948e3;
        public static readonly float RadiansPerDegree = (float)Math.PI / 180.0f;
        public static readonly float RadiansPerMinute = RadiansPerDegree / 60.0f;
        public static readonly float RadiansPerSecond = RadiansPerMinute / 60.0f;

        public static float Square(float a) { return a * a; }
        public static float Cube(float a) { return a * a * a; }
#elif DECIMAL
        public const decimal Yotta = 1.0e24m;
        public const decimal Zetta = 1.0e21m;
        public const decimal Exa = 1.0e18m;
        public const decimal Peta = 1.0e15m;
        public const decimal Tera = 1.0e12m;
        public const decimal Giga = 1.0e9m;
        public const decimal Mega = 1.0e6m;
        public const decimal Kilo = 1.0e3m;
        public const decimal Hecto = 1.0e2m;
        public const decimal Deka = 1.0e1m;
        public const decimal Deci = 1.0e-1m;
        public const decimal Centi = 1.0e-2m;
        public const decimal Milli = 1.0e-3m;
        public const decimal Micro = 1.0e-6m;
        public const decimal Nano = 1.0e-9m;
        public const decimal Pico = 1.0e-12m;
        public const decimal Femto = 1.0e-15m;
        public const decimal Atto = 1.0e-18m;
        public const decimal Zepto = 1.0e-21m;
        public const decimal Yocto = 1.0e-24m;
        public const decimal SecondsPerMinute = 60.0m;
        public const decimal SecondsPerHour = SecondsPerMinute * 60.0m;
        public const decimal SecondsPerDay = SecondsPerHour * 24.0m;
        public const decimal SecondsPerWeek = SecondsPerDay * 7.0m;
        public const decimal SecondsPerJulianYear = SecondsPerDay * 365.25m;
        public const decimal KelvinCelsiusIntercept = 273.15m;
        public const decimal KelvinFahrenheitIntercept = 459.67m;
        public const decimal KelvinFahrenheitSlope = 5.0m / 9.0m;
        public const decimal CoulombsPerElementaryCharge = 1.6021765314e-19m;
        public const decimal JoulesPerElectronVolt = CoulombsPerElementaryCharge;
        public const decimal MetersPerAngstrom = 1.0e-10m;
        public const decimal MetersPerInch = 0.0254m;
        public const decimal MetersPerFoot = MetersPerInch * 12.0m;
        public const decimal MetersPerYard = MetersPerFoot * 3.0m;
        public const decimal MetersPerMile = MetersPerYard * 1760.0m;
        public const decimal MetersPerNauticalMile = 1852.0m;
        public const decimal SquareMetersPerBarn = 1.0e-28m;
        public const decimal CubicMetersPerUSLiquidGallon = 3.78541178e-3m;
        public const decimal KiloGramsPerElectronMass = 9.109382616e-31m;
        public const decimal KiloGramsPerAtomicMassUnit = 1.6605388628e-27m;
        public const decimal BecquerelPerCurie = 3.7e10m;
        public const decimal PascalsPerTorr = 101325 / 760;
        public const decimal PascalsPerStandardAtmosphere = 1.01325e5;
        public const decimal PascalsPerTechnicalAtmosphere = 0.980665e5;
        public const decimal PascalsPerBar = 100000;
        public const decimal PascalsPerPoundsPerSquareInch = 6.8948e3;
        public static readonly decimal RadiansPerDegree = (decimal)Math.PI / 180.0m;
        public static readonly decimal RadiansPerMinute = RadiansPerDegree / 60.0m;
        public static readonly decimal RadiansPerSecond = RadiansPerMinute / 60.0m;

        public static decimal Square(decimal a) { return a * a; }
        public static decimal Cube(decimal a) { return a * a * a; }
#endif
    }
}