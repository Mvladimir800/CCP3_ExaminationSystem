using System;
using System.Windows.Forms;

namespace ExaminationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with your login form
            Application.Run(new LoginForm());
        }
    }
}