using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static DashBoardForm dashBoardForm;
        public static StartForm startForm;
        public static MainForm mainForm;
        public static EndForm endForm;
        public static Contact contact;
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
            dashBoardForm = new DashBoardForm();
            startForm = new StartForm();
            mainForm = new MainForm();
            endForm = new EndForm();
            contact = new Contact();


            Application.Run(splashForm);
        }
    }
}
