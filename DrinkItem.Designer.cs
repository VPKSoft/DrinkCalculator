
namespace DrinkCalculator
{
    partial class DrinkItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkItem));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbVolumePercentage = new System.Windows.Forms.Label();
            this.nudVolumePercentage = new System.Windows.Forms.NumericUpDown();
            this.lbLiquidAmount = new System.Windows.Forms.Label();
            this.nudLiquidAmount = new System.Windows.Forms.NumericUpDown();
            this.lbUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.pnCloseBox = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiquidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.Controls.Add(this.lbVolumePercentage, 0, 0);
            this.tlpMain.Controls.Add(this.nudVolumePercentage, 0, 1);
            this.tlpMain.Controls.Add(this.lbLiquidAmount, 1, 0);
            this.tlpMain.Controls.Add(this.nudLiquidAmount, 1, 1);
            this.tlpMain.Controls.Add(this.lbUnit, 2, 0);
            this.tlpMain.Controls.Add(this.cmbUnit, 2, 1);
            this.tlpMain.Controls.Add(this.pnCloseBox, 3, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(530, 50);
            this.tlpMain.TabIndex = 0;
            // 
            // lbVolumePercentage
            // 
            this.lbVolumePercentage.AutoSize = true;
            this.lbVolumePercentage.Location = new System.Drawing.Point(3, 0);
            this.lbVolumePercentage.Name = "lbVolumePercentage";
            this.lbVolumePercentage.Size = new System.Drawing.Size(152, 15);
            this.lbVolumePercentage.TabIndex = 0;
            this.lbVolumePercentage.Text = "Alcohol percentage (vol-%)";
            // 
            // nudVolumePercentage
            // 
            this.nudVolumePercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVolumePercentage.DecimalPlaces = 2;
            this.nudVolumePercentage.Location = new System.Drawing.Point(3, 18);
            this.nudVolumePercentage.Name = "nudVolumePercentage";
            this.nudVolumePercentage.Size = new System.Drawing.Size(158, 23);
            this.nudVolumePercentage.TabIndex = 1;
            this.nudVolumePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVolumePercentage.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // lbLiquidAmount
            // 
            this.lbLiquidAmount.AutoSize = true;
            this.lbLiquidAmount.Location = new System.Drawing.Point(167, 0);
            this.lbLiquidAmount.Name = "lbLiquidAmount";
            this.lbLiquidAmount.Size = new System.Drawing.Size(51, 15);
            this.lbLiquidAmount.TabIndex = 2;
            this.lbLiquidAmount.Text = "Amount";
            // 
            // nudLiquidAmount
            // 
            this.nudLiquidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLiquidAmount.DecimalPlaces = 1;
            this.nudLiquidAmount.Location = new System.Drawing.Point(167, 18);
            this.nudLiquidAmount.Name = "nudLiquidAmount";
            this.nudLiquidAmount.Size = new System.Drawing.Size(159, 23);
            this.nudLiquidAmount.TabIndex = 3;
            this.nudLiquidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLiquidAmount.ValueChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(332, 0);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(29, 15);
            this.lbUnit.TabIndex = 4;
            this.lbUnit.Text = "Unit";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(332, 18);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(159, 23);
            this.cmbUnit.TabIndex = 5;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // pnCloseBox
            // 
            this.pnCloseBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCloseBox.BackgroundImage")));
            this.pnCloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCloseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCloseBox.Location = new System.Drawing.Point(497, 18);
            this.pnCloseBox.Name = "pnCloseBox";
            this.pnCloseBox.Size = new System.Drawing.Size(30, 23);
            this.pnCloseBox.TabIndex = 6;
            this.pnCloseBox.Click += new System.EventHandler(this.pnCloseBox_Click);
            // 
            // DrinkItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "DrinkItem";
            this.Size = new System.Drawing.Size(530, 50);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiquidAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lbVolumePercentage;
        private System.Windows.Forms.NumericUpDown nudVolumePercentage;
        private System.Windows.Forms.Label lbLiquidAmount;
        private System.Windows.Forms.NumericUpDown nudLiquidAmount;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Panel pnCloseBox;
    }
}
