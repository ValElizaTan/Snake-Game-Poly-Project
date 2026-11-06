using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        SoundPlayer GenshinImpactThemeSong;
        Snake mySnake;
        Board mainBoard;
        Rewards primo;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 300; //300ms
        int score;
        int level;
        string name;
        List<Score> scores;

        public Form1()
        {
            MessageBox.Show("Please enter your name.\n" +
                "Name is not needed if you want to remain Anonymous.\n" +
                "Press \"Start\" to start the game.\n" +
                "How the game works:\nPress Right or Down arrow key to offically move the snake." +
                "\nIt is a continuous game once ur done press \"End Game\".\n" +
                "Scores will be recorded in the end.\n");  //Instruction for the game.

            InitializeComponent();

            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;

            gotoNextLevel(level);

            //Sound player 
            GenshinImpactThemeSong = new SoundPlayer(Properties.Resources.Genshin_Impact_Theme_Song);
            GenshinImpactThemeSong.LoadAsync();


            DialogResult = DialogResult.OK;  //it returns the ok value
            StreamReader sr = new StreamReader("C:\\tmp\\leaderboard.txt", true);
            sr.Close();

        }

        private void gotoNextLevel(int nextLevel)
        {
            mode = "REST";
            mySnake = new Snake(mainBoard); //Brand new snake with length 1
            primo = new Rewards(nextLevel, mainBoard); //<--- Generate 5 apples
        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        private void upleftBTN_Click(object sender, EventArgs e)
        {
            mode = "UP-LEFT";
        }

        private void uprightBTN_Click(object sender, EventArgs e)
        {
            mode = "UP-RIGHT";
        }

        private void downleftBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN-LEFT";
        }

        private void downrightBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN-RIGHT";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            primo.draw();  //<----- draw apples
            mySnake.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (primo.checkIFSnakeHeadEatApple( mySnake.getHeadPosition()) == true)
            {
                score += primo.eatPrimoAtPostion(mySnake.getHeadPosition());

                scoreLBL.Text = Convert.ToString(score);


                if (primo.noMorePrimo() == true)
                {
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
            GenshinImpactThemeSong.PlayLooping();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            GameOver();
            clock.Stop();
            this.Close();
            GenshinImpactThemeSong.Stop();
        }

        private void GameOver()
        {
            Score s;
            scores = new List<Score>();
            scoreLBL.Text = Convert.ToString(score);
            s = new Score(name, score);
            scores.Add(s);
            StreamWriter sw = new StreamWriter("C:\\tmp\\leaderboard.txt", true); //data is assembled into a list of type score
            for (int i = 0; i < scores.Count; i++)
            {
                sw.WriteLine(s.getName() + "," + s.getScore());
            }
            sw.Close();
            gameover gameover = new gameover(score);
            gameover.ShowDialog();
            //this.Close();
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
           name = Convert.ToString(nameTB.Text);
        }
    }
}
