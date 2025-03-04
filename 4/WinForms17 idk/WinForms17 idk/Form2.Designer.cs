namespace WinForms17_idk
{
    partial class Form2
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
            textBoxThing = new TextBox();
            buttonAdd = new Button();
            buttonShowList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter new thing:";
            // 
            // textBoxThing
            // 
            textBoxThing.Location = new Point(31, 44);
            textBoxThing.Name = "textBoxThing";
            textBoxThing.Size = new Size(183, 23);
            textBoxThing.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(31, 73);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonShowList
            // 
            buttonShowList.Location = new Point(139, 73);
            buttonShowList.Name = "buttonShowList";
            buttonShowList.Size = new Size(75, 23);
            buttonShowList.TabIndex = 3;
            buttonShowList.Text = "Show list";
            buttonShowList.UseVisualStyleBackColor = true;
            buttonShowList.Click += buttonShowList_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 127);
            Controls.Add(buttonShowList);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxThing);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxThing;
        private Button buttonAdd;
        private Button buttonShowList;
    }
}