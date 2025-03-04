using System.Collections.Generic;
using System.Linq;

namespace winforms15_hanger
{
    public partial class FormGame : Form
    {
        private List<string> words = new List<string>() { "mazda", "subaru", "nissan", "bmw", "mercedes", "mitsubishi" };
        private List<string> guessedLetters = new List<string>();
        public string word { get; private set; }
        public int mistakes { get; private set; }
        private string displayedWord;

        private FormLost formLost;
        private FormWon formWon;
        private FormLeaderboard formLeaderboard;

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

        public FormGame(FormLost _formLost, FormWon _formWon, FormLeaderboard _formLeaderboard)
        {
            InitializeComponent();
            NewGame();

            formLost = _formLost;
            formWon = _formWon;
            formLeaderboard = _formLeaderboard;
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
            formLeaderboard.ShowDialog();
        }

        private void NewGame()
        {
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
                formWon.ShowDialog();
                return;
            }
            else
            {
                pictureBox1.Image = images[mistakes];
            }

            if (mistakes > images.Count - 2)
            {
                formLost.UpdateWord(word);
                formLost.ShowDialog();
                return;
            }

            labelWord.Text = displayedWord.Trim();
        }
    }
}