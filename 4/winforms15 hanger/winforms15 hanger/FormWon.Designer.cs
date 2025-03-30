namespace winforms15_hanger
{
    partial class FormWon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxNickname = new TextBox();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(-41, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 65);
            label1.TabIndex = 0;
            label1.Text = "You guessed the word X correctly!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(200, 91);
            label2.Name = "label2";
            label2.Size = new Size(280, 30);
            label2.TabIndex = 1;
            label2.Text = "Please enter your nickname:";
            // 
            // textBoxNickname
            // 
            textBoxNickname.Location = new Point(243, 135);
            textBoxNickname.Name = "textBoxNickname";
            textBoxNickname.Size = new Size(195, 23);
            textBoxNickname.TabIndex = 2;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(267, 178);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(136, 35);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormWon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 269);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxNickname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormWon";
            Text = "You won!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNickname;
        private Button buttonEnter;
    }
}