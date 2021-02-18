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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DrinkCalculator.UnitConversions;

namespace DrinkCalculator
{
    /// <summary>
    /// A control representing an ingredient in an alcohol beverage.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [DefaultEvent(nameof(ValueChanged))]
    public partial class DrinkItem : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrinkItem"/> class.
        /// </summary>
        public DrinkItem()
        {
            InitializeComponent();
            ParentChanged += drinkItem_ParentChanged;
            Disposed += drinkItem_Disposed;

            cmbUnit.ValueMember = "key";
            cmbUnit.DisplayMember = "value";

            lbLiquidAmount.Text = Localization.GetMessage("txtAmount", "Amount");
            lbVolumePercentage.Text = Localization.GetMessage("txtVolumePercentage", "Alcohol percentage (vol-%)");
            lbUnit.Text = Localization.GetMessage("txtUnit", "Unit");
            lbCalories.Text = Localization.GetMessage("txtKCal", "Calories (kcal)");

            foreach (var value in (UnitsEnum[])Enum.GetValues(typeof(UnitsEnum)))
            {
                cmbUnit.Items.Add(new KeyValuePair<UnitsEnum, string>(value, SiUnitsLiquid.UnitName(value, Localization)));
            }

            cmbUnit.SelectedItem = new KeyValuePair<UnitsEnum, string>(UnitsEnum.CentiLitre, SiUnitsLiquid.UnitName(UnitsEnum.CentiLitre, Localization));
        }

        /// <summary>
        /// Gets or sets the localization class instance.
        /// </summary>
        /// <value>The the localization class instance.</value>
        public static TabDeliLocalization.TabDeliLocalization Localization { get; set; } = new();

        /// <summary>
        /// Gets the liquid amount.
        /// </summary>
        /// <value>The liquid amount.</value>
        [Description("The amount of the liquid."), Category("Drink")]
        public decimal LiquidAmount
        {
            get => nudLiquidAmount.Value;
            set => nudLiquidAmount.Value = value;
        }

        /// <summary>
        /// Gets or sets the alcohol volume percentage of the liquid.
        /// </summary>
        /// <value>The alcohol volume percentage of the liquid.</value>
        [Description("The alcohol percentage of the liquid."), Category("Drink")]
        public decimal AlcoholPercentage
        {
            get => nudVolumePercentage.Value;
            set => nudVolumePercentage.Value = value;
        }

        /// <summary>
        /// Gets or sets the unit of the <see cref="LiquidAmount"/>.
        /// </summary>
        /// <value>The the unit of the <see cref="LiquidAmount"/>.</value>
        [Description("The the unit of the liquid amount."), Category("Drink")]
        public UnitsEnum Unit
        {
            get => ((KeyValuePair<UnitsEnum, string>) cmbUnit.SelectedItem).Key;
            set => cmbUnit.SelectedItem =
                new KeyValuePair<UnitsEnum, string>(value, SiUnitsLiquid.UnitName(value, Localization));
        }

        private UnitsEnum? targetUnit;

        /// <summary>
        /// Gets or sets the target unit for the <see cref="NonAlcoholLiquidAmount"/> and <see cref="AlcoholLiquidAmount"/> properties.
        /// </summary>
        /// <value>The target unit for the <see cref="NonAlcoholLiquidAmount"/> and <see cref="AlcoholLiquidAmount"/> properties.</value>
        [Description("The target unit for the NonAlcoholLiquidAmount and AlcoholLiquidAmount properties."), Category("Drink")]
        public UnitsEnum TargetUnit
        {
            get => targetUnit ?? Unit;
            set => targetUnit = value;
        }

        /// <summary>
        /// Gets or sets the close button image.
        /// </summary>
        /// <value>The close button image.</value>
        [Description("The close button image."), Category("Appearance")]
        public Image CloseButtonImage
        {
            get => pnCloseBox.BackgroundImage;
            set => pnCloseBox.BackgroundImage = value;
        }

        /// <summary>
        /// Gets the non-alcoholic liquid amount.
        /// </summary>
        /// <value>The non-alcoholic liquid amount.</value>
        [Browsable(false)]
        public decimal NonAlcoholLiquidAmount => SiUnitsLiquid.UnitToAnother(LiquidAmount * (100 - AlcoholPercentage) / 100, Unit, TargetUnit);

        /// <summary>
        /// Gets the alcoholic liquid amount.
        /// </summary>
        /// <value>The alcoholic liquid amount.</value>
        [Browsable(false)]
        public decimal AlcoholLiquidAmount => SiUnitsLiquid.UnitToAnother(LiquidAmount * AlcoholPercentage / 100, Unit, TargetUnit);

