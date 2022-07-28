using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bird_hunting_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Properties.Resources.cursor2);
            Cursor crsr = new Cursor(bmp.GetHicon());
            this.Cursor = crsr;
        }
        int bird_leftx,bird_lefty;
        int bird_rightx,bird_righty;
        int bird_right2x, bird_right2y;

        int time;
        int score = 0;
        int speed = 5;
        Random random = new Random();
        Image[] images =
        {
            Properties.Resources.bird_left_3,
            Properties.Resources.bird_left_4,
            Properties.Resources.bird_left_5,
            Properties.Resources.bird_right_3,
            Properties.Resources.bird_right_4,
            Properties.Resources.bird_right_5,
        };
        void bird()
        {
            bird_left.Image = images[random.Next(0, 3)];
            bird_right.Image = images[random.Next(3, 6)];
            bird_right2.Image = images[random.Next(3, 6)];
            bird_left.Location = new Point(random.Next(960, 1300), random.Next(50, 110));
            bird_right2.Location = new Point(random.Next(-200, -50), random.Next(30,50));
            bird_right.Location = new Point(random.Next(-200, -50), random.Next(140, 220));
           
            bird_leftx = bird_left.Location.X;
            bird_lefty = bird_left.Location.Y;
            bird_rightx = bird_right.Location.X;
            bird_righty = bird_right.Location.Y;
            bird_right2x = bird_right2.Location.X;
            bird_right2y = bird_right2.Location.Y;

        }
       
        private void bird_right_Click(object sender, EventArgs e)
        {
            Sound();
            bird_right.Image = Properties.Resources.explosion;
            score++;
            lblScore.Text = "Score: " + score.ToString();
            
        }

        private void bird_left_Click(object sender, EventArgs e)
        {
            Sound();
            bird_left.Image = Properties.Resources.explosion;
            score++;
            lblScore.Text = "Score: "+score.ToString();
        }

        private void bird_right2_Click(object sender, EventArgs e)
        {
            Sound();
            bird_right2.Image = Properties.Resources.explosion;
            score++;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            time--;
            lblTime.Text = "Time: " + time;

            if (time == 0)
            {
                timer1.Stop();
                timer2.Stop();
               DialogResult dialog = MessageBox.Show("Score: "+score.ToString()+"\n " +
                    "Do you want to play again?", "Time's up",MessageBoxButtons.RetryCancel);

                if (DialogResult.Retry == dialog)
                {
                    Start();
                }
                if (DialogResult.Cancel == dialog)
                {
                    Application.Exit();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            bird_leftx -= speed;
            bird_rightx += speed;
            bird_right2x += speed;
            bird_left.Location = new Point(bird_leftx, bird_lefty);
            bird_right.Location = new Point(bird_rightx, bird_righty);
            bird_right2.Location = new Point(bird_right2x, bird_right2y);

            if (bird_leftx<-55)
            {
                bird_left.Image = images[random.Next(0, 4)];
                bird_leftx = random.Next(900, 1200);
                bird_lefty = random.Next(80,110);               
            }

            if (bird_rightx >970)
            {
                bird_right.Image = images[random.Next(3, 6)];
                bird_rightx = random.Next(-200, -50);
                bird_righty = random.Next(140, 220);
                bird_right2y = 50;              
            }

            if (bird_right2x > 970)
            {
                bird_right2.Image = images[random.Next(3, 6)];
                bird_right2x = random.Next(-200, -50);
                bird_right2y = random.Next(30, 50);

            }

        }
      void  Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.shot_sound);
            sound.Play();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        void Start()
        {
            score = 0;
            time = 60;
            lblScore.Text = "Score: " + score.ToString();
            lblTime.Text = "Time: " + time.ToString();
            bird();

            timer1.Enabled = true;
            timer1.Interval = 20;
            timer2.Enabled = true;
            timer2.Interval = 1000;
        }
    }
}
