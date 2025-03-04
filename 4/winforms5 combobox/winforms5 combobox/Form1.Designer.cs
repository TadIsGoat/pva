namespace winforms5_combobox
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
            comboBoxFrom = new ComboBox();
            textBoxInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxTo = new ComboBox();
            buttonConvert = new Button();
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(482, 169);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(121, 23);
            comboBoxFrom.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(213, 169);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(381, 157);
            label1.Name = "label1";
            label1.Size = new Size(84, 35);
            label1.TabIndex = 2;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(381, 208);
            label2.Name = "label2";
            label2.Size = new Size(55, 35);
            label2.TabIndex = 3;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(300, 332);
            label3.Name = "label3";
            label3.Size = new Size(95, 35);
            label3.TabIndex = 4;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(410, 336);
            label4.Name = "label4";
            label4.Size = new Size(26, 30);
            label4.TabIndex = 5;
            label4.Text = "0";
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(482, 220);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(121, 23);
            comboBoxTo.TabIndex = 6;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = Color.FromArgb(255, 128, 128);
            buttonConvert.FlatStyle = FlatStyle.Popup;
            buttonConvert.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonConvert.Location = new Point(320, 270);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(132, 47);
            buttonConvert.TabIndex = 7;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pusheen_cat_icegif;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConvert);
            Controls.Add(comboBoxTo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxFrom);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "money money money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFrom;
        private TextBox textBoxInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTo;
        private Button buttonConvert;
    }
}
