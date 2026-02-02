namespace PDDIR_Swapper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            path = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            before = new PictureBox();
            after = new PictureBox();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            selectafter = new Button();
            beforefilename = new Label();
            beforefilesize = new Label();
            afterfilesize = new Label();
            afterfilename = new Label();
            revert = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)before).BeginInit();
            ((System.ComponentModel.ISupportInitialize)after).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Product Sans", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 43);
            label1.TabIndex = 0;
            label1.Text = "PDDIR Swapper";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Product Sans", 10F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(90, 52);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 1;
            label2.Text = "yk3thn 2026";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(579, 389);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // path
            // 
            path.BackColor = Color.Black;
            path.Font = new Font("Product Sans", 15F);
            path.ForeColor = Color.White;
            path.Location = new Point(292, 38);
            path.Name = "path";
            path.Size = new Size(505, 32);
            path.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Product Sans", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(292, 10);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "PDDIR Path:";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.fileexplorer;
            pictureBox1.Location = new Point(803, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Product Sans", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(597, 294);
            button1.Name = "button1";
            button1.Size = new Size(240, 48);
            button1.TabIndex = 6;
            button1.Text = "Load PDDIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // before
            // 
            before.Cursor = Cursors.Hand;
            before.Image = Properties.Resources.placeholder;
            before.Location = new Point(597, 91);
            before.Name = "before";
            before.Size = new Size(86, 83);
            before.SizeMode = PictureBoxSizeMode.Zoom;
            before.TabIndex = 7;
            before.TabStop = false;
            // 
            // after
            // 
            after.Cursor = Cursors.Hand;
            after.Image = Properties.Resources.placeholder;
            after.Location = new Point(751, 91);
            after.Name = "after";
            after.Size = new Size(86, 83);
            after.SizeMode = PictureBoxSizeMode.Zoom;
            after.TabIndex = 8;
            after.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.arrow;
            pictureBox4.Location = new Point(689, 113);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Product Sans", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(597, 348);
            button2.Name = "button2";
            button2.Size = new Size(240, 48);
            button2.TabIndex = 10;
            button2.Text = "Swap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // selectafter
            // 
            selectafter.Cursor = Cursors.Hand;
            selectafter.FlatStyle = FlatStyle.Flat;
            selectafter.Font = new Font("Product Sans", 15F);
            selectafter.ForeColor = Color.White;
            selectafter.Location = new Point(751, 222);
            selectafter.Name = "selectafter";
            selectafter.Size = new Size(86, 48);
            selectafter.TabIndex = 11;
            selectafter.Text = "Select";
            selectafter.UseVisualStyleBackColor = true;
            selectafter.Click += selectafter_Click;
            // 
            // beforefilename
            // 
            beforefilename.AutoSize = true;
            beforefilename.Font = new Font("Product Sans", 10F);
            beforefilename.ForeColor = Color.White;
            beforefilename.Location = new Point(597, 177);
            beforefilename.Name = "beforefilename";
            beforefilename.Size = new Size(16, 18);
            beforefilename.TabIndex = 12;
            beforefilename.Text = "[]";
            // 
            // beforefilesize
            // 
            beforefilesize.AutoSize = true;
            beforefilesize.Font = new Font("Product Sans", 10F);
            beforefilesize.ForeColor = Color.LightGray;
            beforefilesize.Location = new Point(597, 198);
            beforefilesize.Name = "beforefilesize";
            beforefilesize.Size = new Size(16, 18);
            beforefilesize.TabIndex = 13;
            beforefilesize.Text = "[]";
            // 
            // afterfilesize
            // 
            afterfilesize.AutoSize = true;
            afterfilesize.Font = new Font("Product Sans", 10F);
            afterfilesize.ForeColor = Color.LightGray;
            afterfilesize.Location = new Point(751, 198);
            afterfilesize.Name = "afterfilesize";
            afterfilesize.Size = new Size(16, 18);
            afterfilesize.TabIndex = 15;
            afterfilesize.Text = "[]";
            // 
            // afterfilename
            // 
            afterfilename.AutoSize = true;
            afterfilename.Font = new Font("Product Sans", 10F);
            afterfilename.ForeColor = Color.White;
            afterfilename.Location = new Point(751, 177);
            afterfilename.Name = "afterfilename";
            afterfilename.Size = new Size(16, 18);
            afterfilename.TabIndex = 14;
            afterfilename.Text = "[]";
            // 
            // revert
            // 
            revert.Cursor = Cursors.Hand;
            revert.FlatStyle = FlatStyle.Flat;
            revert.Font = new Font("Product Sans", 12F);
            revert.ForeColor = Color.IndianRed;
            revert.Location = new Point(597, 425);
            revert.Name = "revert";
            revert.Size = new Size(117, 55);
            revert.TabIndex = 16;
            revert.Text = "Revert All Changes";
            revert.UseVisualStyleBackColor = true;
            revert.Click += revert_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Product Sans", 12F);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(720, 425);
            button3.Name = "button3";
            button3.Size = new Size(117, 55);
            button3.TabIndex = 17;
            button3.Text = "Swap ALL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(849, 492);
            Controls.Add(button3);
            Controls.Add(revert);
            Controls.Add(afterfilesize);
            Controls.Add(afterfilename);
            Controls.Add(beforefilesize);
            Controls.Add(beforefilename);
            Controls.Add(selectafter);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(after);
            Controls.Add(before);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(path);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "PDDIR Swapper";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)before).EndInit();
            ((System.ComponentModel.ISupportInitialize)after).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox path;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox before;
        private PictureBox after;
        private PictureBox pictureBox4;
        private Button button2;
        private Button selectafter;
        private Label beforefilename;
        private Label beforefilesize;
        private Label afterfilesize;
        private Label afterfilename;
        private Button revert;
        private Button button3;
    }
}
