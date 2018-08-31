using System;
using System.Drawing;
using System.Windows.Forms;
using J3QQ4;

namespace GoodTiming
{
    public partial class MainForm : Form
    {
        int timeLeft;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 1)
            {
                timeLeft--;
                lblTimer.Text = timeLeft.ToString();
            }
            else
            {
                Timer1.Stop();
                lblTimer.Text = Emoji.Coffee;
                lblTimer.ForeColor = Color.Gray;
                System.Media.SystemSounds.Beep.Play();
                BtnGo.Enabled = true;
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtSeconds.Text, out timeLeft);
            lblTimer.Text = timeLeft.ToString();
            lblTimer.ForeColor = Color.Black;
            BtnGo.Enabled = false;
            Timer1.Start();
        }
    }
}
