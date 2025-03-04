namespace winforms9_triuhel
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
            numericUpDownSideA = new NumericUpDown();
            numericUpDownSideB = new NumericUpDown();
            numericUpDownSideC = new NumericUpDown();
            buttonConfirm = new Button();
            labelValid = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideC).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSideA
            // 
            numericUpDownSideA.Location = new Point(66, 25);
            numericUpDownSideA.Name = "numericUpDownSideA";
            numericUpDownSideA.Size = new Size(120, 23);
            numericUpDownSideA.TabIndex = 0;
            // 
            // numericUpDownSideB
            // 
            numericUpDownSideB.Location = new Point(242, 25);
            numericUpDownSideB.Name = "numericUpDownSideB";
            numericUpDownSideB.Size = new Size(120, 23);
            numericUpDownSideB.TabIndex = 1;
            // 
            // numericUpDownSideC
            // 
            numericUpDownSideC.Location = new Point(417, 25);
            numericUpDownSideC.Name = "numericUpDownSideC";
            numericUpDownSideC.Size = new Size(120, 23);
            numericUpDownSideC.TabIndex = 2;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(66, 64);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(471, 23);
            buttonConfirm.TabIndex = 3;
            buttonConfirm.Text = "VALIDATE";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // labelValid
            // 
            labelValid.AutoSize = true;
            labelValid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelValid.Location = new Point(229, 110);
            labelValid.Name = "labelValid";
            labelValid.Size = new Size(143, 25);
            labelValid.TabIndex = 4;
            labelValid.Text = "Enter all 3 sides";
            labelValid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 161);
            Controls.Add(labelValid);
            Controls.Add(buttonConfirm);
            Controls.Add(numericUpDownSideC);
            Controls.Add(numericUpDownSideB);
            Controls.Add(numericUpDownSideA);
            MaximizeBox = false;
            MaximumSize = new Size(600, 200);
            MinimumSize = new Size(600, 200);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "triangle";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSideC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSideA;
        private NumericUpDown numericUpDownSideB;
        private NumericUpDown numericUpDownSideC;
        private Button buttonConfirm;
        private Label labelValid;
    }
}
