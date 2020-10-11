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

    class SplashScreenClass : WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashScreen();  
        }

        protected override void OnCreateMainForm()
        {
            System.Threading.Thread.Sleep(500);
            this.MainForm = new WelcomeScreen();
        }
    }
}
