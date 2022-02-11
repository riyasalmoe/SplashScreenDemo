using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenDemo
{
    public partial class MainScreenForm : Form
    {
        
        public MainScreenForm()
        {
            
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
            Thread.Sleep(500);
            TopMost = false;
        }


    }
}
