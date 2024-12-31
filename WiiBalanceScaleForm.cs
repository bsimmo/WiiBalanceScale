/*********************************************************************************
WiiBalanceScale

MIT License

Copyright (c) 2017-2023 Bernhard Schelling

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
**********************************************************************************/

using System;
using System.Windows.Forms;

namespace WiiBalanceScale
{
    class WiiBalanceScaleForm : Form
    {
        public WiiBalanceScaleForm()
        {
            InitializeComponent();
            try { this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName); } catch (Exception) { }
        }

        internal Label lblWeight;
        internal Button btnReset;
        internal Label lblQuality;
        internal Label lblUnit1;
        internal GroupBox unitSelector;
        internal RadioButton unitSelectorKg;
        internal RadioButton unitSelectorLb;
        internal RadioButton unitSelectorStone;
        internal Label lblUnit2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.unitSelector = new System.Windows.Forms.GroupBox();
            this.unitSelectorStone = new System.Windows.Forms.RadioButton();
            this.unitSelectorKg = new System.Windows.Forms.RadioButton();
            this.unitSelectorLb = new System.Windows.Forms.RadioButton();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.unitSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.Font = new System.Drawing.Font("Lucida Console", 100F);
            this.lblWeight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWeight.Location = new System.Drawing.Point(0, 102);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(1231, 230);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "088.71";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleName = "Zero the scale";
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.Location = new System.Drawing.Point(142, 391);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(947, 79);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Zero";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblQuality
            // 
            this.lblQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuality.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(0, 313);
            this.lblQuality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(1231, 75);
            this.lblQuality.TabIndex = 8;
            this.lblQuality.Text = "⏳⏳⌛✹✹";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit1
            // 
            this.lblUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnit1.Location = new System.Drawing.Point(889, 79);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(102, 69);
            this.lblUnit1.TabIndex = 9;
            this.lblUnit1.Text = "lb";
            // 
            // unitSelector
            // 
            this.unitSelector.Controls.Add(this.unitSelectorStone);
            this.unitSelector.Controls.Add(this.unitSelectorKg);
            this.unitSelector.Controls.Add(this.unitSelectorLb);
            this.unitSelector.Location = new System.Drawing.Point(13, 11);
            this.unitSelector.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelector.Name = "unitSelector";
            this.unitSelector.Padding = new System.Windows.Forms.Padding(4);
            this.unitSelector.Size = new System.Drawing.Size(572, 55);
            this.unitSelector.TabIndex = 0;
            this.unitSelector.TabStop = false;
            this.unitSelector.Text = "Units";
            this.unitSelector.Visible = false;
            // 
            // unitSelectorStone
            // 
            this.unitSelectorStone.AutoSize = true;
            this.unitSelectorStone.Checked = true;
            this.unitSelectorStone.Location = new System.Drawing.Point(393, 23);
            this.unitSelectorStone.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelectorStone.Name = "unitSelectorStone";
            this.unitSelectorStone.Size = new System.Drawing.Size(156, 20);
            this.unitSelectorStone.TabIndex = 2;
            this.unitSelectorStone.TabStop = true;
            this.unitSelectorStone.Text = "Stone/Pounds (st/lbs)";
            this.unitSelectorStone.UseVisualStyleBackColor = true;
            // 
            // unitSelectorKg
            // 
            this.unitSelectorKg.AutoSize = true;
            this.unitSelectorKg.Location = new System.Drawing.Point(17, 23);
            this.unitSelectorKg.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelectorKg.Name = "unitSelectorKg";
            this.unitSelectorKg.Size = new System.Drawing.Size(114, 20);
            this.unitSelectorKg.TabIndex = 0;
            this.unitSelectorKg.Text = "Kilograms (kg)";
            this.unitSelectorKg.UseVisualStyleBackColor = true;
            // 
            // unitSelectorLb
            // 
            this.unitSelectorLb.AutoSize = true;
            this.unitSelectorLb.Location = new System.Drawing.Point(205, 23);
            this.unitSelectorLb.Margin = new System.Windows.Forms.Padding(4);
            this.unitSelectorLb.Name = "unitSelectorLb";
            this.unitSelectorLb.Size = new System.Drawing.Size(103, 20);
            this.unitSelectorLb.TabIndex = 1;
            this.unitSelectorLb.Text = "Pounds (lbs)";
            this.unitSelectorLb.UseVisualStyleBackColor = true;
            // 
            // lblUnit2
            // 
            this.lblUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnit2.Location = new System.Drawing.Point(544, 79);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(167, 53);
            this.lblUnit2.TabIndex = 10;
            this.lblUnit2.Text = "st";
            // 
            // WiiBalanceScaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 493);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.unitSelector);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WiiBalanceScaleForm";
            this.Text = "Wii Balance Scale";
            this.unitSelector.ResumeLayout(false);
            this.unitSelector.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


    }
}