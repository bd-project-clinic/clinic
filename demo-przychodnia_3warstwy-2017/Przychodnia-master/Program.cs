using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
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
            //Application.Run(new Rejestratorka());
            //Application.Run(new Lekarz());
            Application.Run(new Laborant());
            Application.Run(new Szef_laborant());

            //Application.Run(new Admin());
            //Application.Run(new Logowanie());

        }
    }
}
