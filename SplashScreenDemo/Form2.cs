using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenDemo
{
    public partial class MainScreenForm : Form
    {
        public static Thread splashThread;
        public MainScreenForm()
        {
            splashThread = new Thread(new ThreadStart(StartForm));
            splashThread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            splashThread.Abort();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Thread.Sleep(500);
            TopMost = false;
        }

        private static void StartForm()
        {
            Application.Run(new SplashScreenForm());
        }
    }
}
