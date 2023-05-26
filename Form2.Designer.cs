namespace Duty_After_Coding
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            labelKilled = new Label();
            labelWaveCleared = new Label();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            healthBar = new ProgressBar();
            wall = new PictureBox();
            bullet = new PictureBox();
            wallDef = new PictureBox();
            gunner = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            fence = new PictureBox();
            pictureBox4 = new PictureBox();
            gameTimer2 = new System.Windows.Forms.Timer(components);
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wallDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(632, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 36;
            label1.Text = "Wave 2";
            // 
            // labelKilled
            // 
            labelKilled.AutoSize = true;
            labelKilled.BackColor = Color.Transparent;
            labelKilled.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelKilled.ForeColor = Color.White;
            labelKilled.Location = new Point(1232, 21);
            labelKilled.Name = "labelKilled";
            labelKilled.Size = new Size(209, 32);
            labelKilled.TabIndex = 35;
            labelKilled.Text = "Zombie  : 0/50";
            // 
            // labelWaveCleared
            // 
            labelWaveCleared.AutoSize = true;
            labelWaveCleared.BackColor = Color.Transparent;
            labelWaveCleared.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelWaveCleared.ForeColor = Color.White;
            labelWaveCleared.Location = new Point(576, 429);
            labelWaveCleared.Name = "labelWaveCleared";
            labelWaveCleared.Size = new Size(526, 71);
            labelWaveCleared.TabIndex = 34;
            labelWaveCleared.Text = "Wave 2 : Cleared!";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.zombie_left;
            pictureBox7.Location = new Point(1403, 482);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 80);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "zombie";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = Properties.Resources.zombie_left;
            pictureBox9.Location = new Point(1329, 383);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(69, 80);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "zombie";
            // 
            // healthBar
            // 
            healthBar.ForeColor = Color.Green;
            healthBar.Location = new Point(798, 12);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(161, 35);
            healthBar.TabIndex = 32;
            healthBar.Tag = "healthBar";
            healthBar.Value = 100;
            // 
            // wall
            // 
            wall.BackColor = Color.Transparent;
            wall.Image = Properties.Resources.wall_def;
            wall.Location = new Point(744, -1);
            wall.Name = "wall";
            wall.Size = new Size(48, 54);
            wall.SizeMode = PictureBoxSizeMode.StretchImage;
            wall.TabIndex = 31;
            wall.TabStop = false;
            wall.Tag = "wall";
            // 
            // bullet
            // 
            bullet.BackColor = Color.Transparent;
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(336, 448);
            bullet.Name = "bullet";
            bullet.Size = new Size(90, 15);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.TabIndex = 25;
            bullet.TabStop = false;
            bullet.Tag = "bullet";
            // 
            // wallDef
            // 
            wallDef.BackColor = Color.Transparent;
            wallDef.Image = Properties.Resources.wall_def;
            wallDef.Location = new Point(379, 482);
            wallDef.Name = "wallDef";
            wallDef.Size = new Size(80, 80);
            wallDef.SizeMode = PictureBoxSizeMode.StretchImage;
            wallDef.TabIndex = 26;
            wallDef.TabStop = false;
            wallDef.Tag = "wallDef";
            // 
            // gunner
            // 
            gunner.BackColor = Color.Transparent;
            gunner.Image = Properties.Resources.shooting_instance_2;
            gunner.Location = new Point(245, 402);
            gunner.Name = "gunner";
            gunner.Size = new Size(67, 98);
            gunner.SizeMode = PictureBoxSizeMode.StretchImage;
            gunner.TabIndex = 21;
            gunner.TabStop = false;
            gunner.Tag = "gunner";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.w;
            pictureBox3.Location = new Point(264, 332);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "fence";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.w;
            pictureBox2.Location = new Point(113, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "fence";
            // 
            // fence
            // 
            fence.BackColor = Color.Transparent;
            fence.Image = Properties.Resources.w;
            fence.Location = new Point(466, 332);
            fence.Name = "fence";
            fence.Size = new Size(145, 75);
            fence.SizeMode = PictureBoxSizeMode.StretchImage;
            fence.TabIndex = 22;
            fence.TabStop = false;
            fence.Tag = "fence";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.wall_def;
            pictureBox4.Location = new Point(379, 442);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wallDef";
            // 
            // gameTimer2
            // 
            gameTimer2.Enabled = true;
            gameTimer2.Interval = 20;
            gameTimer2.Tick += gameTimer2_Tick;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.wall_def;
            pictureBox5.Location = new Point(379, 402);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wallDef";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.wall_def;
            pictureBox6.Location = new Point(379, 360);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wallDef";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.secondBackgroung1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 561);
            Controls.Add(label1);
            Controls.Add(labelKilled);
            Controls.Add(labelWaveCleared);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox9);
            Controls.Add(healthBar);
            Controls.Add(wall);
            Controls.Add(bullet);
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
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)wallDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelKilled;
        private Label labelWaveCleared;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private ProgressBar healthBar;
        private PictureBox wall;
        private PictureBox bullet;
        private PictureBox wallDef;
        private PictureBox gunner;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox fence;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer gameTimer2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}