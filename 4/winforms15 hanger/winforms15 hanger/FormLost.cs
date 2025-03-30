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
    public partial class FormLost : Form
    {
        FormGame formGame;
        public FormLost(string word, FormGame _formGame)
        {
            InitializeComponent();
            labelGuessedWord.Text = word;
            formGame = _formGame;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGame.Show();
        }
    }
}
