namespace winforms1
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
            this.butt = new System.Windows.Forms.Button();
            this.bottom2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.Color.Fuchsia;
            this.butt.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.butt.FlatAppearance.BorderSize = 0;
            this.butt.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt.Location = new System.Drawing.Point(191, 259);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(285, 118);
            this.butt.TabIndex = 0;
            this.butt.Text = "butt";
            this.butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butt.UseVisualStyleBackColor = false;
            this.butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // bottom2
            // 
            this.bottom2.Location = new System.Drawing.Point(699, 259);
            this.bottom2.Name = "bottom2";
            this.bottom2.Size = new System.Drawing.Size(114, 148);
            this.bottom2.TabIndex = 1;
            this.bottom2.Text = "hehe";
            this.bottom2.UseVisualStyleBackColor = true;
            this.bottom2.Click += new System.EventHandler(this.bottom2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::winforms1.Properties.Resources.cici3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 433);
            this.Controls.Add(this.bottom2);
            this.Controls.Add(this.butt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button butt;
        private Button bottom2;
    }
}