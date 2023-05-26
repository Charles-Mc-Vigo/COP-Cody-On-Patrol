namespace Duty_After_Coding
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            gunner = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            fence = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            bullet = new PictureBox();
            wall = new PictureBox();
            healthBar = new ProgressBar();
            levelCleared = new Label();
            levelLabel = new Label();
            pictureBox7 = new PictureBox();
            wallDef = new PictureBox();
            killLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gunner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wallDef).BeginInit();
            SuspendLayout();
            // 
            // gunner
            // 
            gunner.BackColor = Color.Transparent;
            gunner.Image = Properties.Resources.shooting_instance_2;
            gunner.Location = new Point(251, 351);
            gunner.Margin = new Padding(3, 2, 3, 2);
            gunner.Name = "gunner";
            gunner.Size = new Size(50, 70);
            gunner.SizeMode = PictureBoxSizeMode.StretchImage;
            gunner.TabIndex = 0;
            gunner.TabStop = false;
            gunner.Tag = "gunner";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // fence
            // 
            fence.BackColor = Color.Transparent;
            fence.Image = Properties.Resources.w;
            fence.Location = new Point(444, 264);
            fence.Margin = new Padding(3, 2, 3, 2);
            fence.Name = "fence";
            fence.Size = new Size(127, 59);
            fence.SizeMode = PictureBoxSizeMode.StretchImage;
            fence.TabIndex = 3;
            fence.TabStop = false;
            fence.Tag = "fence";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.w;
            pictureBox2.Location = new Point(21, 268);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "fence";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.w;
            pictureBox3.Location = new Point(242, 264);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "fence";
            // 
            // bullet
            // 
            bullet.BackColor = Color.Transparent;
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(302, 385);
            bullet.Margin = new Padding(3, 2, 3, 2);
            bullet.Name = "bullet";
            bullet.Size = new Size(50, 12);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 6;
            bullet.TabStop = false;
            bullet.Tag = "bullet";
            // 
            // wall
            // 
            wall.BackColor = Color.Transparent;
            wall.Image = Properties.Resources.erodaxia_summary;
            wall.Location = new Point(662, 2);
            wall.Margin = new Padding(3, 2, 3, 2);
            wall.Name = "wall";
            wall.Size = new Size(42, 43);
            wall.SizeMode = PictureBoxSizeMode.StretchImage;
            wall.TabIndex = 14;
            wall.TabStop = false;
            wall.Tag = "wall";
            // 
            // healthBar
            // 
            healthBar.ForeColor = Color.Green;
            healthBar.Location = new Point(709, 12);
            healthBar.Margin = new Padding(3, 2, 3, 2);
            healthBar.Maximum = 1000;
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(124, 28);
            healthBar.TabIndex = 15;
            healthBar.Tag = "healthBar";
            healthBar.Value = 1000;
            // 
            // levelCleared
            // 
            levelCleared.AutoSize = true;
            levelCleared.BackColor = Color.Transparent;
            levelCleared.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            levelCleared.ForeColor = Color.White;
            levelCleared.Location = new Point(514, 341);
            levelCleared.Name = "levelCleared";
            levelCleared.Size = new Size(525, 71);
            levelCleared.TabIndex = 18;
            levelCleared.Text = "Level 1 : Cleared!";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.BackColor = Color.Transparent;
            levelLabel.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            levelLabel.ForeColor = Color.Black;
            levelLabel.Location = new Point(12, 13);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(122, 32);
            levelLabel.TabIndex = 20;
            levelLabel.Text = "Level : 1";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.zombie_left;
            pictureBox7.Location = new Point(1247, 362);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 70);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "zombie";
            // 
            // wallDef
            // 
            wallDef.BackColor = Color.Transparent;
            wallDef.Image = Properties.Resources.erodaxia_summary;
            wallDef.Location = new Point(359, 215);
            wallDef.Name = "wallDef";
            wallDef.Size = new Size(100, 291);
            wallDef.SizeMode = PictureBoxSizeMode.StretchImage;
            wallDef.TabIndex = 23;
            wallDef.TabStop = false;
            wallDef.Tag = "wallDef";
            // 
            // killLabel
            // 
            killLabel.AutoSize = true;
            killLabel.BackColor = Color.Transparent;
            killLabel.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            killLabel.ForeColor = Color.Black;
            killLabel.Location = new Point(1145, 13);
            killLabel.Name = "killLabel";
            killLabel.Size = new Size(152, 32);
            killLabel.TabIndex = 24;
            killLabel.Text = "Zombie : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.level1_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1351, 480);
            Controls.Add(killLabel);
            Controls.Add(wallDef);
            Controls.Add(pictureBox7);
            Controls.Add(levelLabel);
            Controls.Add(levelCleared);
            Controls.Add(healthBar);
            Controls.Add(wall);
            Controls.Add(bullet);
            Controls.Add(gunner);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(fence);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)gunner).EndInit();
            ((System.ComponentModel.ISupportInitialize)fence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)wallDef).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gunner;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox fence;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox bullet;
        private PictureBox wall;
        private ProgressBar healthBar;
        private Label levelCleared;
        private Label levelLabel;
        private PictureBox pictureBox7;
        private PictureBox wallDef;
        private Label killLabel;
    }
}