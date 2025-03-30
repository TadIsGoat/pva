namespace winforms15_hanger
{
    partial class FormLeaderboard
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
            listBoxLeaderboard = new ListBox();
            label1 = new Label();
            buttonReturn = new Button();
            SuspendLayout();
            // 
            // listBoxLeaderboard
            // 
            listBoxLeaderboard.FormattingEnabled = true;
            listBoxLeaderboard.ItemHeight = 15;
            listBoxLeaderboard.Location = new Point(72, 70);
            listBoxLeaderboard.Name = "listBoxLeaderboard";
            listBoxLeaderboard.Size = new Size(663, 244);
            listBoxLeaderboard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(72, 37);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 1;
            label1.Text = "Best players:";
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(312, 320);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(172, 34);
            buttonReturn.TabIndex = 4;
            buttonReturn.Text = "Go back";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // FormLeaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 393);
            Controls.Add(buttonReturn);
            Controls.Add(label1);
            Controls.Add(listBoxLeaderboard);
            Name = "FormLeaderboard";
            Text = "Leaderboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLeaderboard;
        private Label label1;
        private Button buttonReturn;
    }
}