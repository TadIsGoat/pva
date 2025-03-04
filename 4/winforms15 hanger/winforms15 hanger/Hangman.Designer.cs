namespace winforms15_hanger
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            label1 = new Label();
            textBoxGuess = new TextBox();
            buttonGuess = new Button();
            pictureBox1 = new PictureBox();
            labelWord = new Label();
            buttonRestart = new Button();
            buttonLeaderboard = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(157, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Your guess:";
            // 
            // textBoxGuess
            // 
            textBoxGuess.CharacterCasing = CharacterCasing.Upper;
            textBoxGuess.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxGuess.Location = new Point(196, 73);
            textBoxGuess.MaxLength = 1;
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(38, 33);
            textBoxGuess.TabIndex = 1;
            // 
            // buttonGuess
            // 
            buttonGuess.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonGuess.Location = new Point(170, 123);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(98, 32);
            buttonGuess.TabIndex = 2;
            buttonGuess.Text = "Guess";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(88, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWord.Location = new Point(196, 527);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(26, 30);
            labelWord.TabIndex = 4;
            labelWord.Text = "X";
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonRestart.Location = new Point(12, 587);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(140, 32);
            buttonRestart.TabIndex = 5;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonLeaderboard
            // 
            buttonLeaderboard.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonLeaderboard.Location = new Point(309, 587);
            buttonLeaderboard.Name = "buttonLeaderboard";
            buttonLeaderboard.Size = new Size(140, 32);
            buttonLeaderboard.TabIndex = 6;
            buttonLeaderboard.Text = "Leaderboard";
            buttonLeaderboard.UseVisualStyleBackColor = true;
            buttonLeaderboard.Click += buttonLeaderboard_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(461, 631);
            Controls.Add(buttonLeaderboard);
            Controls.Add(buttonRestart);
            Controls.Add(labelWord);
            Controls.Add(pictureBox1);
            Controls.Add(buttonGuess);
            Controls.Add(textBoxGuess);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Hangman";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxGuess;
        private Button buttonGuess;
        private PictureBox pictureBox1;
        private Label labelWord;
        private Button buttonRestart;
        private Button buttonLeaderboard;
    }
}
