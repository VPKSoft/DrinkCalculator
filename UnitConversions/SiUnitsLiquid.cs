#region License
/*
MIT License

Copyright(c) 2021 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System.Diagnostics.CodeAnalysis;

namespace DrinkCalculator.UnitConversions
{
    /// <summary>
    /// A class for converting to and from the real SI units to other not so specified units.
    /// </summary>
    public class SiUnitsLiquid
    {
        /// <summary>
        /// The gallon.
        /// </summary>
        public const decimal Gallon = 3.785411784m;

        /// <summary>
        /// The quart.
        /// </summary>
        public const decimal Quart = Gallon / 4m;

        /// <summary>
        /// The pint.
        /// </summary>
        public const decimal Pint = Gallon / 8m;

        /// <summary>
        /// The cup.
        /// </summary>
        public const decimal Cup = Gallon / 16m;

        /// <summary>
        /// The ounce.
        /// </summary>
        public const decimal Ounce = Gallon / 128m;

        /// <summary>
        /// The litre.
        /// </summary>
        public const decimal Litre = 1m;

        // ReSharper disable once IdentifierTypo, its the SI system..
        public const decimal DeciLitre = 1m / 10;

        // ReSharper disable once CommentTypo, its the SI system..
        // ReSharper disable once IdentifierTypo, its the SI system..
        /// <summary>
        /// The centilitre.
        /// </summary>
        public const decimal CentiLitre = 1m / 100;

        // ReSharper disable once CommentTypo, its the SI system..
        // ReSharper disable once IdentifierTypo, its the SI system..
        /// <summary>
        /// The millilitre.
        /// </summary>
        public const decimal MilliLitre = 1m / 1000;

        // ReSharper disable thrice CommentTypo, its the SI system..
        // ReSharper disable once IdentifierTypo, its the SI system..
        /// <summary>
        /// Converts the specified <see cref="amount"/> to litres.
        /// </summary>
        /// <param name="amount">The amount in specified <see cref="unit"/>.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>The amount in litres.</returns>
        public static decimal ToLitres(decimal amount, UnitsEnum unit)
        {
            var oneUnit = OneUnit(unit);
            return oneUnit * amount;
        }


        /// <summary>
        /// Converts the specified <see cref="amount"/> to gallons.
        /// </summary>
        /// <param name="amount">The amount in specified <see cref="unit"/>.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>The amount in gallons.</returns>
        public static decimal ToGallons(decimal amount, UnitsEnum unit)
        {
            return ToLitres(amount, unit) / Gallon;
        }

        /// <summary>
        /// Converts a specified unit from one unit to another unit.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="fromUnit">The unit to convert from.</param>
        /// <param name="toUnit">The unit to convert to.</param>
        /// <returns>The amount in <see cref="toUnit"/> units.</returns>
        public static decimal UnitToAnother(decimal amount, UnitsEnum fromUnit, UnitsEnum toUnit)
        {
            amount = ToLitres(amount, fromUnit);

            return amount / OneUnit(toUnit);
        }

        /// <summary>
        /// Return the specified unit name as in many units of something.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="localization">An instance to a <see cref="TabDeliLocalization.TabDeliLocalization"/> class.</param>
        /// <returns>The specified unit name as in many units of something..</returns>
        [SuppressMessage("ReSharper", "StringLiteralTypo")] // fi-FI culture..
        public static string UnitName(UnitsEnum unit, TabDeliLocalization.TabDeliLocalization localization)
        {
            switch (unit)
            {
                case UnitsEnum.Gallon: return localization.GetMessage("txtGallons", "gallons");
                case UnitsEnum.Quart: return localization.GetMessage("txtQuarts", "quarts");
                case UnitsEnum.Pint: return localization.GetMessage("txtPints", "pints");
                case UnitsEnum.Cup: return localization.GetMessage("txtCups", "cups");
                case UnitsEnum.Ounce: return localization.GetMessage("txtOunces", "ounce");
                case UnitsEnum.Litre: return localization.GetMessage("txtLitres", "litres");
                case UnitsEnum.DeciLitre: return localization.GetMessage("txtDeciLitres", "decilitres");
                case UnitsEnum.CentiLitre: return localization.GetMessage("txtCentiLitres", "centilitres");
                case UnitsEnum.MilliLitre: return localization.GetMessage("txtMilliLitres", "millilitres");
                default: return localization.GetMessage("txtLitres", "litres");
            }
        }

        /// <summary>
        /// Return the specified unit in litres.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>The specified unit in litres.</returns>
        public static decimal OneUnit(UnitsEnum unit)
        {
            switch (unit)
            {
                case UnitsEnum.Gallon: return Gallon;
                case UnitsEnum.Quart: return Quart;
                case UnitsEnum.Pint: return Pint;
                case UnitsEnum.Cup: return Cup;
                case UnitsEnum.Ounce: return Ounce;
                case UnitsEnum.Litre: return Litre;
                case UnitsEnum.DeciLitre: return DeciLitre;
                case UnitsEnum.CentiLitre: return CentiLitre;
                case UnitsEnum.MilliLitre: return MilliLitre;
                default: return Litre;
            }
        }
    }
}
