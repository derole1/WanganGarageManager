using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WanganGarageManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new ApplicationEvents();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                Localisation.InitMain();
                Localisation.InitEditor();
                CarDB.InitDB();
                GarageCar car = new GarageCar(args[1]);
                Application.Run(new frmEditor(car));
            }
            else
            {
                Application.Run(new frmMain());
            }
        }
    }
}
