namespace winforms15_hanger
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FormLost formLost = new FormLost();
            FormWon formWon = new FormWon();
            FormLeaderboard formLeaderboard = new FormLeaderboard();
            FormGame formGame = new FormGame(formLost, formWon, formLeaderboard);

            Application.Run(formGame);
        }
    }
}