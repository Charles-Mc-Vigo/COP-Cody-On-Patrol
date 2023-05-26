using System.Diagnostics;

namespace Duty_After_Coding
{
    public partial class Form2 : Form
    {
        //below are game variables
        int zombieHealth = 3;
        int killedRequired = 50;
        int killed = 0;
        bool isShooting;
        int zombieSpeed = 7;
        int gunnerSpeed = 10;
        int bulletSpeed = 200;

        public Form2()
        {
            InitializeComponent();
        }

        //controls when keys up,down and spacebar are press or hold
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //gunner will move up with the speed of 30
                gunner.Top -= gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                //this code limits the gunner to go further
                if (gunner.Top <= 330)
                {
                    gunner.Top += gunnerSpeed;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                //gunner will move downward with the speed of 30
                gunner.Top += gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                //this code also limit the gunner to go downward or further
                if (gunner.Top >= 470)
                {
                    gunner.Top -= gunnerSpeed;
                }
            }


            //this control is for shooting
            if (e.KeyCode == Keys.Space)
            {
                isShooting = true;
                bullet.Visible = true;
                bullet.Left = gunner.Left;
                bullet.Top = gunner.Top + bullet.Width / 2;
            }
        }

        //controls when keys up,down and spacebar are release
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

        //shooting function
        public void shoot()
        {
            if (isShooting == true && bullet.Left <= this.ClientSize.Width)
            {
                bullet.Left += bulletSpeed;
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
        }

        //gameTimer
        private void gameTimer2_Tick(object sender, EventArgs e)
        {
            shoot();
            zombieMovement();
            scoring();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bullet.Visible = false;
            labelWaveCleared.Visible = false;
        }

        //function for the movement of the zombies
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

        //function for scoring
        public void scoring()
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && (string)z.Tag == "zombie")
                {
                    //condition if the bullet hits the zombie
                    if (bullet.Bounds.IntersectsWith(z.Bounds))
                    {
                        zombieHealth--;

                        if (zombieHealth == 0)
                        {
                            z.Visible = false;
                            //code that count the required number of zombies to win
                            killed++;
                            labelKilled.Text = $"Zombie : {killed}/50";

                            Random random = new Random();
                            int y = random.Next(this.ClientSize.Height / 2, this.ClientSize.Height - z.Height);
                            int x = random.Next(1450, 1500);
                            z.Location = new Point(x, y);

                            Controls.Add(z);
                        }

                    }
                }
                if (killed == killedRequired)
                {
                    labelWaveCleared.Visible = true;
                    break;
                }
            }
        }

    }
}