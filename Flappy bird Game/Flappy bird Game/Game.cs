using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird_Game
{
    public partial class Game : Form
    {
        int gravity = 15;
        int pipeSpeed = 8;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeFreeTime = 0;
        int target = 10;
        int level = 1;
        int gameStartOrNot = 0;

        System.Media.SoundPlayer die = new System.Media.SoundPlayer();
        System.Media.SoundPlayer hit = new System.Media.SoundPlayer();
        System.Media.SoundPlayer point = new System.Media.SoundPlayer();
        System.Media.SoundPlayer woosh = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wing = new System.Media.SoundPlayer();

        string str = "";
        public Game(string str, int soundValue,string clr)
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
            defaultPlaybackDevice.Volume = soundValue;

            InitializeComponent();
           
            die.SoundLocation = "die.wav";
            hit.SoundLocation = "hit.wav";
            point.SoundLocation = "point.wav";
            woosh.SoundLocation = "woosh.wav";
            wing.SoundLocation = "wing.wav";
            this.str = str;
            if (!str.Equals("Default"))
            {
                if (str.Equals("Green"))
                {
                    bird.Image = Properties.Resources.greenBird;

                }else if (str.Equals("Red"))
                {
                    bird.Image = Properties.Resources.redBird;

                }
                else if (str.Equals("Blue"))
                {
                    bird.Image = Properties.Resources.blueBird;

                }
            }

            if (clr.Equals("Blue")){
                this.BackColor = Color.DodgerBlue;
            }
            else if (clr.Equals("Green")){
                this.BackColor = Color.Green;
            }
            else if (clr.Equals("Red"))
            {
                this.BackColor = Color.Red;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gameTimeTickEvent(object sender, EventArgs e)
        {
            lifeFreeTime += 20;
            bird.Top += gravity;
            pipe_bottom.Left -= pipeSpeed;
            pipe_top.Left -= pipeSpeed;
            exLife.Left -= pipeSpeed;

            if(bird.Top > 310)
            {
                bird.Top = 310;
            }

            if (bird.Top < 0)
            {
                bird.Top = 0;
            }

            if (level > 2)
            {
                pipe_top2.Left -= pipeSpeed;
            }

            birdFadingEffect();
            levelStatus();

            if (bird.Bounds.IntersectsWith(pipe_top.Bounds) || bird.Bounds.IntersectsWith(pipe_bottom.Bounds) || bird.Bounds.IntersectsWith(pipe_top2.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (bird.Bounds.IntersectsWith(exLife.Bounds) && lifeCount < 3)
            {
                extraLifeFunction();
            }

            if (exLife.Left < -10)
            {
                exLife.Left = 10000;
            }

            if (lifeCount == 1)
            {
                life1.Visible = true;
            }

            if (lifeCount == 2)
            {
                life2.Visible = true;
            }

            if (lifeCount == 3)
            {
                life3.Visible = true;
            }

            score_lbl.Text = "Score : " + gameScore;

            if (gameScore == target && level < 5)
            {
                game_time.Stop();
                gameOverLabel.Visible = true;
                gameOverLabel.Text = "You have completed level " + level;
                nxlLevelbtn.Visible = true;
                restartbtn.Visible = true;
            }
        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        

        private void endGame()
        {
            if (lifeCount == 0 && lifeFreeTime > 3000)
            {
                game_time.Stop();
                gameOverLabel.Text = "Game Over!!!\nYour Score is :  " + gameScore;
                gameOverLabel.Visible = true;
                restartbtn.Visible=true;
                restartbtn.Location = new Point(286, 212);
                die.Play();
            }else
            {
                switch (lifeCount) 
                {
                    case 3:
                        if (lifeFreeTime > 2500)
                        {
                            life3.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            hit.Play();
                        }

                        break;
                    case 2:
                        if (lifeFreeTime > 2500)
                        {
                            life2.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            hit.Play();
                        }

                        break;

                    case 1:
                        if (lifeFreeTime > 2500)
                        {
                            life1.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            hit.Play();
                        }

                        break;
                }

                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void birdFadingEffect()
        {
            if (bird.Visible == true && lifeFreeTime < 2500)
            {
                bird.Visible = false;
            }
            else if (bird.Visible == false && lifeFreeTime < 2500)
            {
                bird.Visible = true;
            }
            else 
            {
                bird.Visible = true;
            }
        }

        private void extraLifeFunction()
        {
            if (lifeCount < 3)
            {
                lifeCount++;
                exLife.Left = 15000;
                woosh.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pipe_bottom_Click(object sender, EventArgs e)
        {

        }

        private void nextLevel()
        {
            level++;
            lvlTarget();
            gameScore = 0;
            lifeFreeTime = 0;
            gameStartOrNot = 0;
            levellbl.Text = "Level : " + level;
            bird.Location = new Point(40, 142);
            pipe_bottom.Location = new Point(357, 280);
            pipe_top.Location = new Point(355, -1);
            pipe_top2.Location = new Point(842, -1);
            exLife.Location = new Point(311, 46);
            lifeCount = 3;
            life1.Visible = true;
            life2.Visible = true;
            life3.Visible = true;

            if (level == 5)
            {
                lifeCount = 2;
                life3.Visible = false;
            }
        }

        private void lvlTarget() {
            if (level == 2)
            {
                target = 25;
            }
            else if (level == 3)
            {
                target = 40;
            }
            else if (level == 4)
            {
                target = 60;
            }
            else if (level == 5) {
                target = 0;
            }
            
        }

        private void levelStatus()
        {
            if(level == 1)
            {
                if (pipe_bottom.Left < -150)
                {
                    pipe_bottom.Left = 750;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }  
                }
                if (pipe_top.Left < -80)
                {
                    pipe_top.Left = 950;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }               
            }

            if (level == 2)
            {
                pipeSpeed = 12;

                if (pipe_bottom.Left < -150)
                {
                    pipe_bottom.Left = 750;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
                if (pipe_top.Left < -80)
                {
                    pipe_top.Left = 950;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }       
            }

            if (level == 3)
            {
                pipeSpeed = 12;
                
                if (pipe_bottom.Left < -30)
                {
                    pipe_bottom.Left = 700;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
                if (pipe_top.Left < -60)
                {
                    pipe_top.Left = 750;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }

                if (pipe_top2.Left < -550)
                {
                    pipe_top2.Left = 2000;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
            }

            if (level == 4)
            {
                pipeSpeed = 16;

                if (pipe_bottom.Left < -30)
                {
                    pipe_bottom.Left = 700;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
                if (pipe_top.Left < -60)
                {
                    pipe_top.Left = 750;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }

                if (pipe_top2.Left < -550)
                {
                    pipe_top2.Left = 2000;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
            }

            if (level == 5)
            {
                pipeSpeed = 18;

                if (pipe_bottom.Left < -30)
                {
                    pipe_bottom.Left = 700;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
                if (pipe_top.Left < -60)
                {
                    pipe_top.Left = 750;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }

                if (pipe_top2.Left < -100)
                {
                    pipe_top2.Left = 910;
                    gameScore++;
                    if (gameStartOrNot != 0)
                    {
                        point.Play();
                    }
                }
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (gameStartOrNot == 0)
                {
                    game_time.Start();
                    gameStartOrNot++;
                }
                gravity = -15;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void nxlLevelbtn_Click(object sender, EventArgs e)
        {
            nextLevel();
            gameOverLabel.Visible = false;
            nxlLevelbtn.Visible = false;
            restartbtn.Visible = false;
            score_lbl.Text = "Score : " + gameScore;
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            level = 1;
            life1.Visible = true;
            life2.Visible = true;
            life3.Visible = true;
            lifeCount = 3;
            lifeFreeTime = 0;
            target = 10;
            gameStartOrNot = 0;
            gameScore = 0;
            gameOverLabel.Visible = false;
            nxlLevelbtn.Visible = false;
            restartbtn.Visible = false;
            bird.Location = new Point(40, 142);
            pipe_bottom.Location = new Point(357, 280);
            pipe_top.Location = new Point(355, -1);
            pipe_top2.Location = new Point(842, -1);
            exLife.Location = new Point(311, 46);
            restartbtn.Location = new Point(375, 212);
            score_lbl.Text = "Score : " + gameScore;
            levellbl.Text = "Level : " + level;
        }
    }
    }
