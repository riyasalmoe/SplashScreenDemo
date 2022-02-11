using System.Windows.Forms;

namespace SplashScreenDemo
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            ProgressInnerPanel.Width += ProgressOuterPanel.Width / 5;
            if (ProgressInnerPanel.Width >= 700)
            {
                timer1.Stop();
                timer1.Enabled = false;
                Hide();
                Close();
            }
        }

        private void SplashScreenForm_Load(object sender, System.EventArgs e)
        {
            TopMost = true;
            BringToFront();
            timer1.Enabled = true;
        }
    }
}
