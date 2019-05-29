using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace SorterSetup
{
    partial class Filter
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
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.numericUpDownContainer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxShapes = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxColor = new System.Windows.Forms.CheckedListBox();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.numericUpDownContainer);
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.numericUpDownMin);
            this.groupBoxFilter.Controls.Add(this.numericUpDownMax);
            this.groupBoxFilter.Controls.Add(this.label6);
            this.groupBoxFilter.Controls.Add(this.label5);
            this.groupBoxFilter.Controls.Add(this.label4);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.Controls.Add(this.checkedListBoxShapes);
            this.groupBoxFilter.Controls.Add(this.checkedListBoxColor);
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(539, 130);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";

            // 
            // numericUpDown3
            // 
            this.numericUpDownContainer.Location = new System.Drawing.Point(469, 95);
            this.numericUpDownContainer.Name = "numericUpDown3";
            this.numericUpDownContainer.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownContainer.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "To container";
            // 
            // numericUpDown2
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(469, 20);
            this.numericUpDownMin.Name = "numericUpDown2";
            this.numericUpDownMin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownMin.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(469, 51);
            this.numericUpDownMax.Name = "numericUpDown1";
            this.numericUpDownMax.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMax.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maximum Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minimum Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shapes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colors";
            // 
            // checkedListBoxShapes
            // 
            this.checkedListBoxShapes.FormattingEnabled = true;
            this.checkedListBoxShapes.Location = new System.Drawing.Point(239, 21);
            this.checkedListBoxShapes.Name = "checkedListBoxShapes";
            this.checkedListBoxShapes.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxShapes.TabIndex = 2;
            // 
            // checkedListBoxColor
            // 
            this.checkedListBoxColor.FormattingEnabled = true;
            this.checkedListBoxColor.Location = new System.Drawing.Point(48, 21);
            this.checkedListBoxColor.Name = "checkedListBoxColor";
            this.checkedListBoxColor.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxColor.TabIndex = 0;
            
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFilter);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(546, 137);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);

        }





        //same shit, another parm
        private void InitializeComponent(int index, SorterEnvironmentParameters sorterParm)
        {
            InitializeComponent();
            this.groupBoxFilter.Text = "Filter " + index;
            this.numericUpDownMin.Maximum = sorterParm.conteinerNumber;
            this.numericUpDownMin.Minimum = 0;

            this.numericUpDownMin.Maximum = sorterParm.maxWeight;
            this.numericUpDownMin.Minimum = sorterParm.minWeight;

          
            this.numericUpDownMin.Maximum = sorterParm.maxWeight;
            this.numericUpDownMin.Minimum = sorterParm.minWeight;
           
            for(int i=0; i<sorterParm.shapes.Count; i++)
            {
                this.checkedListBoxShapes.Items.Insert(i, sorterParm.shapes[i]);
            }


            
            for (int i = 0; i < sorterParm.colors.Count; i++)
            {
                this.checkedListBoxColor.Items.Insert(i, sorterParm.colors[i]);
            }
            

        }

        ////same shit, another parm
        //private void InitializeComponent(int index, SorterEnvironmentParameters sorterParm)
        //{
        //    InitializeComponent();

        //    this.numericUpDownMin.Maximum = sorterParm.conteinerNumber;
        //    this.numericUpDownMin.Minimum = 0;

        //    this.numericUpDownMin.Maximum = sorterParm.maxWeight;
        //    this.numericUpDownMin.Minimum = sorterParm.minWeight;


        //    this.numericUpDownMin.Maximum = sorterParm.maxWeight;
        //    this.numericUpDownMin.Minimum = sorterParm.minWeight;

        //    for (int i = 0; i < sorterParm.shapes.Count; i++)
        //    {
        //        this.checkedListBoxShapes.Items.Insert(i, sorterParm.shapes[i]);
        //    }



        //    for (int i = 0; i < sorterParm.colors.Count; i++)
        //    {
        //        this.checkedListBoxColor.Items.Insert(i, sorterParm.colors[i]);
        //    }


        //}

        public List<string> getColors()
        {
            List<string> checkedColors = new List<string>();
            foreach (object itemChecked in checkedListBoxColor.CheckedItems)
            {
                checkedColors.Add(itemChecked.ToString());
            }
            return checkedColors;
        }

        public List<string> getShapes()
        {
            List<string> checkedShapes = new List<string>();
            foreach (object itemChecked in checkedListBoxShapes.CheckedItems)
            {
                checkedShapes.Add(itemChecked.ToString());
            }
            return checkedShapes;
        }

        public decimal getContainer()
        {
            return numericUpDownContainer.Value;
        }
        public decimal getMax()
        {
            return numericUpDownMax.Value;
        }
        public decimal getMin()
        {
            return numericUpDownMin.Value;
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxShapes;
        private System.Windows.Forms.CheckedListBox checkedListBoxColor;
    }
}
