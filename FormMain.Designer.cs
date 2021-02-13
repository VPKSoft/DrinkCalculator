
namespace DrinkCalculator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnDrinkControls = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbAddEntry = new System.Windows.Forms.ToolStripButton();
            this.tsbClearAll = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslAlcoholVolumePercentage = new System.Windows.Forms.ToolStripLabel();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslTotalVolume = new System.Windows.Forms.ToolStripLabel();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbAlcoholUnit = new System.Windows.Forms.ToolStripComboBox();
            this.tlpMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDrinkControls
            // 
            this.pnDrinkControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnDrinkControls.AutoScroll = true;
            this.pnDrinkControls.Location = new System.Drawing.Point(3, 28);
            this.pnDrinkControls.Name = "pnDrinkControls";
            this.pnDrinkControls.Size = new System.Drawing.Size(530, 307);
            this.pnDrinkControls.TabIndex = 4;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tsMain, 0, 0);
            this.tlpMain.Controls.Add(this.pnDrinkControls, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(564, 338);
            this.tlpMain.TabIndex = 7;
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddEntry,
            this.tsbClearAll,
            this.tss1,
            this.tslAlcoholVolumePercentage,
            this.tss2,
            this.tslTotalVolume,
            this.tss3,
            this.cmbAlcoholUnit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(564, 25);
            this.tsMain.TabIndex = 0;
            // 
            // tsbAddEntry
            // 
            this.tsbAddEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddEntry.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddEntry.Image")));
            this.tsbAddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddEntry.Name = "tsbAddEntry";
            this.tsbAddEntry.Size = new System.Drawing.Size(23, 22);
            this.tsbAddEntry.Text = "Add entry";
            this.tsbAddEntry.Click += new System.EventHandler(this.tsbAddEntry_Click);
            // 
            // tsbClearAll
            // 
            this.tsbClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearAll.Image")));
            this.tsbClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearAll.Name = "tsbClearAll";
            this.tsbClearAll.Size = new System.Drawing.Size(23, 22);
            this.tsbClearAll.Text = "Clear all";
            this.tsbClearAll.Click += new System.EventHandler(this.tsbClearAll_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslAlcoholVolumePercentage
            // 
            this.tslAlcoholVolumePercentage.Name = "tslAlcoholVolumePercentage";
            this.tslAlcoholVolumePercentage.Size = new System.Drawing.Size(26, 22);
            this.tslAlcoholVolumePercentage.Text = "0 %";
            this.tslAlcoholVolumePercentage.ToolTipText = "Alcohol volume percentage";
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslTotalVolume
            // 
            this.tslTotalVolume.Name = "tslTotalVolume";
            this.tslTotalVolume.Size = new System.Drawing.Size(13, 22);
            this.tslTotalVolume.Text = "0";
            this.tslTotalVolume.ToolTipText = "Total amount";
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbAlcoholUnit
            // 
            this.cmbAlcoholUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlcoholUnit.Name = "cmbAlcoholUnit";
            this.cmbAlcoholUnit.Size = new System.Drawing.Size(121, 25);
            this.cmbAlcoholUnit.ToolTipText = "Total amount unit";
            this.cmbAlcoholUnit.SelectedIndexChanged += new System.EventHandler(this.ItemValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 362);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Drink Calculator";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDrinkControls;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbAddEntry;
        private System.Windows.Forms.ToolStripButton tsbClearAll;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripLabel tslAlcoholVolumePercentage;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripLabel tslTotalVolume;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripComboBox cmbAlcoholUnit;
    }
}

