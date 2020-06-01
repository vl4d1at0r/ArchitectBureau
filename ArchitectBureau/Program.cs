using System;
using System.Windows.Forms;
using ArchitectBureauDataAccess;

namespace ArchitectBureau
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new MySqlApplicationContext().Dispose();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}