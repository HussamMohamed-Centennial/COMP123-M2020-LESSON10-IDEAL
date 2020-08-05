using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        public static EndForm endForm;
        public static SplashForm splashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            mainForm = new MainForm();
            endForm = new EndForm();


            Application.Run(splashForm);
        }
    }
}
