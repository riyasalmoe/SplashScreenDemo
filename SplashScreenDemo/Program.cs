using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenDemo
{
    static class Program
    {
        //public static Thread splashThread;
        //public static SplashScreenForm SplashScreen; //= new SplashScreenForm();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //splash screen close by itself
            Application.Run(new SplashScreenForm());

            //application start
            Application.Run(new MainScreenForm());
            
            //SplashScreen = new SplashScreenForm();
            //splashThread = new Thread(new ThreadStart(StartForm));
            //splashThread.Start();
            //Thread.Sleep(5000);
            //splashThread.Abort();

        }

        //private static async void StartForm()
        //{
        //   await Task.Run(() => Application.Run(SplashScreen));           
        //}
    }
}