        /// <summary>
        /// Gets the alcohol amount in specifies units.
        /// </summary>
        /// <param name="unit">The unit to get the alcohol amount in.</param>
        /// <returns>The alcoholic liquid amount.</returns>
        public decimal AlcoholAmountInUnits(UnitsEnum unit)
        {
            return SiUnitsLiquid.UnitToAnother(LiquidAmount * AlcoholPercentage / 100, Unit, unit);
        }

        /// <summary>
        /// Gets the non-alcoholic amount in specifies units.
        /// </summary>
        /// <param name="unit">The unit to get the non-alcoholic amount in.</param>
        /// <returns>The non-alcoholic liquid amount.</returns>
        public decimal NonAlcoholAmountInUnits(UnitsEnum unit)
        {
            return SiUnitsLiquid.UnitToAnother(LiquidAmount * (100 - AlcoholPercentage) / 100, Unit, unit);
        }

        /// <summary>
        /// Gets the total amount in specifies units.
        /// </summary>
        /// <param name="unit">The unit to get the total amount in.</param>
        /// <returns>The total liquid amount.</returns>
        public decimal AmountInUnits(UnitsEnum unit)
        {
            return SiUnitsLiquid.UnitToAnother(LiquidAmount, Unit, unit);
        }

        private void drinkItem_Disposed(object? sender, EventArgs e)
        {
            ParentChanged -= drinkItem_ParentChanged;
            Disposed -= drinkItem_Disposed;
        }

        private void drinkItem_ParentChanged(object? sender, EventArgs e)
        {
            Size = DefaultSize;
        }

        /// <summary>
        /// Calculates the alcohol volume percentage of specified <see cref="DrinkItem"/> instances.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>The total alcohol volume percentage of specified <see cref="DrinkItem"/> instances.</returns>
        public static decimal CalculateItems(params DrinkItem[] items)
        {
            var alcohol = 0m;
            var nonAlcohol = 0m;
            foreach (var drinkItem in items)
            {
                alcohol += drinkItem.AlcoholAmountInUnits(UnitsEnum.Litre);
                nonAlcohol += drinkItem.NonAlcoholAmountInUnits(UnitsEnum.Litre);
            }

            var divider = alcohol + nonAlcohol;

            return divider == 0 ? 0 : alcohol / divider * 100;
        }

        /// <summary>
        /// Calculates the total volume in specified unit of the specified <see cref="DrinkItem"/> instances.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="items">The items.</param>
        /// <returns>The total volume in specified unit of the specified <see cref="DrinkItem"/> instances.</returns>
        public static decimal TotalVolume(UnitsEnum unit, params DrinkItem[] items)
        {
            var volume = 0m;
            foreach (var drinkItem in items)
            {
                volume += drinkItem.AmountInUnits(unit);
            }

            return volume;
        }

        /// <summary>
        /// The amount of grams in a litre of alcohol.
        /// </summary>
        public const decimal GramsPerLitre = 0.7894m * 1000;

        /// <summary>
        /// The amount of kilo calories (kcal) in a gram of alcohol.
        /// </summary>
        public const decimal KiloCaloriesPerGram = 7m;

        /// <summary>
        /// Gets the total amount of kilo calories (kcal) of the alcohol amount in the drink.
        /// </summary>
        /// <value>The total alcohol calories.</value>
        [Browsable(false)]
        public decimal TotalAlcoholCalories =>
            AlcoholAmountInUnits(UnitsEnum.Litre) * GramsPerLitre * KiloCaloriesPerGram;

        /// <summary>
        /// Gets the total amount of kilo calories (kcal) of the specified <see cref="DrinkItem"/> instances.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>The total amount of kilo calories (kcal) of the specified <see cref="DrinkItem"/> instances.</returns>
        public static decimal TotalCalories(params DrinkItem[] items)
        {
            var result = 0m;

            foreach (var drinkItem in items)
            {
                result += drinkItem.TotalAlcoholCalories;
            }

            return result;
        }

        /// <summary>
        /// Gets the default size of the control.
        /// </summary>
        /// <value>The default size.</value>
        protected override Size DefaultSize => new(600, 50);

        private void pnCloseBox_Click(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
            Close?.Invoke(this,EventArgs.Empty);
        }

        /// <summary>
        /// Occurs when the user clicks the close button of this control.
        /// </summary>
        [Description("Occurs when the user clicks the close button of this control."), Category("Drink")]
        public EventHandler<EventArgs>? Close;

        /// <summary>
        /// Occurs when one of the values within the control has changed.
        /// </summary>
        [Description("Occurs when one of the values within the control has changed."), Category("Drink")]
        public EventHandler<EventArgs>? ValueChanged;

        private void control_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
            tbCalories.Text = $@"{TotalAlcoholCalories:F1}";
        }
    }
}
