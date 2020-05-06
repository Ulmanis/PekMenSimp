using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PekMenSimp
{
    public partial class Igra : Form
    {
        private int heroStep = 5;
        int verVelocity = 0;
        int horVelocity = 0;
        int enemyStep = 3;
        int horEnemyVelocity = 0;
        int verEnemyVelocity = 0;

        int heroImageCount = 1;
        int enemyImageCount = 1;
        int score = 0;

        string heroDirection = "right";
        string enemyDirection = "left";
        Random Rand = new Random();
        bool gamePaused = false;

        public Igra()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            this.BackColor = Color.Blue;
            Hero.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;
            Hero.Width = 50;
            Hero.Height = 50;
            Food.BackColor = Color.Transparent;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = Properties.Resources.food_1;
            RandomizeFood();
            Enemy.BackColor = Color.Transparent;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.Height = 40;
            Enemy.Width = 40;
            //set up interface
            UpdateScoreLabel();
            //starging timers
            TimerMove.Start();
            TimerAnimate.Start();

            RandomChangeEnemyDirection();
        }

        private void HeroFoodCollision()
        {
            if (Hero.Bounds.IntersectsWith(Food.Bounds))
            {
                score += 100;
                UpdateScoreLabel();
                RandomizeFood();
            }
        }

        private void RandomizeFood()
        {
            Food.Left = Rand.Next(0, ClientRectangle.Width - Food.Width);
            Food.Top = Rand.Next(0, ClientRectangle.Height - Food.Height);
        }

        private void UpdateScoreLabel()
        {
            ScoreLabel.Text = "Score: " + score;
        }

        private void HeroBorderCollision()
        {
            if (Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
            }
            else if (Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
            }
            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
            }
            else if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
            }
        }



        private void Igra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                verVelocity = -heroStep;
                horVelocity = 0;
                heroDirection = "up";
            }
            else if (e.KeyCode == Keys.S)
            {
                verVelocity = heroStep;
                horVelocity = 0;
                heroDirection = "down";
            }
            else if (e.KeyCode == Keys.A)
            {
                verVelocity = 0;
                horVelocity = -heroStep;
                heroDirection = "left";
            }
            else if (e.KeyCode == Keys.D)
            {
                verVelocity = 0;
                horVelocity = heroStep;
                heroDirection = "right";
            }
            else if (e.KeyCode == Keys.P)
            {
                if (!gamePaused)
                {
                    TimerAnimate.Stop();
                    TimerMove.Stop();
                    gamePaused = true;
                }
                else
                {
                    TimerAnimate.Start();
                    TimerMove.Start();
                    gamePaused = false;
                }
            }
            RandomChangeEnemyDirection();

        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            HeroMove();
            EnemyMove();
        }

        private void HeroMove()
        {
            Hero.Top += verVelocity;
            Hero.Left += horVelocity;
            HeroBorderCollision();
            HeroFoodCollision();
            HeroEnemyCollision();
        }

        private void EnemyMove()
        {
            Enemy.Top += verEnemyVelocity;
            Enemy.Left += horEnemyVelocity;
            EnemyBorderCollision();
        }

        private void TimerAnimate_Tick(object sender, EventArgs e)
        {
            HeroAnimate();
            EnemyAnimate();
        }

        private void HeroAnimate()
        {
            string heroImageName;
            heroImageName = "pacman_" + heroDirection + "_" + heroImageCount;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImageCount += 1;
            if (heroImageCount > 4)
            {
                heroImageCount = 1;
            }
        }

        private void EnemyAnimate()
        {
            string enemyImageName;
            enemyImageName = "enemy_" + enemyDirection + "_" + enemyImageCount;
            Enemy.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyImageName);
            enemyImageCount += 1;
            if (enemyImageCount > 2)
            {
                enemyImageCount = 1;
            }
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void RandomChangeEnemyDirection()
        {
            int directionCode = Rand.Next(1, 5);
            if(directionCode == 1)
            {
                enemyDirection = "right";
                verEnemyVelocity = 0;
                horEnemyVelocity = enemyStep;
            }
            else if(directionCode == 2)
            {
                enemyDirection = "down";
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
            }
            else if (directionCode == 3)
            {
                enemyDirection = "left";
                verEnemyVelocity = 0;
                horEnemyVelocity = -enemyStep;
            }
            else if (directionCode == 4)
            {
                enemyDirection = "up";
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
            }
        }
        private void EnemyBorderCollision()
        {
            if (Enemy.Top < 0)
            {
                enemyDirection = "down";
                verEnemyVelocity *= -1;
                horEnemyVelocity *= -1;
            }
            else if (Enemy.Top + Enemy.Height > ClientRectangle.Height)
            {
                enemyDirection = "up";
                verEnemyVelocity *= -1;
                horEnemyVelocity *= -1;
            }
            if (Enemy.Left < 0)
            {
                enemyDirection = "right";
                verEnemyVelocity *= -1;
                horEnemyVelocity *= -1;
            }
            else if (Enemy.Left + Enemy.Width > ClientRectangle.Width)
            {
                enemyDirection = "left";
                verEnemyVelocity *= -1;
                horEnemyVelocity *= -1;
            }
        }

        private void HeroEnemyCollision()
        {
            if (Hero.Bounds.IntersectsWith(Enemy.Bounds))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            TimerAnimate.Stop();
            TimerMove.Stop();
            heroImageCount = 0;
            TimerHeroMelt.Start();
        }

        private void TimerHeroMelt_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImageName = "pacman_melt_" + heroImageCount;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImageCount += 1;
            if (heroImageCount > 14)
            {
                TimerHeroMelt.Stop();
                LabelGameOver.Visible = true;
            }
        }

        private Button newButton;

        private void AddNewButton()
        {
            newButton = new Button();
            newButton.Width = 20;
            newButton.Height = 40;
            newButton.Click += new EventHandler(ButtonResetClick);
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {

        }

    }
}