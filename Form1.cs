namespace Duty_After_Coding
{
    public partial class Form1 : Form
    {
        //below are game variables
        bool isShooting;
        int zombieSpeed = 3;
        int gunnerSpeed = 30;
        int bulletSpeed = 200;
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
                shoot();
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
            if (isShooting == true && bullet.Left <= 1470)
            {
                bullet.Left += bulletSpeed;
                bullet.Top = gunner.Top + bullet.Width / 2;
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
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    x.Left -= zombieSpeed;
                }
            }
        }
        public void scoring()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                        bullet.Visible = false;
                    }
                }
            }
        }
    }
}