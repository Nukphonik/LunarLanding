using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarLanding
{
    public partial class Form1 : Form
    {
        private double x, y;
        private double Dx, Dy;
        private int fuel = 100;
        private int ships = 3;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            initGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {/*end vertical if  */
         //account for gravity
            Dy += .0;
            // increment score for being alive
            score += 10000;
            // show ordinary no flames lander
            picLander.Image = MyPics.Images[0];
            // call helper methods to handle details
            moveShip();
            CheckLanding();
            ShowStats();
        }// end tick timer

        private void moveShip()
        {
            //change X and check for boundries
            x += Dx;
            if (x > this.Width - picLander.Width)
            {
                x = 0;
            }
            if (x < 0)
            {
                x = Convert.ToDouble(this.Width - picLander.Width);
            }
            //change in Y and check for boundries
            y += Dy;
            if (y > this.Height - picLander.Height)
            {
                y = 0;
            }
            if (y < 0)
            {
                y = Convert.ToDouble(this.Height - picLander.Height);
            }
            // move piclander to a new location
            picLander.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
        }

        private void CheckLanding()
        {
            /* Get Rectangles from the objects */
            Rectangle rLander = picLander.Bounds;
            Rectangle rPlatform = picPlatform.Bounds;
            // look for an intersection
            if (rLander.IntersectsWith(rPlatform))
            {
                //
                // its either a crash or a landing
                // turn off the timer for a minute
                timer1.Enabled = false;
                if (Math.Abs(Dx) < 1)
                {
                    //horizontal speed ok
                    if (Math.Abs(Dy) < 3)
                    {
                        //vertical speed ok
                        if (Math.Abs(rLander.Bottom- rPlatform.Top) < 3)
                        {
                            // landing on top of platform
                            MessageBox.Show("Good Job on the landing!!!!");
                            fuel += 30;
                            score += 10000;
                        }
                        else
                        {
                            //not on top of platoform
                            MessageBox.Show("you have to land on top ");
                            KillShip();
                        }
                    }// end on top if
                    else
                    { //Dy too large
                        MessageBox.Show("too much vertical velocity");
                        KillShip();
                    }// end vertical if
                }
                else

                {
                    // if Dx too large
                    MessageBox.Show("Too much horizontal velocity");
                    KillShip();

                }// end horizontal if
                //reset the lander
                initGame();
            } // end if
        } // end checking landing

                
        private void KillShip ()
        {
            // kill of a ship , check for end of game
            DialogResult answer;
            ships--;
            if (ships <= 0)
            {
                // game is over
                answer = MessageBox.Show("play again","Game Over", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    ships = 3;
                    fuel = 100;
                    initGame();
                }
                else
                {
                    Application.Exit();
                } // end if
            } // end no ships if
        }   // end kill ship

        private void ShowStats()
        {
            // display the statistics
            labelLx.Text = "dx: " + Dx;
            labelDy.Text = "dy:" + Dy;
            labelFuel.Text = "Fuel:" + fuel;
            labelScore.Text = "Score:" + score;
            labelShips.Text = "Ships:" + ships;
        }// end show stats

        private void initGame()
        {
            // re - initializes game
            Random roller = new Random();
            int platx, platy;
            //find random dx and dy values for lander
            Dx = Convert.ToDouble(roller.Next(5) - 2);
            Dy = Convert.ToDouble(roller.Next(5) - 2);

            // place lander randomly on  form
            //  But make sure it appears
            platx = roller.Next(this.Width - picPlatform.Width);
            platy = roller.Next(this.Height - picPlatform.Height);
            picPlatform.Location = new Point(platx, platy);
            // turn on timer
            timer1.Enabled = true;
        }// end intigame
        private void PicPlatform_Click(object sender, EventArgs e)
        {

        }
        private void PanelScore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelDy_Click(object sender, EventArgs e)
        {

        }

        private void LabelFuel_Click(object sender, EventArgs e)
        {

        }

        private void LabelShips_Click(object sender, EventArgs e)
        {

        }

        private void PicLander_Click(object sender, EventArgs e)
        {

        }

        private void LabelScore_Click(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // executes whenever user presses a key
            // spend sond fuel
            fuel--;
            // check to see if user is out of fuel
            if (fuel < 0)
            {
                timer1.Enabled = true;
                MessageBox.Show("out of fuel");
                fuel += 20;
                KillShip();
                initGame();
            } // end if
            // look for arrow keys
            switch (e.KeyData)
            {
                case Keys.Up:
                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }
                    picLander.Image = MyPics.Images[3];
                    Dy -= 2;
                    break;
                case Keys.Left:
                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }

                    picLander.Image = MyPics.Images[2];
                    Dx++;
                    break;
                case Keys.Right:
                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }

                    picLander.Image = MyPics.Images[1];
                    Dx--;
                    break;
                case Keys.Down:
                    picLander.Image = MyPics.Images[0];
                    Dy += 2;
                //    timer1.Enabled = false;
                    
                    break;
                default:
                    //do nothing
                    break;
            }//End  switch
        } // end key down

        }
    }


