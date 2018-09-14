using System;
using System.Windows.Forms;

namespace Visual_tic_tac_toe
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
            Application.Run(new Game());
        }
    }
}
