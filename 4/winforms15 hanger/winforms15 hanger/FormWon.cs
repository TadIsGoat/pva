using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms15_hanger
{
    public partial class FormWon : Form
    {
        int mistakes;
        FormGame formGame;
        public FormWon(string _word, int _mistakes, FormGame _formGame)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FormWon_KeyDown;
            label1.Text = $"You guessed the word {_word} correctly!";
            mistakes = _mistakes;
            formGame = _formGame;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNickname.Text))
            {
                this.Hide();
                FormLeaderboard formLeaderboard = new FormLeaderboard(textBoxNickname.Text, mistakes, formGame);
                formLeaderboard.Show();
            }
            else
            {
                MessageBox.Show("Enter your nickname!");
            }
        }

        private void FormWon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                buttonEnter_Click(sender, e);
            }
        }
    }
}
