namespace winforms13
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
            label6 = new Label();
            textBoxFullName = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            numericUpDownAge = new NumericUpDown();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            radioButtonElse = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            labelHeight = new Label();
            labelWeight = new Label();
            label9 = new Label();
            label10 = new Label();
            labelBMI = new Label();
            hScrollBar1 = new HScrollBar();
            hScrollBar2 = new HScrollBar();
            label11 = new Label();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Full name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(41, 117);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 1;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(41, 209);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(319, 38);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 3;
            label4.Text = "Height:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(319, 117);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "Weight:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(319, 244);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 5;
            label6.Text = "BMI:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(41, 72);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(227, 23);
            textBoxFullName.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(144, 355);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(146, 47);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(296, 355);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(146, 48);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear all";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(41, 244);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(70, 23);
            numericUpDownAge.TabIndex = 9;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(41, 162);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 10;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(128, 162);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 11;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonElse
            // 
            radioButtonElse.AutoSize = true;
            radioButtonElse.Location = new Point(223, 162);
            radioButtonElse.Name = "radioButtonElse";
            radioButtonElse.Size = new Size(45, 19);
            radioButtonElse.TabIndex = 12;
            radioButtonElse.TabStop = true;
            radioButtonElse.Text = "Else";
            radioButtonElse.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 246);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 13;
            label7.Text = "years old";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 43);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 14;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelHeight.Location = new Point(462, 38);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(0, 21);
            labelHeight.TabIndex = 15;
            labelHeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWeight.Location = new Point(462, 117);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(0, 21);
            labelWeight.TabIndex = 16;
            labelWeight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(499, 38);
            label9.Name = "label9";
            label9.Size = new Size(33, 21);
            label9.TabIndex = 17;
            label9.Text = "cm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.Location = new Point(499, 117);
            label10.Name = "label10";
            label10.Size = new Size(29, 21);
            label10.TabIndex = 18;
            label10.Text = "kg";
            // 
            // labelBMI
            // 
            labelBMI.AutoSize = true;
            labelBMI.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelBMI.ForeColor = Color.Red;
            labelBMI.Location = new Point(366, 244);
            labelBMI.Name = "labelBMI";
            labelBMI.Size = new Size(0, 25);
            labelBMI.TabIndex = 19;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(319, 72);
            hScrollBar1.Maximum = 300;
            hScrollBar1.Minimum = 1;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(213, 17);
            hScrollBar1.TabIndex = 20;
            hScrollBar1.Value = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(319, 164);
            hScrollBar2.Maximum = 300;
            hScrollBar2.Minimum = 1;
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(213, 17);
            hScrollBar2.TabIndex = 21;
            hScrollBar2.Value = 1;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.Location = new Point(319, 282);
            label11.Name = "label11";
            label11.Size = new Size(71, 25);
            label11.TabIndex = 22;
            label11.Text = "Result:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelResult.ForeColor = Color.Red;
            labelResult.Location = new Point(386, 282);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(labelResult);
            Controls.Add(label11);
            Controls.Add(hScrollBar2);
            Controls.Add(hScrollBar1);
            Controls.Add(labelBMI);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(labelWeight);
            Controls.Add(labelHeight);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(radioButtonElse);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxFullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unnecesarily overdone BMI calculator";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFullName;
        private Button buttonCalculate;
        private Button buttonClear;
        private NumericUpDown numericUpDownAge;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonElse;
        private Label label7;
        private Label label8;
        private Label labelHeight;
        private Label labelWeight;
        private Label label9;
        private Label label10;
        private Label labelBMI;
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBar2;
        private Label label11;
        private Label labelResult;
    }
}
