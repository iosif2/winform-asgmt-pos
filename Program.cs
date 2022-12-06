using System;
using System.Windows.Forms;

namespace winform_asgmt_pos
{
    internal static class Program
    {
        /// <summary>
        /// The mainForm entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
