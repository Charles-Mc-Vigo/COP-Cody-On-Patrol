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
            wallDef = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            labelScore = new Label();
            wall = new PictureBox();
            healthBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)gunner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wallDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall).BeginInit();
            SuspendLayout();
            // 
            // gunner
            // 
            gunner.BackColor = Color.Transparent;
            gunner.Image = Properties.Resources.shooting_instance_2;
            gunner.Location = new Point(292, 403);
            gunner.Name = "gunner";
            gunner.Size = new Size(67, 98);
            gunner.SizeMode = PictureBoxSizeMode.StretchImage;
            gunner.TabIndex = 0;
            gunner.TabStop = false;
            gunner.Tag = "gunner";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // fence
            // 
            fence.BackColor = Color.Transparent;
            fence.Image = Properties.Resources.w;
            fence.Location = new Point(557, 335);
            fence.Name = "fence";
            fence.Size = new Size(145, 75);
            fence.SizeMode = PictureBoxSizeMode.StretchImage;
            fence.TabIndex = 3;
            fence.TabStop = false;
            fence.Tag = "fence";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.w;
            pictureBox2.Location = new Point(24, 339);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "fence";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.w;
            pictureBox3.Location = new Point(276, 335);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "fence";
            // 
            // bullet
            // 
            bullet.BackColor = Color.Transparent;
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(347, 445);
            bullet.Name = "bullet";
            bullet.Size = new Size(90, 30);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 6;
            bullet.TabStop = false;
            bullet.Tag = "bullet";
            // 
            // wallDef
            // 
            wallDef.BackColor = Color.Transparent;
            wallDef.Image = Properties.Resources.wall_def;
            wallDef.Location = new Point(391, 485);
            wallDef.Name = "wallDef";
            wallDef.Size = new Size(80, 80);
            wallDef.SizeMode = PictureBoxSizeMode.StretchImage;
            wallDef.TabIndex = 7;
            wallDef.TabStop = false;
            wallDef.Tag = "wallDef";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.wall_def;
            pictureBox4.Location = new Point(391, 445);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wallDef";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.wall_def;
            pictureBox5.Location = new Point(391, 405);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wallDef";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.wall_def;
            pictureBox6.Location = new Point(391, 363);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wallDef";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.zombie_left;
            pictureBox1.Location = new Point(1415, 381);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "zombie";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.zombie_left;
            pictureBox7.Location = new Point(1415, 480);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 80);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "zombie";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Britannic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(522, 12);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(166, 41);
            labelScore.TabIndex = 13;
            labelScore.Text = "Score : 0";
            // 
            // wall
            // 
            wall.BackColor = Color.Transparent;
            wall.Image = Properties.Resources.wall_def;
            wall.Location = new Point(756, 2);
            wall.Name = "wall";
            wall.Size = new Size(48, 54);
            wall.SizeMode = PictureBoxSizeMode.StretchImage;
            wall.TabIndex = 14;
            wall.TabStop = false;
            wall.Tag = "wall";
            // 
            // healthBar
            // 
            healthBar.ForeColor = Color.Green;
            healthBar.Location = new Point(810, 15);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(161, 35);
            healthBar.TabIndex = 15;
            healthBar.Tag = "healthBar";
            healthBar.Value = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.level1_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 561);
            Controls.Add(healthBar);
            Controls.Add(wall);
            Controls.Add(labelScore);
            Controls.Add(bullet);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Controls.Add(wallDef);
            Controls.Add(gunner);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(fence);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1484, 561);
            MinimizeBox = false;
            MinimumSize = new Size(1484, 561);
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
            ((System.ComponentModel.ISupportInitialize)wallDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall).EndInit();
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
        private PictureBox wallDef;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private Label labelScore;
        private PictureBox wall;
        private ProgressBar healthBar;
    }
}