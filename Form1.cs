using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool Player1 = true;

        public Form1()
        {
            InitializeComponent();
            
        }
        private string GetLabelValue()
        {
            string labelTxt = "X";
            if (!Player1)
            {
                labelTxt = "O";
            }

            Player1 = !Player1;
            return labelTxt;
        }

        private bool IsPairCompleted(string text)
        {
            bool completed = false;
            if (button1.Text == text && button2.Text == text && button3.Text == text)
            {
                completed = true;
            }
            else if (button1.Text == text && button4.Text == text && button7.Text == text)
            {
                completed = true;
            }
            else if (button1.Text == text && button5.Text == text && button9.Text == text)
            {
                completed = true;
            }
            else if (button2.Text == text && button5.Text == text && button8.Text == text)
            {
                completed = true;
            }
            else if (button3.Text == text && button6.Text == text && button9.Text == text)
            {
                completed = true;
            }
            else if (button3.Text == text && button5.Text == text && button7.Text == text)
            {
                completed = true;
            }
            else if (button4.Text == text && button5.Text == text && button6.Text == text)
            {
                completed = true;
            }
            else if (button7.Text == text && button8.Text == text && button9.Text == text)
            {
                completed = true;
            }

            if (completed)
            {
                foreach (Control c in panelGameMode.Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = b.Name != "NewGame_btn" ? false : true;
                    }
                }

                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\clap.wav");
                simpleSound.Play();

                MessageBox.Show(text + " is won", "Game Over!");
            }
            else if (!button1.Enabled && !button2.Enabled && !button3.Enabled
                && !button4.Enabled && !button5.Enabled && !button6.Enabled
                && !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\game_over.wav");
                simpleSound.Play();

                MessageBox.Show("Game Draw!", "Game Over!");
            }
            return completed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelGameMode.Visible = true;
            panelAbout.Visible = false;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            panelActive.Height = buttonPlay.Height;
            panelActive.Top = buttonPlay.Top;

            panelGameMode.Visible = true;
            panelAbout.Visible = false;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            panelActive.Height = buttonAbout.Height;
            panelActive.Top = buttonAbout.Top;

            panelGameMode.Visible = false;
            panelAbout.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            panelActive.Height = buttonClose.Height;
            panelActive.Top = buttonClose.Top;
            var result = MessageBox.Show("Do you want to exit game?", "Exit Game?",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Stop);

            bool exit = (result == DialogResult.Yes);
            if (exit)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button1.Text = GetLabelValue();
            button1.Enabled = false;
            IsPairCompleted(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button2.Text = GetLabelValue();
            button2.Enabled = false;
            IsPairCompleted(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button3.Text = GetLabelValue();
            button3.Enabled = false;
            IsPairCompleted(button3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button6.Text = GetLabelValue();
            button6.Enabled = false;
            IsPairCompleted(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button5.Text = GetLabelValue();
            button5.Enabled = false;
            IsPairCompleted(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button4.Text = GetLabelValue();
            button4.Enabled = false;
            IsPairCompleted(button4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button7.Text = GetLabelValue();
            button7.Enabled = false;
            IsPairCompleted(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button8.Text = GetLabelValue();
            button8.Enabled = false;
            IsPairCompleted(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            button9.Text = GetLabelValue();
            button9.Enabled = false;
            IsPairCompleted(button9.Text);
        }

        private void NewGame_btn_Click(object sender, EventArgs e)
        {
            PlayBtnPressSound();
            var result = MessageBox.Show("Do you want to start new game?", "New Game",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            bool reset = (result == DialogResult.Yes);
            if (reset)
            {
                Player1 = true;
                foreach (Control c in panelGameMode.Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Text = b.Name != "NewGame_btn" ? string.Empty : b.Text;
                        b.Enabled = true;
                    }
                }
            }
        }

        private void PlayBtnPressSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\button.wav");
            simpleSound.Play();
        }
    }
}
