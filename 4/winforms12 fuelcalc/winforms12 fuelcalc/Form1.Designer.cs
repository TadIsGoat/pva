namespace winforms12_fuelcalc
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelAvg = new Label();
            labelCost = new Label();
            labelCostPerKm = new Label();
            labelTotalCost = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numericUpDownTrip = new NumericUpDown();
            hScrollBarAvg = new HScrollBar();
            hScrollBarFuelCost = new HScrollBar();
            buttonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrip).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Avarage fuel consumption:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Fuel cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 112);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Trip length:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 179);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Cost per km:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 209);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Total cost:";
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Location = new Point(222, 54);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(0, 15);
            labelAvg.TabIndex = 5;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(222, 83);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(0, 15);
            labelCost.TabIndex = 6;
            // 
            // labelCostPerKm
            // 
            labelCostPerKm.AutoSize = true;
            labelCostPerKm.Location = new Point(222, 179);
            labelCostPerKm.Name = "labelCostPerKm";
            labelCostPerKm.Size = new Size(0, 15);
            labelCostPerKm.TabIndex = 7;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Location = new Point(222, 209);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(0, 15);
            labelTotalCost.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 54);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 9;
            label6.Text = "l/100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 83);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 10;
            label7.Text = "Kč/l";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 112);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 11;
            label8.Text = "km";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(266, 179);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 12;
            label9.Text = "Kč";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(266, 209);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 13;
            label10.Text = "Kč";
            // 
            // numericUpDownTrip
            // 
            numericUpDownTrip.Location = new Point(170, 110);
            numericUpDownTrip.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTrip.Name = "numericUpDownTrip";
            numericUpDownTrip.Size = new Size(66, 23);
            numericUpDownTrip.TabIndex = 14;
            // 
            // hScrollBarAvg
            // 
            hScrollBarAvg.Location = new Point(326, 52);
            hScrollBarAvg.Minimum = 1;
            hScrollBarAvg.Name = "hScrollBarAvg";
            hScrollBarAvg.Size = new Size(80, 17);
            hScrollBarAvg.TabIndex = 15;
            hScrollBarAvg.Value = 1;
            hScrollBarAvg.Scroll += hScrollBarAvg_Scroll;
            // 
            // hScrollBarFuelCost
            // 
            hScrollBarFuelCost.Location = new Point(326, 81);
            hScrollBarFuelCost.Minimum = 1;
            hScrollBarFuelCost.Name = "hScrollBarFuelCost";
            hScrollBarFuelCost.Size = new Size(80, 17);
            hScrollBarFuelCost.TabIndex = 16;
            hScrollBarFuelCost.Value = 1;
            hScrollBarFuelCost.Scroll += hScrollBarFuelCost_Scroll;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(326, 205);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(80, 23);
            buttonCalculate.TabIndex = 17;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 317);
            Controls.Add(buttonCalculate);
            Controls.Add(hScrollBarFuelCost);
            Controls.Add(hScrollBarAvg);
            Controls.Add(numericUpDownTrip);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelTotalCost);
            Controls.Add(labelCostPerKm);
            Controls.Add(labelCost);
            Controls.Add(labelAvg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Expense calculator";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelAvg;
        private Label labelCost;
        private Label labelCostPerKm;
        private Label labelTotalCost;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numericUpDownTrip;
        private HScrollBar hScrollBarAvg;
        private HScrollBar hScrollBarFuelCost;
        private Button buttonCalculate;
    }
}
