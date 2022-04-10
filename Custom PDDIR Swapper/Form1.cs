using AnimateDemo;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_PDDIR_Swapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;
        string bg = "EA7CDAA7AF5B1335517D581803C34BB2394218D1.png";

        string ars = "5BD01AD1D8E331242946552F063B0C8C516808AF.jpg";
        string ard = "865B1F26B6A76C663227957B80EF45DA1C26C0B8.jpg";
        string art = "AE59847727007564CCF76BC11FAD5DB72E3EA46E.jpg";

        string lcu = "75C1823D65D1677AE2A0C898AC17815A97A3598C.jpg";
        string lc2 = "272E9A8440B35E45431CB51AD969E1976826C868.jpg";

        string nbs = "B6304682B7043D311BD291E7F769FA91CA8832C4.jpg";
        string nbd = "176089FA23BCBBBAF1AA0A0EA1F0F8F40989E0A8.jpg";
        string nbt = "13CF43E990EF88CE56682A6EE3016543CFC97F5E.jpg";
        string nb4 = "BA21630AE02297054BF86CCE0823F92E0F780982.jpg";

        string rgs = "B666DE51F8E930A8A99CB03C4454727680759203.jpg";
        string rgd = "454EFD48BB4DF270C688519DCE48E6005BA45027.jpg";
        string rgt = "2AB48F419981C3E52C2ACC5EC192077C668B0F44.jpg";
        string rg4 = "373F1F43CE9C9EF75463556416B182AAC39C1226.jpg";


        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 750, WinAPI.HOR_POSITIVE);
            this.Shown += new System.EventHandler(this.Form_Shown);
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Path == "")
            {
                path.Text = @"C:\Users\" + Environment.UserName + @"\AppData\Local\FortniteGame\Saved\PersistentDownloadDir\CMS";
            }
            else
            {
                path.Text = Properties.Settings.Default.Path;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        string pic { get; set; }
        


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (path.Text == "")
            {
                MessageBox.Show("Set your path before selecting an image!");
            }
            else
            {
                Properties.Settings.Default.Path = path.Text;
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = "C\\";

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    image.Image = Image.FromFile(dialog.FileName);
                    image.Refresh();
                    pic = dialog.FileName;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Thread.Sleep(7);
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + bg);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + bg);
                MessageBox.Show("Done!");
            }
            else
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" +ars);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + ars);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + ard);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + ard);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + art);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + art);
                MessageBox.Show("Done!");
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + lcu);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + lcu);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + lc2);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + lc2);
                MessageBox.Show("Done!");
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbs);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbs);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbd);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbd);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbt);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nbt);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nb4);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + nb4);
                MessageBox.Show("Done!");
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgs);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgs);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgd);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgd);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgt);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rgt);
                File.Delete(Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rg4);
                File.Copy(pic, Properties.Settings.Default.Path + @"\Files\C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2\" + rg4);
                MessageBox.Show("Done!");
            }
            else
            {

            }
        }
    }
}
