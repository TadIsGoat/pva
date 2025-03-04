namespace winforms6_dph
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxCenaInput = new TextBox();
            textBoxDPHInput = new TextBox();
            textBoxCenaOutput = new TextBox();
            textBoxDPHOutput = new TextBox();
            buttonCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // textBoxCenaInput
            // 
            resources.ApplyResources(textBoxCenaInput, "textBoxCenaInput");
            textBoxCenaInput.Name = "textBoxCenaInput";
            // 
            // textBoxDPHInput
            // 
            resources.ApplyResources(textBoxDPHInput, "textBoxDPHInput");
            textBoxDPHInput.Name = "textBoxDPHInput";
            // 
            // textBoxCenaOutput
            // 
            resources.ApplyResources(textBoxCenaOutput, "textBoxCenaOutput");
            textBoxCenaOutput.Name = "textBoxCenaOutput";
            // 
            // textBoxDPHOutput
            // 
            resources.ApplyResources(textBoxDPHOutput, "textBoxDPHOutput");
            textBoxDPHOutput.Name = "textBoxDPHOutput";
            // 
            // buttonCalc
            // 
            resources.ApplyResources(buttonCalc, "buttonCalc");
            buttonCalc.Name = "buttonCalc";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCalc);
            Controls.Add(textBoxDPHOutput);
            Controls.Add(textBoxCenaOutput);
            Controls.Add(textBoxDPHInput);
            Controls.Add(textBoxCenaInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxCenaInput;
        private TextBox textBoxDPHInput;
        private TextBox textBoxCenaOutput;
        private TextBox textBoxDPHOutput;
        private Button buttonCalc;
    }
}
