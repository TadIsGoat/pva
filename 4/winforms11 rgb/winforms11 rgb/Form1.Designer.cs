namespace winforms11_rgb
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
            buttonClose = new Button();
            panel1 = new Panel();
            pictureBoxSpectrum = new PictureBox();
            labelRGB = new Label();
            groupBox1 = new GroupBox();
            textBoxBlue = new TextBox();
            textBoxGreen = new TextBox();
            textBoxRed = new TextBox();
            panelSelectedColor = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelColorWindow = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpectrum).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(129, 206, 239);
            label1.Location = new Point(84, 65);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 0;
            label1.Text = "Color select";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(129, 206, 239);
            buttonClose.FlatStyle = FlatStyle.Popup;
            buttonClose.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonClose.ForeColor = Color.FromArgb(30, 33, 47);
            buttonClose.Location = new Point(442, 415);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(123, 45);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 47);
            panel1.Controls.Add(pictureBoxSpectrum);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 559);
            panel1.TabIndex = 2;
            // 
            // pictureBoxSpectrum
            // 
            pictureBoxSpectrum.Image = Properties.Resources.rgbSpectrum;
            pictureBoxSpectrum.Location = new Point(32, 175);
            pictureBoxSpectrum.Name = "pictureBoxSpectrum";
            pictureBoxSpectrum.Size = new Size(226, 156);
            pictureBoxSpectrum.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSpectrum.TabIndex = 3;
            pictureBoxSpectrum.TabStop = false;
            pictureBoxSpectrum.MouseDown += pictureBoxSpectrum_MouseDown;
            pictureBoxSpectrum.MouseMove += pictureBoxSpectrum_MouseMove;
            // 
            // labelRGB
            // 
            labelRGB.BackColor = Color.Transparent;
            labelRGB.BorderStyle = BorderStyle.FixedSingle;
            labelRGB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelRGB.ForeColor = Color.FromArgb(129, 206, 239);
            labelRGB.Location = new Point(333, 40);
            labelRGB.Name = "labelRGB";
            labelRGB.Size = new Size(178, 31);
            labelRGB.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxBlue);
            groupBox1.Controls.Add(textBoxGreen);
            groupBox1.Controls.Add(textBoxRed);
            groupBox1.Controls.Add(panelSelectedColor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.ForeColor = Color.FromArgb(129, 206, 239);
            groupBox1.Location = new Point(333, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 185);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Color";
            // 
            // textBoxBlue
            // 
            textBoxBlue.Location = new Point(96, 117);
            textBoxBlue.Name = "textBoxBlue";
            textBoxBlue.Size = new Size(71, 29);
            textBoxBlue.TabIndex = 6;
            // 
            // textBoxGreen
            // 
            textBoxGreen.Location = new Point(96, 77);
            textBoxGreen.Name = "textBoxGreen";
            textBoxGreen.Size = new Size(71, 29);
            textBoxGreen.TabIndex = 5;
            // 
            // textBoxRed
            // 
            textBoxRed.Location = new Point(96, 37);
            textBoxRed.Name = "textBoxRed";
            textBoxRed.Size = new Size(71, 29);
            textBoxRed.TabIndex = 4;
            // 
            // panelSelectedColor
            // 
            panelSelectedColor.Location = new Point(196, 37);
            panelSelectedColor.Name = "panelSelectedColor";
            panelSelectedColor.Size = new Size(117, 109);
            panelSelectedColor.TabIndex = 3;
            panelSelectedColor.Paint += panelSelectedColor_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(21, 126);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "Blue:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 1;
            label3.Text = "Green:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "Red:";
            // 
            // labelColorWindow
            // 
            labelColorWindow.BorderStyle = BorderStyle.FixedSingle;
            labelColorWindow.Location = new Point(583, 40);
            labelColorWindow.Name = "labelColorWindow";
            labelColorWindow.Size = new Size(89, 31);
            labelColorWindow.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(696, 535);
            Controls.Add(labelColorWindow);
            Controls.Add(groupBox1);
            Controls.Add(labelRGB);
            Controls.Add(panel1);
            Controls.Add(buttonClose);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpectrum).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonClose;
        private Panel panel1;
        private PictureBox pictureBoxSpectrum;
        private Label labelRGB;
        private GroupBox groupBox1;
        private TextBox textBoxRed;
        private Panel panelSelectedColor;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxGreen;
        private TextBox textBoxBlue;
        private Label labelColorWindow;
    }
}
