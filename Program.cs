using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using TBS_Sales_Suit_App.Presentation;

namespace TBS_Sales_Suit_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new SplashScreenClass().Run(args);
        }
    }

    /// <summary>
    /// This class is responsible for splash screen to load followed by the welcome screen
    /// </summary>
    class SplashScreenClass : WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashScreen();  
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = new WelcomeScreen();
        }
    }
}
