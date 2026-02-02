using System.Drawing.Imaging;
using System.IO;

namespace PDDIR_Swapper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Shown += new System.EventHandler(this.Form_Shown);
        }
        void LoadImages(string sourceFolder)
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), "ImageGridTemp");
            Directory.CreateDirectory(tempFolder);

            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            foreach (var file in Directory.GetFiles(sourceFolder))
            {
                string ext = Path.GetExtension(file).ToLower();
                string resolvedPath = null;

                if (ext == ".png" || ext == ".jpg")
                {
                    resolvedPath = file;
                }
                else if (string.IsNullOrEmpty(ext))
                {
                    string tempPath = Path.Combine(
                        tempFolder,
                        Path.GetFileName(file) + ".png"
                    );

                    if (!File.Exists(tempPath))
                        File.Copy(file, tempPath, true);

                    resolvedPath = tempPath;
                }

                if (resolvedPath != null)
                {
                    var tile = CreateImageTile(resolvedPath);
                    flowLayoutPanel1.Controls.Add(tile);
                }
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void Form_Shown(object sender, EventArgs e) //save settings
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

        Panel CreateImageTile(string imagePath) //create grid of images
        {
            var panel = new Panel
            {
                Width = 260,
                Height = 300,
                Margin = new Padding(8),
                BackColor = Color.FromArgb(30, 30, 30)
            };

            var pictureBox = new PictureBox
            {
                Width = 240,
                Height = 240,
                SizeMode = PictureBoxSizeMode.Zoom,
                Top = 8,
                Cursor = Cursors.Hand,
                Tag = imagePath
            };

            pictureBox.Left = (panel.Width - pictureBox.Width) / 2;
            pictureBox.Click += ImageTile_Click;

            using (var img = Image.FromFile(imagePath))
                pictureBox.Image = new Bitmap(img);

            var fileNameLabel = new Label
            {
                Text = Path.GetFileName(imagePath),
                AutoEllipsis = true,
                Width = 240,
                ForeColor = Color.White,
                Left = pictureBox.Left,
                Top = pictureBox.Bottom + 4
            };

            var sizeLabel = new Label
            {
                Text = $"{pictureBox.Image.Width} x {pictureBox.Image.Height}",
                Width = 240,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Left = pictureBox.Left,
                Top = fileNameLabel.Bottom + 2
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(fileNameLabel);
            panel.Controls.Add(sizeLabel);

            return panel;
        }
        private void ImageTile_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb?.Tag == null) return;

            string path = pb.Tag.ToString();

            using (var img = Image.FromFile(path))
            {
                before.Image = new Bitmap(img);
                beforefilesize.Text = $"{img.Width} x {img.Height}";
            }

            beforefilename.Text = Path.GetFileName(path);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (path.Text == "")
            {
                MessageBox.Show("Set your path before selecting an image!");
            }
            else
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Select Image Folder";
                    dialog.UseDescriptionForTitle = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path.Text = dialog.SelectedPath;

                        Properties.Settings.Default.Path = dialog.SelectedPath;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(path.Text) || !Directory.Exists(path.Text))
            {
                MessageBox.Show("Please select a valid folder path.");
                return;
            }

            LoadImages(path.Text);
        }

        private void selectafter_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                dialog.Title = "Select After Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var img = Image.FromFile(dialog.FileName))
                    {
                        after.Image = new Bitmap(img);
                        afterfilesize.Text = $"{img.Width} x {img.Height}";
                    }

                    afterfilename.Text = Path.GetFileName(dialog.FileName);
                }
            }
        }


        private void revert_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.Path;

            if (string.IsNullOrWhiteSpace(dir) || !Directory.Exists(dir))
            {
                MessageBox.Show("Saved directory is invalid.");
                return;
            }

            var result = MessageBox.Show(
                "This will permanently delete ALL files in the saved directory.\n\nAre you sure?",
                "Confirm Revert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    File.Delete(file);
                }

                flowLayoutPanel1.Controls.Clear();
                before.Image = null;
                after.Image = null;
                beforefilename.Text = "";
                beforefilesize.Text = "";
                afterfilename.Text = "";
                afterfilesize.Text = "";

                MessageBox.Show("Directory reverted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reverting directory:\n{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (before.Image == null || after.Image == null)
            {
                MessageBox.Show("Both BEFORE and AFTER images must be selected.");
                return;
            }

            string targetDir = Properties.Settings.Default.Path;
            if (!Directory.Exists(targetDir))
            {
                MessageBox.Show("Saved directory does not exist.");
                return;
            }

            string beforeName = beforefilename.Text;
            if (string.IsNullOrWhiteSpace(beforeName))
            {
                MessageBox.Show("Invalid BEFORE filename.");
                return;
            }

            string targetPath = Path.Combine(targetDir, beforeName);

            try
            {
                if (File.Exists(targetPath))
                    File.Delete(targetPath);

                ImageFormat format = GetImageFormatFromExtension(Path.GetExtension(beforeName));

                using (var bmp = new Bitmap(after.Image))
                {
                    bmp.Save(targetPath, format);
                }

                MessageBox.Show("Swap Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Swap Failed:\n{ex.Message}");
            }
        }

        private ImageFormat GetImageFormatFromExtension(string ext)
        {
            switch (ext.ToLower())
            {
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".png":
                default:
                    return ImageFormat.Png;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (after.Image == null)
            {
                MessageBox.Show("Select an AFTER image first.");
                return;
            }

            string dir = Properties.Settings.Default.Path;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Saved directory is invalid.");
                return;
            }

            var confirm = MessageBox.Show(
                "This will replace EVERY file in the folder with the AFTER image.\n\nContinue?",
                "Confirm Swap ALL",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (var source = new Bitmap(after.Image))
                {
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        string ext = Path.GetExtension(file);
                        string baseName = Path.GetFileNameWithoutExtension(file);
                        string newPath;
                        ImageFormat format;

                        if (string.IsNullOrEmpty(ext))
                        {
                            newPath = Path.Combine(dir, baseName + ".png");
                            format = ImageFormat.Png;

                            File.Delete(file);
                        }
                        else
                        {
                            // Normal file
                            newPath = file;
                            format = GetImageFormatFromExtension(ext);

                            File.Delete(file);
                        }

                        using (var bmp = new Bitmap(source))
                        {
                            bmp.Save(newPath, format);
                        }
                    }
                }

                MessageBox.Show("Swap ALL completed successfully.");
                LoadImages(dir);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Swap ALL failed:\n{ex.Message}");
            }
        }
    }
}
