using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Race
{
    public partial class Form1 : Form
    {
        //Global Variables 
        Rectangle ship1 = new Rectangle(150, 590, 10, 25);
        Rectangle ship2 = new Rectangle(325, 590, 10, 25);
        Rectangle timeBar = new Rectangle(240, 0, 5, 600);
        int shipSpeed = 3;

        //Lists 
        List<Rectangle> tangle = new List<Rectangle>();
        List<int> tangleSpeeds = new List<int>();

        //Them key presses 
        bool upArrow = false;
        bool downArrow = false;
        bool wDown = false;
        bool sDown = false;

        //Brushes
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        //That when the title screen
        string gameState = "waiting";

        //Randomizer
        Random randGen = new Random();
        int randValue = 0;
        int randH = 0;
        
        //Keeping those scores
        int scoreP1 = 0;
        int scoreP2 = 0;   
        int time = 1250;

        ///Gamestates
        public void GameInitialize()
        {
            gameEngine.Enabled = true;
            gameState = "running";

            

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrow = true;
                    break;
                case Keys.Down:
                    downArrow = true;
                    break;
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        GameInitialize();
                    }
                    break;
                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrow = false;
                    break;
                case Keys.Down:
                    downArrow = false;
                    break;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //moving them thangs player 1 on that y axis
            if (wDown == true && ship1.Y > 0)
            {
                ship1.Y -= shipSpeed;
            }
            if (sDown == true && ship1.Y < this.Height - ship1.Height)
            {
                ship1.Y += shipSpeed;
            }

            //moving them thangs player 2 style
            if (upArrow == true && ship2.Y > 0)
            {
                ship2.Y -= shipSpeed;
            }
            if (downArrow == true && ship2.Y < this.Height - ship2.Height)
            {
                ship2.Y += shipSpeed;
            }

            //Line moving
            for (int i = 0; i < tangle.Count; i++)
            {
                int x = tangle[i].X + tangleSpeeds[i];
                tangle[i] = new Rectangle(x, tangle[i].Y, 14, 4);
            }

            //Generator 
            randValue = randGen.Next(1, 101);

            //Lines making

               if (randValue < 25)
               {
                    randH = randGen.Next(1, 580);
                    tangle.Add(new Rectangle(-14, randH, 14, 4));
                    tangleSpeeds.Add(randGen.Next(3,14));
               }
               else if (randValue > 85)
               {
                    tangle.Add(new Rectangle(this.Width, randH, 14, 4));
                    tangleSpeeds.Add(randGen.Next(3, 14) * -1);
               }


            //Reset Ships on impact
            for (int i = 0; i < tangle.Count - 1; i++)
            {
                if (ship1.IntersectsWith(tangle[i]))
                {
                    ship1.X = 150;
                    ship1.Y = 590;
                }
                if (ship2.IntersectsWith(tangle[i]))
                {
                    ship2.X = 325;
                    ship2.Y = 590;
                }
            }
            
            //Point System
            if (ship1.Y == 5)
            {
                ship1.X = 150;
                ship1.Y = 590;
                scoreP1++;
                p1Score.Text = $"{scoreP1}";
            }
            if (ship2.Y == 5)
            {
                ship2.X = 325;
                ship2.Y = 590;
                scoreP2++;
                p2Score.Text = $"{scoreP2}";
            }

            //timer
            time--;

            if (time == 0)
            {
                gameEngine.Enabled = false;
                gameState = "over";
            }

            

            //Refresh
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw SHIP one and two
            e.Graphics.FillRectangle(whiteBrush, ship1);
            e.Graphics.FillRectangle(whiteBrush, ship2);
            e.Graphics.FillRectangle(whiteBrush, timeBar);

            for (int i = 0; i < tangle.Count(); i++)
            {
               e.Graphics.FillRectangle(whiteBrush, tangle[i]);
            }

            if (gameState == "waiting")
            {
                titleLabel.Text = "Press Space to Start \nEscape to End The Game";
                titleLabel.Visible = true;
                p1Score.Text = "0";
                p2Score.Text = "0";

            }
            else if (gameState == "running")
            {
                // draw text at top 
                titleLabel.Visible = false;
            }
            else if (gameState == "over")
            {
                titleLabel.Visible = true;
                p1Score.Text = "0";
                p2Score.Text = "0";

                titleLabel.Text = "GAME OVER";

                titleLabel.Text = $"The Game is Over\n Press Space to Play Again\nEscape To Exit";
                

            }

        }

        
    }
}
