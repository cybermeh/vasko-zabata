using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace VaskoZabataGame
{
    public partial class MainForm : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int stoneImage;
        int lifes = 0;
        bool isMusicActive = true;

        private SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.song);
        private SoundPlayer crashPlayer = new SoundPlayer(Properties.Resources.hit2);

        Random random = new Random();

        bool goLeft, goRight;

        static Timer pondSpawnTimer = new Timer();


        public MainForm()
        {
            InitializeComponent();
            ResetGame();
        }

        private void StartMusic()
        {
            musicPlayer.PlayLooping();
        }

        private void StopMusic()
        {
            musicPlayer.Stop();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            score++;


            if (goLeft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;
            AI3.Top += trafficSpeed;
            Pond.Top += trafficSpeed;


            if (AI1.Top > 530)
            {
                ChangeAIStones(AI1);
            }

            if (AI2.Top > 530)
            {
                ChangeAIStones(AI2);
            }

            if (AI3.Top > 530)
            {
                ChangeAIStones(AI3);
            }

            if (Pond.Top > 530)
            {
                Pond.Visible = false;
            }

            CheckCollision();
            UpdateSpeed();
        }

        void SpawnPond(Object myObject, EventArgs myEventArgs)
        {
            if (Pond.Visible)
            {
                return;
            }

            int chance = random.Next(1, 100);
            
            if (chance < 30)
            {
                Pond.Visible = true;
                Pond.Top = random.Next(100, 400) * -1;

                Pond.Left = random.Next(0, 422);

                while (Pond.Bounds.IntersectsWith(AI1.Bounds) || Pond.Bounds.IntersectsWith(AI2.Bounds) || Pond.Bounds.IntersectsWith(AI3.Bounds))
                {
                    Pond.Left = random.Next(0, 422);
                }
            }
        }


        void CheckCollision()
        {
            if (player.Bounds.IntersectsWith(AI1.Bounds))
            {
                RemoveLife(AI1);
            }

            if (player.Bounds.IntersectsWith(AI2.Bounds))
            {
                RemoveLife(AI2);
            }

            if (player.Bounds.IntersectsWith(AI3.Bounds))
            {
                RemoveLife(AI3);
            }

            if (player.Bounds.IntersectsWith(Pond.Bounds) && Pond.Visible)
            {
                AddLife();
            }
        }

        void SetLifeActive(PictureBox life)
        {
            life.Image = Properties.Resources.lifeActive;
        }


        void SetLifeInactive(PictureBox life)
        {
            life.Image = Properties.Resources.lifeInactive;
        }


        void AddLife()
        {
            switch (lifes)
            {
                case 0:
                    SetLifeActive(Life1);
                    lifes++;
                    Pond.Visible = false;
                    break;
                case 1:
                    SetLifeActive(Life2);
                    lifes++;
                    Pond.Visible = false;
                    break;
                case 2:
                    SetLifeActive(Life3);
                    lifes++;
                    Pond.Visible = false;
                    break;
                case 3:
                    Pond.Visible = false;
                    break;
            }
        }

        void RemoveLife(PictureBox stone)
        {
            stone.Top += 200;

            switch (lifes)
            {
                case 0:
                    GameOver();
                    break;
                case 1:
                    SetLifeInactive(Life1);
                    lifes--;
                    break;
                case 2:
                    SetLifeInactive(Life2);
                    lifes--;
                    break;
                case 3:
                    SetLifeInactive(Life3);
                    lifes--;
                    break;
            }
        }


        void UpdateSpeed()
        {
            if (score > 200 && score < 300)
            {
                roadSpeed = 13;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 300 && score < 500)
            {
                roadSpeed = 14;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 500 && score < 800)
            {
                roadSpeed = 15;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 800 && score < 1000)
            {
                roadSpeed = 16;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 1000 && score < 1200)
            {
                roadSpeed = 18;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 1200 && score < 1500)
            {
                roadSpeed = 19;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 1500 && score < 1800)
            {
                roadSpeed = 20;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 2000 && score < 2500)
            {
                roadSpeed = 21;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 2500 && score < 3000)
            {
                roadSpeed = 22;
                trafficSpeed = roadSpeed + 3;
            }

            if (score > 3000 && score < 4000)
            {
                roadSpeed = 23;
                trafficSpeed = roadSpeed + 3;
            }
        }

        void SetLeftStoneNextPosition(PictureBox tempStone)
        {
            tempStone.Left = random.Next(5, 105);
            
            while (tempStone.Bounds.IntersectsWith(AI2.Bounds) || (Pond.Visible && tempStone.Bounds.IntersectsWith(Pond.Bounds)))
            {
                tempStone.Left = random.Next(5, 105);
            }
        }

        void SetCenterStoneNextPosition(PictureBox tempStone)
        {
            tempStone.Left = random.Next(155, 260);
            
            while (tempStone.Bounds.IntersectsWith(AI1.Bounds) || tempStone.Bounds.IntersectsWith(AI3.Bounds) || (Pond.Visible && tempStone.Bounds.IntersectsWith(Pond.Bounds)))
            {
                tempStone.Left = random.Next(155, 260);
            }
        }

        void SetRightStoneNextPosition(PictureBox tempStone)
        {
            tempStone.Left = random.Next(310, 422);
            
            while (tempStone.Bounds.IntersectsWith(AI2.Bounds) || (Pond.Visible && tempStone.Bounds.IntersectsWith(Pond.Bounds)))
            {
                tempStone.Left = random.Next(310, 422);
            }
        }


        private void ChangeAIStones(PictureBox tempStone)
        {

            stoneImage = random.Next(1, 4);

            switch (stoneImage)
            {

                case 1:
                    tempStone.Image = Properties.Resources.stone1;
                    break;
                case 2:
                    tempStone.Image = Properties.Resources.stone2;
                    break;
                case 3:
                    tempStone.Image = Properties.Resources.stone3;
                    break;
            }


            tempStone.Top = random.Next(100, 400) * -1;

            switch ((string)tempStone.Tag)
            {
                case "leftStone":
                    SetLeftStoneNextPosition(tempStone);
                    break;
                case "centerStone":
                    SetCenterStoneNextPosition(tempStone);
                    break;
                case "rightStone":
                    SetRightStoneNextPosition(tempStone);
                    break;
            } 
        }

        private void GameOver()
        {
            gameTimer.Stop();
            musicPlayer.Stop();
            crashPlayer.Play();
            blood.Visible = true;
            player.Controls.Add(blood);
            blood.Location = new Point(5, 5);
            blood.BackColor = Color.Transparent;

            award.Visible = true;
            award.BackColor = Color.Transparent;
            award.BringToFront();

            btnStart.Enabled = true;

            pondSpawnTimer.Stop();
        }

        private void ResetGame()
        {

            btnStart.Enabled = false;
            blood.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = random.Next(200, 500) * -1;
            SetLeftStoneNextPosition(AI1);

            AI2.Top = random.Next(200, 500) * -1;
            SetCenterStoneNextPosition(AI2);

            AI3.Top = random.Next(200, 500) * -1;
            SetRightStoneNextPosition(AI3);

            gameTimer.Start();

            if (isMusicActive)
            {
                StartMusic();
            }
            

            pondSpawnTimer.Interval = 1000;
            pondSpawnTimer.Tick += new EventHandler(SpawnPond);
            pondSpawnTimer.Start();
        }

        private void musicBtnClick(object sender, EventArgs e)
        {
            if (isMusicActive)
            {
                musicBtn.Image = Properties.Resources.musicOff;
                StopMusic();
                isMusicActive = false;
            } else
            {
                musicBtn.Image = Properties.Resources.musicOn;
                StartMusic();
                isMusicActive = true;
            }
            
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
