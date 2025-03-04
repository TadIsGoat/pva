namespace winforms4_moneyapp
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
            labelCZK = new Label();
            labelUSD = new Label();
            labelBIT = new Label();
            textBoxCZK = new TextBox();
            textBoxUSD = new TextBox();
            textBoxBIT = new TextBox();
            buttonConvert = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelCZK
            // 
            labelCZK.AutoSize = true;
            labelCZK.BackColor = Color.Transparent;
            labelCZK.FlatStyle = FlatStyle.Popup;
            labelCZK.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCZK.ForeColor = Color.Red;
            labelCZK.Location = new Point(111, 86);
            labelCZK.Name = "labelCZK";
            labelCZK.Size = new Size(74, 36);
            labelCZK.TabIndex = 0;
            labelCZK.Text = "CZK";
            labelCZK.Click += labelCZK_Click;
            // 
            // labelUSD
            // 
            labelUSD.AutoSize = true;
            labelUSD.BackColor = Color.Transparent;
            labelUSD.FlatStyle = FlatStyle.Popup;
            labelUSD.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUSD.ForeColor = Color.Red;
            labelUSD.Location = new Point(111, 206);
            labelUSD.Name = "labelUSD";
            labelUSD.Size = new Size(75, 36);
            labelUSD.TabIndex = 1;
            labelUSD.Text = "USD";
            labelUSD.Click += labelUSD_Click;
            // 
            // labelBIT
            // 
            labelBIT.AutoSize = true;
            labelBIT.BackColor = Color.Transparent;
            labelBIT.FlatStyle = FlatStyle.Popup;
            labelBIT.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBIT.ForeColor = Color.Red;
            labelBIT.Location = new Point(111, 327);
            labelBIT.Name = "labelBIT";
            labelBIT.Size = new Size(68, 36);
            labelBIT.TabIndex = 2;
            labelBIT.Text = "BIT";
            labelBIT.Click += labelBIT_Click;
            // 
            // textBoxCZK
            // 
            textBoxCZK.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxCZK.Location = new Point(212, 86);
            textBoxCZK.Name = "textBoxCZK";
            textBoxCZK.Size = new Size(183, 35);
            textBoxCZK.TabIndex = 3;
            textBoxCZK.TextChanged += textBoxCZK_TextChanged;
            // 
            // textBoxUSD
            // 
            textBoxUSD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxUSD.Location = new Point(212, 209);
            textBoxUSD.Name = "textBoxUSD";
            textBoxUSD.Size = new Size(183, 35);
            textBoxUSD.TabIndex = 4;
            textBoxUSD.TextChanged += textBoxUSD_TextChanged;
            // 
            // textBoxBIT
            // 
            textBoxBIT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxBIT.Location = new Point(212, 327);
            textBoxBIT.Name = "textBoxBIT";
            textBoxBIT.Size = new Size(183, 35);
            textBoxBIT.TabIndex = 5;
            textBoxBIT.TextChanged += textBoxBIT_TextChanged;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = Color.FromArgb(128, 128, 255);
            buttonConvert.FlatStyle = FlatStyle.Popup;
            buttonConvert.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConvert.Location = new Point(491, 141);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(144, 41);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(128, 128, 255);
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(491, 268);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(144, 41);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cici1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonConvert);
            Controls.Add(textBoxBIT);
            Controls.Add(textBoxUSD);
            Controls.Add(textBoxCZK);
            Controls.Add(labelBIT);
            Controls.Add(labelUSD);
            Controls.Add(labelCZK);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCZK;
        private Label labelUSD;
        private Label labelBIT;
        private TextBox textBoxCZK;
        private TextBox textBoxUSD;
        private TextBox textBoxBIT;
        private Button buttonConvert;
        private Button buttonClear;
    }
}
