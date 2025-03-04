namespace winforms10_stats
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
            numericUpDownNewNumber = new NumericUpDown();
            buttonAdd = new Button();
            buttonClear = new Button();
            label2 = new Label();
            labelNumbers = new Label();
            label3 = new Label();
            comboBoxGrouping = new ComboBox();
            label4 = new Label();
            buttonCalculate = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelSum = new Label();
            labelLowest = new Label();
            labelHighest = new Label();
            labelAvarage = new Label();
            labelGrouped = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter numbers:";
            // 
            // numericUpDownNewNumber
            // 
            numericUpDownNewNumber.Location = new Point(160, 30);
            numericUpDownNewNumber.Name = "numericUpDownNewNumber";
            numericUpDownNewNumber.Size = new Size(120, 23);
            numericUpDownNewNumber.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(317, 30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add number";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(454, 30);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(131, 23);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear all";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 89);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Entered numbers:";
            // 
            // labelNumbers
            // 
            labelNumbers.AutoSize = true;
            labelNumbers.Location = new Point(160, 89);
            labelNumbers.Name = "labelNumbers";
            labelNumbers.Size = new Size(0, 15);
            labelNumbers.TabIndex = 5;
            labelNumbers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 145);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Group by:";
            // 
            // comboBoxGrouping
            // 
            comboBoxGrouping.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrouping.FormattingEnabled = true;
            comboBoxGrouping.Location = new Point(159, 142);
            comboBoxGrouping.Name = "comboBoxGrouping";
            comboBoxGrouping.Size = new Size(426, 23);
            comboBoxGrouping.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 253);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Sum:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(159, 201);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(426, 23);
            buttonCalculate.TabIndex = 9;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 292);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 10;
            label5.Text = "Lowest number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 333);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Highest number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 374);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 12;
            label7.Text = "Avarage:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 414);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 13;
            label8.Text = "Grouped:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(160, 253);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(0, 15);
            labelSum.TabIndex = 14;
            labelSum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLowest
            // 
            labelLowest.AutoSize = true;
            labelLowest.Location = new Point(160, 292);
            labelLowest.Name = "labelLowest";
            labelLowest.Size = new Size(0, 15);
            labelLowest.TabIndex = 15;
            labelLowest.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHighest
            // 
            labelHighest.AutoSize = true;
            labelHighest.Location = new Point(160, 333);
            labelHighest.Name = "labelHighest";
            labelHighest.Size = new Size(0, 15);
            labelHighest.TabIndex = 16;
            labelHighest.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAvarage
            // 
            labelAvarage.AutoSize = true;
            labelAvarage.Location = new Point(160, 374);
            labelAvarage.Name = "labelAvarage";
            labelAvarage.Size = new Size(0, 15);
            labelAvarage.TabIndex = 17;
            labelAvarage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGrouped
            // 
            labelGrouped.AutoSize = true;
            labelGrouped.Location = new Point(160, 414);
            labelGrouped.Name = "labelGrouped";
            labelGrouped.Size = new Size(0, 15);
            labelGrouped.TabIndex = 18;
            labelGrouped.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(labelGrouped);
            Controls.Add(labelAvarage);
            Controls.Add(labelHighest);
            Controls.Add(labelLowest);
            Controls.Add(labelSum);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonCalculate);
            Controls.Add(label4);
            Controls.Add(comboBoxGrouping);
            Controls.Add(label3);
            Controls.Add(labelNumbers);
            Controls.Add(label2);
            Controls.Add(buttonClear);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownNewNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownNewNumber;
        private Button buttonAdd;
        private Button buttonClear;
        private Label label2;
        private Label labelNumbers;
        private Label label3;
        private ComboBox comboBoxGrouping;
        private Label label4;
        private Button buttonCalculate;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelSum;
        private Label labelLowest;
        private Label labelHighest;
        private Label labelAvarage;
        private Label labelGrouped;
    }
}
