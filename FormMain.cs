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
using System.Linq;
using System.Windows.Forms;
using DrinkCalculator.UnitConversions;

namespace DrinkCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pnDrinkControls.Width += SystemInformation.VerticalScrollBarWidth;

            cmbAlcoholUnit.ComboBox!.ValueMember = "key";
            cmbAlcoholUnit.ComboBox!.DisplayMember = "value";

            //Localization.OverrideLocale = "fi";

            Localization.GetLocalizedTexts(Properties.Resources.tabdeli_messages);

            LocalizeUi();

            DrinkItem.Localization = Localization;

            foreach (var value in (UnitsEnum[])Enum.GetValues(typeof(UnitsEnum)))
            {
                cmbAlcoholUnit.Items.Add(new KeyValuePair<UnitsEnum, string>(value, SiUnitsLiquid.UnitName(value, Localization)));
            }

            cmbAlcoholUnit.SelectedItem = new KeyValuePair<UnitsEnum, string>(UnitsEnum.CentiLitre, SiUnitsLiquid.UnitName(UnitsEnum.CentiLitre, Localization));
        }

        internal static TabDeliLocalization.TabDeliLocalization Localization { get; } = new();

        private void LocalizeUi()
        {
            Text = Localization.GetMessage("txtTitle", "Drink calculator");

            tsbAddEntry.Text = Localization.GetMessage("txtAddEntry", "Add entry");
            tsbAddEntry.ToolTipText = Localization.GetMessage("txtAddEntry", "Add entry");

            tsbClearAll.Text = Localization.GetMessage("txtClearAll", "Clear all");
            tsbClearAll.ToolTipText = Localization.GetMessage("txtClearAll", "Clear all");

            tslAlcoholVolumePercentage.ToolTipText = Localization.GetMessage("txtAlcoholVolumePercentage", "Alcohol volume percentage");
            tslTotalVolume.ToolTipText = Localization.GetMessage("txtTotalAmount", "Total amount");

            cmbAlcoholUnit.ToolTipText = Localization.GetMessage("txtTotalAmountUnit", "Total amount unit");
            lbCalories.Text = Localization.GetMessage("txtKCal", "Calories (kcal)") + @":";
        }

        private readonly List<DrinkItem> drinkItems = new();

        private void ItemValueChanged(object? sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            tslAlcoholVolumePercentage.Text = $@"{DrinkItem.CalculateItems(drinkItems.ToArray()):F2} %";
            tslTotalVolume.Text = $@"{DrinkItem.TotalVolume(((KeyValuePair<UnitsEnum, string>)cmbAlcoholUnit.SelectedItem).Key, drinkItems.ToArray()):F2}";
            tbCalories.Text = $@"{DrinkItem.TotalCalories(drinkItems.ToArray()):F1}";
        }

        private void ItemClose(object? sender, EventArgs e)
        {
            var item = (DrinkItem) sender!;
            drinkItems.Remove(item);

            foreach (var drinkItem in drinkItems)
            {
                if (item.Top < drinkItem.Top)
                {
                    drinkItem.Top -= item.Height;
                }
            }

            item.Close -= ItemClose;
            item.ValueChanged -= ItemValueChanged;

            pnDrinkControls.Controls.Remove(item);
            Calculate();
        }

        private void tsbAddEntry_Click(object sender, EventArgs e)
        {
            var item = new DrinkItem() {BorderStyle = BorderStyle.FixedSingle};
            item.Close += ItemClose;
            item.ValueChanged += ItemValueChanged;
            var top = drinkItems.Count > 0 ? drinkItems.Max(f => f.Bottom) : 0;
            drinkItems.Add(item);
            pnDrinkControls.Controls.Add(item);
            item.Top = top;
        }

        private void tsbClearAll_Click(object sender, EventArgs e)
        {
            foreach (var drinkItem in drinkItems)
            {
                drinkItem.Close -= ItemClose;
                drinkItem.ValueChanged -= ItemValueChanged;
                pnDrinkControls.Controls.Remove(drinkItem);
            }

            drinkItems.Clear();
            Calculate();
        }
    }
}
