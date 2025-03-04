namespace winforms14_betterCalc
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
            label1 = new Label();
            labelCaptcha = new Label();
            buttonCaptcha = new Button();
            label2 = new Label();
            textBoxUserNumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(107, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Captcha:";
            // 
            // labelCaptcha
            // 
            labelCaptcha.AutoSize = true;
            labelCaptcha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCaptcha.ForeColor = Color.Red;
            labelCaptcha.Location = new Point(212, 24);
            labelCaptcha.Name = "labelCaptcha";
            labelCaptcha.Size = new Size(56, 25);
            labelCaptcha.TabIndex = 1;
            labelCaptcha.Text = "####";
            // 
            // buttonCaptcha
            // 
            buttonCaptcha.BackColor = Color.FromArgb(0, 192, 192);
            buttonCaptcha.FlatAppearance.BorderSize = 0;
            buttonCaptcha.FlatStyle = FlatStyle.Popup;
            buttonCaptcha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonCaptcha.ForeColor = Color.FromArgb(0, 64, 64);
            buttonCaptcha.Location = new Point(298, 22);
            buttonCaptcha.Name = "buttonCaptcha";
            buttonCaptcha.Size = new Size(115, 34);
            buttonCaptcha.TabIndex = 2;
            buttonCaptcha.Text = "New Captcha";
            buttonCaptcha.UseVisualStyleBackColor = false;
            buttonCaptcha.Click += buttonCaptcha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 3;
            label2.Text = "Type in the captcha:";
            // 
            // textBoxUserNumber
            // 
            textBoxUserNumber.BackColor = Color.White;
            textBoxUserNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxUserNumber.Location = new Point(201, 80);
            textBoxUserNumber.Name = "textBoxUserNumber";
            textBoxUserNumber.Size = new Size(82, 29);
            textBoxUserNumber.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(298, 78);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(496, 152);
            Controls.Add(button1);
            Controls.Add(textBoxUserNumber);
            Controls.Add(label2);
            Controls.Add(buttonCaptcha);
            Controls.Add(labelCaptcha);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator Login";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCaptcha;
        private Button buttonCaptcha;
        private Label label2;
        private TextBox textBoxUserNumber;
        private Button button1;
    }
}
