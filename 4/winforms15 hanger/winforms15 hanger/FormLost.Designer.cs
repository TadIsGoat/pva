namespace winforms15_hanger
{
    partial class FormLost
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
            labelGuessedWord = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelGuessedWord
            // 
            labelGuessedWord.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelGuessedWord.Location = new Point(171, 138);
            labelGuessedWord.Name = "labelGuessedWord";
            labelGuessedWord.Size = new Size(220, 30);
            labelGuessedWord.TabIndex = 0;
            labelGuessedWord.Text = "X";
            labelGuessedWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(199, 44);
            label1.Name = "label1";
            label1.Size = new Size(172, 50);
            label1.TabIndex = 1;
            label1.Text = "You lost!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(227, 108);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 2;
            label2.Text = "The word was:";
            // 
            // FormLost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 292);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelGuessedWord);
            Name = "FormLost";
            Text = "You lost!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuessedWord;
        private Label label1;
        private Label label2;
    }
}