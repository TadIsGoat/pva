using System.Security.Cryptography.X509Certificates;

namespace winforms15_hanger
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FormGame formGame = new FormGame();

            Application.Run(formGame);
        }
    }
}