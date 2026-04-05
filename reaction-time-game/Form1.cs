using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech.Synthesis; 

namespace reaction_time_game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int waitTime;
        int reactionTime;
        bool gameRunning = false;
        bool canClick = false;
        int bestScore = int.MaxValue;
        Stopwatch stopwatch = new Stopwatch();

        
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public static class Statistiky
        {
            
            public static List<int> SeznamSkore = new List<int>();
        }

        public Form1()
        {
            InitializeComponent();

            
            
            pnlGame.BackColor = Color.Red;
            lblInfo.Text = "Klikni na Start";
            pnlGame.Click += pnlGame_Click;

            
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; 
            synth.SpeakCompleted += Synth_SpeakCompleted; 
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Shift && e.KeyCode == Keys.D)
            {
               
                synth.SpeakAsyncCancelAll();
                synth.SpeakAsync("System 32 bude smazán za 3. 2. 1.");
            }
        }

        
        private void Synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
           
            FormBSOD fakeDeath = new FormBSOD();
            fakeDeath.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblInfo.Text = "Čekej na zelenou...";
            pnlGame.BackColor = Color.Red;
            waitTime = random.Next(1000, 5000);
            canClick = false;
            gameRunning = true;
            timerWait.Interval = waitTime;
            timerWait.Start();
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            timerWait.Stop();
            pnlGame.BackColor = Color.Green;
            canClick = true;
            stopwatch.Restart();
            lblInfo.Text = "KLIKNI!";
        }

        private void pnlGame_Click(object sender, EventArgs e)
        {
            if (!gameRunning)
                return;

            timerWait.Stop();

            if (!canClick)
            {

                stopwatch.Stop();
                reactionTime = (int)stopwatch.ElapsedMilliseconds;
                Statistiky.SeznamSkore.Add(reactionTime);

                MessageBox.Show("Příliš brzo!");
                lblInfo.Text = "Klikni na Start";
                gameRunning = false;
                return;
            }

            stopwatch.Stop();
            reactionTime = (int)stopwatch.ElapsedMilliseconds;
            lblResult.Text = reactionTime + " ms";

            if (reactionTime < 250)
            {
                lblInfo.Text = "Rychlost: Výborná!";
                lblInfo.ForeColor = Color.Green;
            }
            else if (reactionTime < 350)
            {
                lblInfo.Text = "Rychlost: Dobrá!";
                lblInfo.ForeColor = Color.Orange;
            }
            else
            {
                lblInfo.Text = "Rychlost: Pomalejší";
                lblInfo.ForeColor = Color.Red;
            }
                    
            canClick = false;
            gameRunning = false;
        }

        

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pnlGame.BackColor = Color.Red;
            lblInfo.Text = "Klikni na Start";
            lblResult.Text = "";
            gameRunning = false;
            canClick = false;
            timerWait.Stop();
            reactionTime = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlGame.Cursor = Cursors.Hand;
        }

        

        private void ShowBestScore()
        {
            if (bestScore == int.MaxValue)
            {
                lblResult.Text = "Žádné skóre";
                return;
            }
            lblResult.Text = "Nejlepší: " + bestScore + " ms";
        }

        private void btnShowBest_Click(object sender, EventArgs e)
        {
            ShowBestScore();
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
            if (pictureBox1.Visible)
            {
                buttonDog.Text = "-_-";
            }
            else
            {
                buttonDog.Text = "POZOR!";
            }
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            FormHint fakeHints = new FormHint();
            fakeHints.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}