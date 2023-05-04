namespace Duty_After_Coding
{
    public partial class Form1 : Form
    {
        //below are game variables
        int score = 0;
        bool isShooting;
        int zombieSpeed = 5;
        int gunnerSpeed = 30;
        int bulletSpeed = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gunner.Top -= gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                if (gunner.Top <= 330)
                {
                    gunner.Top += gunnerSpeed;
                    bullet.Top = gunner.Top + bullet.Width / 2;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                gunner.Top += gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                if (gunner.Top >= 470)
                {
                    gunner.Top -= gunnerSpeed;
                    bullet.Top = gunner.Top + bullet.Width / 2;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                isShooting = true;
                bullet.Visible = true;
                bullet.Left = gunner.Left;
                bullet.Top = gunner.Top + bullet.Width / 2;
            }
        }
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
            if (e.KeyCode == Keys.Down)
            {
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
            if (e.KeyCode == Keys.Space)
            {
                gunner.Image = Properties.Resources.shooting_instances;
                isShooting = true;
            }
        }

        public void shoot()
        {
            if (isShooting == true && bullet.Left <= 1500)
            {
                bullet.Left += bulletSpeed;
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            shoot();
            zombieMovement();
            scoring();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bullet.Visible = false;
        }

        public void zombieMovement()
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && (string)z.Tag == "zombie")
                {
                    if (z.Left > gunner.Left)
                    {
                        z.Left -= zombieSpeed;
                    }
                    if (z.Left < gunner.Left)
                    {
                        z.Left += zombieSpeed;
                    }
                    if (z.Top < gunner.Top)
                    {
                        z.Top += zombieSpeed;
                    }
                    if (z.Top > gunner.Top)
                    {
                        z.Top -= zombieSpeed;
                    }
                }
            }
        }
        public void scoring()
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && (string)z.Tag == "zombie")
                {
                    if (bullet.Bounds.IntersectsWith(z.Bounds))
                    {
                        bullet.Visible = false;
                        z.Visible = false;
                        score++;
                        labelScore.Text = $"Score : {score}";

                        Random random = new Random();
                        int y = random.Next(this.ClientSize.Height / 2, this.ClientSize.Height - z.Height);
                        int x = random.Next(1450, 1500);
                        z.Location = new Point(x, y);
                        z.Visible=true;
                    }
                }
            }
        }
    }
}