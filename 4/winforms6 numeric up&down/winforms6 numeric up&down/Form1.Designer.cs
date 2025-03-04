namespace winforms6_numeric_up_down
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            number1 = new NumericUpDown();
            number2 = new NumericUpDown();
            comboBoxOperation = new ComboBox();
            label1 = new Label();
            labelResult = new Label();
            buttonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)number1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number2).BeginInit();
            SuspendLayout();
            // 
            // number1
            // 
            number1.Location = new Point(25, 43);
            number1.Name = "number1";
            number1.Size = new Size(58, 23);
            number1.TabIndex = 0;
            // 
            // number2
            // 
            number2.Location = new Point(183, 43);
            number2.Name = "number2";
            number2.Size = new Size(58, 23);
            number2.TabIndex = 1;
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Location = new Point(110, 42);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(50, 23);
            comboBoxOperation.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 45);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(268, 45);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(13, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "0";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(99, 80);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 139);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(comboBoxOperation);
            Controls.Add(number2);
            Controls.Add(number1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calc";
            ((System.ComponentModel.ISupportInitialize)number1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown number1;
        private NumericUpDown number2;
        private ComboBox comboBoxOperation;
        private Label label1;
        private Label labelResult;
        private Button buttonCalculate;
    }
}
