using System.Collections.Generic;
using System.Linq;

namespace winforms15_hanger
{
    public partial class FormGame : Form
    {
        private List<string> words = new List<string>() {"mazda", "subaru", "nissan", "bmw", "mercedes", "mitsubishi", "ford", "audi", "citroen", "skoda"};
        private List<string> guessedLetters = new List<string>();
        public string word { get; private set; }
        public int mistakes { get; private set; }
        private string displayedWord;

        Dictionary<int, Image> images = new Dictionary<int, Image>()
        {
            { 0, Properties.Resources._1 },
            { 1, Properties.Resources._2 },
            { 2, Properties.Resources._3 },
            { 3, Properties.Resources._4 },
            { 4, Properties.Resources._5 },
            { 5, Properties.Resources._6 },
            { 6, Properties.Resources._7 },
            { 7, Properties.Resources._8 },
            { 8, Properties.Resources._9 },
            { 9, Properties.Resources._10 },
            { 10, Properties.Resources._11 }
        };

        public FormGame()
        {
            InitializeComponent();
            NewGame();

            this.KeyPreview = true;
            this.KeyDown += FormGame_KeyDown;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            CheckGuess(textBoxGuess.Text.ToLower());

            textBoxGuess.Clear();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLeaderboard formLeaderboard = new FormLeaderboard(this);
            formLeaderboard.ShowDialog();
        }

        private void NewGame()
        {
            textBoxGuess.Clear();
            Random rnd = new Random();
            word = words[rnd.Next(words.Count)];

            guessedLetters.Clear();
            mistakes = 0;
            CheckGuess("?", true);
        }

        private void CheckGuess(string guessed, bool ignore = false)
        {
            guessedLetters.Add(guessed);

            if (!word.Contains(guessed) && !ignore)
            {
                mistakes++;
            }

            displayedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (guessedLetters.Contains(word[i].ToString()))
                {
                    displayedWord += word[i] + " ";
                }
                else
                {
                    displayedWord += "_ ";
                }
            }

            if (!displayedWord.Contains('_'))
            {
                this.Hide();
                FormWon formWon = new FormWon(word, mistakes, this);
                formWon.ShowDialog();
                return;
            }
            else
            {
                pictureBox1.Image = images[mistakes];
            }

            if (mistakes > images.Count - 2)
            {
                this.Hide();
                FormLost formLost = new FormLost(word, this);
                formLost.ShowDialog();
                return;
            }

            labelWord.Text = displayedWord.Trim();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGuess_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape) 
            {
                Application.Exit();
            }
        }
    }
}