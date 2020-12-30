using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timekeeper
{
    public partial class Main : Form
    {
        private int TotalSeconds;


        public Main()
        {
            InitializeComponent();
        }

        private void controller_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                controller.Text = "Start";
                green.Visible = true;
                yellow.Visible = true;
                yellowLabel.Visible = true;
                greenLabel.Visible = true;
                timer.Stop();
            }
            else
            {
                TotalSeconds = 0;
                controller.Text = "Stop";
                green.Visible = false;
                yellow.Visible = false;
                yellowLabel.Visible = false;
                greenLabel.Visible = false;
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TotalSeconds++;

            //change color
            if (TotalSeconds > green.Value && TotalSeconds <= yellow.Value)
            {
                this.BackColor = Color.Yellow;
            }
            else if (TotalSeconds <= green.Value)
            {
                this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }

            TimeSpan ts = TimeSpan.FromSeconds(TotalSeconds);
            time.Text = ts.ToString(@"mm\:ss");
        }
    }
}
