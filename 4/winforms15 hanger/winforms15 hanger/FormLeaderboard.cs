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
    public partial class FormLeaderboard : Form
    {
        string filePath = $"scores.txt";
        FormGame formGame;

        public FormLeaderboard(FormGame _formGame)
        {
            InitializeComponent();

            formGame = _formGame;

            LoadData();
        }

        public FormLeaderboard(string _nickname, int _mistakes, FormGame _formGame)
        {
            InitializeComponent();

            formGame = _formGame;

            AddData(_nickname, _mistakes);
            LoadData();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGame.Show();
        }

        private void LoadData()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            else
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    listBoxLeaderboard.Items.Add(line);
                }
            }
        }

        private void AddData(string nickname, int mistakes)
        {
            File.AppendAllText(filePath, $"{nickname} - Mistakes: {mistakes.ToString()}\n");
        }
    }
}
