using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunar_Lander
{
    /// <summary>
    /// Practice with keyboard controls and animations.
    /// Anthony Senior, 3/19/2016
    /// </summary>

    public partial class Form1 : Form
    {
        private double x, y;        // will show new position of lander
        private double dx, dy;      // difference in x and y
        private int fuel = 100;     // how much fuel is left
        private int landers = 3;    // number of landers ("lives") player has left
        private int score = 0;      // the player's current score


        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dy += .5;                               // gravity
            score += 100;                           // increment score for being alive
            picLander.Image = myPics.Images[0];     // no-flames lander (default)

            MoveShip();
            CheckLanding();
            ShowStats();
        }// end timer1_Tick

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            fuel--;

            if (fuel < 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Out of fuel!");
                fuel += 20;
                KillShip();
                InitGame();
            }

            switch(e.KeyData)
            {
                case Keys.Space:
                    picLander.Image = myPics.Images[1];
                    dy -= 2;
                    break;
                case Keys.Left:
                    picLander.Image = myPics.Images[0];
                    dx--;
                    break;
                case Keys.Right:
                    picLander.Image = myPics.Images[0];
                    dx++;
                    break;
            }
        }//end Form1_KeyDown

        private void MoveShip()
        {
            //----------- Change x and check for boundaries -----------//
            x += dx;

            if (x > this.Width - picLander.Width)
            {
                x = 0;
            }

            if (x < 0)
            {
                x = Convert.ToDouble(this.Width - picLander.Width);
            }

            //----------- Change y and check for boundaries -----------//
            y += dy;

            if (y > this.Height - picLander.Height)
            {
                y = 0;
            }

            if (y < 0)
            {
                y = Convert.ToDouble(this.Height - picLander.Height);
            }

            picLander.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y)); //move picLander to new location

        }// end MoveShip()

        private void CheckLanding()
        {
            //get rectangle from objects
            Rectangle rLander = picLander.Bounds;
            Rectangle rPlatform = picPlatform.Bounds;

            //look for an intersection
            if (rLander.IntersectsWith (rPlatform))
            {
                timer1.Enabled = false;

                if (Math.Abs(dx) < 1)
                {
                    if (Math.Abs(dy) < 3)
                    {
                        if (Math.Abs(rLander.Bottom - rPlatform.Top) < 3)
                        {
                            MessageBox.Show("Good landing!");
                            fuel += 30;
                            score += 10000;
                        }
                        else
                        {
                            MessageBox.Show("You must land on top of the platform!");
                            KillShip();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too much vertical velocity");
                        KillShip();
                    }
                }
                else
                {
                    MessageBox.Show("Too much horizontal velocity");
                    KillShip();
                }

                InitGame();

            }
        }// end CheckLanding()

        public void ShowStats()
        {
            labelDx.Text = "dx: " + dx;
            labelDy.Text = "dy: " + dy;
            labelFuel.Text = "fuel: " + fuel;
            labelLanders.Text = "landers: " + landers;
            labelScore.Text = "score: " + score;
        }// end ShowStats()

        public void KillShip()
        {
            DialogResult answer;
            landers--;
            if (landers <= 0)
            {
                answer = MessageBox.Show("Play Again?", "Game Over", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    landers = 3;
                    fuel = 100;
                    InitGame();
                }
                else
                {
                    Application.Exit();
                }
            }

        }// end KillShip()

        public void InitGame()
        {
            // re-initialize the game
            Random random = new Random();
            int platX, platY;

            // find random dx and dy values for the lander
            dx = Convert.ToDouble(random.Next(5) - 2);
            dy = Convert.ToDouble(random.Next(5) - 2);

            // place lander randomly on form
            x = Convert.ToDouble(random.Next(this.Width));
            y = Convert.ToDouble(random.Next(this.Height));

            // place platform randomly on form
            platX = random.Next(this.Width - picPlatform.Width);
            platY = random.Next(this.Height - picPlatform.Height);
            picPlatform.Location = new Point(platX, platY);

            // turn on timer
            timer1.Enabled = true;

        }// end InitGame()

    }//end Class
}//end Namespace
