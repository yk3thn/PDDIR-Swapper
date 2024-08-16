using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Timers;

namespace Custom_PDDIR_Swapper
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;

        private void Load_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void Load_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Load_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Load_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                timer1.Stop();
                new Form1().Show();
                this.Visible = false;
            }
            else
            {
                Opacity = Opacity - .01;
            }
        }
    }
}
