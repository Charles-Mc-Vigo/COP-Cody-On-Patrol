using System;
using System.Drawing;
using System.Windows.Forms;

namespace Duty_After_Coding
{
    public partial class Form1 : Form
    {
        // below are game variables
        int kill = 0;
        bool isShooting;
        int zombieSpeed = 10;
        int gunnerSpeed = 10;
        int bulletSpeed = 150;

        public Form1()
        {
            InitializeComponent();
        }

        // controls when keys up, down and spacebar are pressed or held
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // gunner will move up with the speed of 30
                gunner.Top -= gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                // this code limits the gunner to go further
                if (gunner.Top <= 270)
                {
                    gunner.Top += gunnerSpeed;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                // gunner will move downward with the speed of 30
                gunner.Top += gunnerSpeed;
                gunner.Image = Properties.Resources.shooting_instances;

                // this code also limits the gunner to go downward or further
                if (gunner.Top >= 405)
                {
                    gunner.Top -= gunnerSpeed;
                }
            }

            // this control is for shooting
            if (e.KeyCode == Keys.Space)
            {
                isShooting = true;
                bullet.Visible = true;
                bullet.Left = gunner.Left;
                bullet.Top = gunner.Top + bullet.Width / 2;
                gunner.Image = Properties.Resources.shooting_instances;
                isShooting = true;
            }
        }

        // controls when keys up, down and spacebar are released
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                gunner.Image = Properties.Resources.shooting_instance_2;
            }
            if (e.KeyCode == Keys.Space)
            {
                gunner.Image = Properties.Resources.shooting_instances;
            }
        }

        // gameTimer
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Shoot();
            zombieMovement();
            wallBar();

            if (!ZombiesExist())
            {
                RespawnZombies(5);
            }
        }

        private void wallBar()
        {
            foreach (Control zombie in this.Controls)
            {
                if (zombie is PictureBox && (string)zombie.Tag == "zombie" && wallDef.Bounds.IntersectsWith(zombie.Bounds))
                {
                    if (healthBar.Value > healthBar.Minimum) // Check if value is greater than the minimum
                    {
                        healthBar.Value--;
                        zombie.Left += zombieSpeed;

                        if (healthBar.Value == 0)
                        {
                            wall.Visible = false; // Hide the wall image
                            zombie.Left -= zombieSpeed;
                        }
                    }
                    break; // Exit the loop after handling the first intersection
                }
            }
        }


        private bool ZombiesExist()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && (string)control.Tag == "zombie")
                {
                    return true; // At least one zombie exists
                }
            }
            return false; // No zombies found
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bullet.Visible = false;
            levelCleared.Visible = false;
        }

        // function for the movement of the zombies
        private void zombieMovement()
        {
            foreach (Control zombie in this.Controls)
            {
                if (zombie is PictureBox && (string)zombie.Tag == "zombie")
                {
                    if (zombie.Left > gunner.Left)
                    {
                        zombie.Left -= zombieSpeed;
                    }
                    if (zombie.Left < gunner.Left)
                    {
                        zombie.Left += zombieSpeed;
                    }
                    if (zombie.Top < gunner.Top)
                    {
                        zombie.Top += zombieSpeed;
                    }
                    if (zombie.Top > gunner.Top)
                    {
                        zombie.Top -= zombieSpeed;
                    }
                }

                if (zombie is PictureBox && (string)zombie.Tag == "zombie")
                {
                    // Check collision with the gunner
                    if (zombie.Bounds.IntersectsWith(gunner.Bounds))
                    {
                        // Game over condition
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        gameTimer.Stop(); // Stop the game timer

                    }
                }
            }
        }

        // Shooting function
        public void Shoot()
        {
            if (isShooting && bullet.Left <= ClientSize.Width)
            {
                bullet.Left += bulletSpeed;
                gunner.Image = Properties.Resources.shooting_instance_2;

                // Check for collision with zombies
                foreach (Control zombie in Controls)
                {
                    if (zombie is PictureBox && (string)zombie.Tag == "zombie" && bullet.Bounds.IntersectsWith(zombie.Bounds))
                    {
                        // Collision detected
                        Controls.Remove(zombie); // Remove the zombie
                        bullet.Visible = false; // Hide the bullet
                        isShooting = false; // Stop shooting

                        kill++;
                        killLabel.Text = $"Kill: {kill}";

                        break; // Exit the loop after handling the first collision
                    }
                }
            }
        }

        public void RespawnZombies(int numberOfZombies)
        {
            for (int i = 0; i < numberOfZombies; i++)
            {
                PictureBox zombie = new PictureBox();
                zombie.Tag = "zombie";
                zombie.BackColor = Color.Transparent;
                zombie.Image = Properties.Resources.zombie_left;
                zombie.SizeMode = PictureBoxSizeMode.StretchImage;
                zombie.Size = new Size(50, 70);
                zombie.Left = ClientSize.Width + (i * 100);
                zombie.Top = gunner.Top;
                this.Controls.Add(zombie);
            }
        }
    }
}
