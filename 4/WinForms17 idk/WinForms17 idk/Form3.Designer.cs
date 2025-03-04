namespace WinForms17_idk
{
    partial class Form3
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
            listBoxList = new ListBox();
            buttonDelete = new Button();
            buttonReturn = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "This persons list:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // listBoxList
            // 
            listBoxList.FormattingEnabled = true;
            listBoxList.ItemHeight = 15;
            listBoxList.Location = new Point(40, 61);
            listBoxList.Name = "listBoxList";
            listBoxList.SelectionMode = SelectionMode.MultiExtended;
            listBoxList.Size = new Size(178, 124);
            listBoxList.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(40, 202);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete item";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(143, 202);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(75, 23);
            buttonReturn.TabIndex = 4;
            buttonReturn.Text = "Go back";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(40, 245);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(143, 245);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 6;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 319);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonReturn);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxList);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBoxList;
        private Button buttonDelete;
        private Button buttonReturn;
        private Button buttonSave;
        private Button buttonLoad;
    }
}