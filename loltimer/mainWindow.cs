using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace loltimer
{
    public partial class mainWindow : Form
    {
        SoundPlayer sp;
        Timer timerBlue = new Timer();
        int timerBlueCounter = 300; //счётчик для таймера
        Timer timerRed = new Timer();
        int timerRedCounter = 300;
        Timer timerBlue2 = new Timer();
        int timerBlueCounter2 = 300;
        Timer timerRed2 = new Timer();
        int timerRedCounter2 = 300;
        Timer timerDrake = new Timer();
        int timerDrakeCounter = 360;
        Timer timerBaron = new Timer();
        int timerBaronCounter = 420;
 
        public mainWindow() //конструктор формы
        {
            TopMost = true;
            InitializeComponent();
            sp = new SoundPlayer();
            timerBlue.Interval = 1000; //интервал между срабатываниями 1000 миллисекунд
            timerBlue.Tick += new EventHandler(timerBlue_Tick); //подписываемся на события Tick
            timerRed.Interval = 1000;
            timerRed.Tick += new EventHandler(timerRed_Tick);
            timerBlue2.Interval = 1000; 
            timerBlue2.Tick += new EventHandler(timerBlue2_Tick);
            timerRed2.Interval = 1000;
            timerRed2.Tick += new EventHandler(timerRed2_Tick);
            timerDrake.Interval = 1000;
            timerDrake.Tick += new EventHandler(timerDrake_Tick);
            timerBaron.Interval = 1000;
            timerBaron.Tick += new EventHandler(timerBaron_Tick);
        }
        //this.buttonColorDialog.BackgroundImage = global::Drawings.Properties.Resources.Transparent;
        //обработчик события Tick
        void timerBlue_Tick(object sender, EventArgs e)
        {
            if (timerBlueCounter != 0)
            {
                this.buttonBlue.Text = (--timerBlueCounter).ToString();
                if (timerBlueCounter == 62)
                {
                    sp.Stream = Properties.Resources.ourblue1min;
                    sp.Play();
                }
                if (timerBlueCounter == 32)
                {
                    sp.Stream = Properties.Resources.ourblue30sec;
                    sp.Play();
                }
                if (timerBlueCounter == 2)
                {
                    sp.Stream = Properties.Resources.ourbluespawned;
                    sp.Play();
                }
            }
            else 
            { 
                timerBlue.Stop();
                timerBlueCounter = 300;
                buttonBlue.Text = "Blue";
            }
        }
        void timerRed_Tick(object sender, EventArgs e)
        {
            if (timerRedCounter != 0)
            {
                this.buttonRed.Text = (--timerRedCounter).ToString();
                if (timerRedCounter == 62)
                {
                    sp.Stream = Properties.Resources.ourred1min;
                    sp.Play();
                }
                if (timerRedCounter == 32)
                {
                    sp.Stream = Properties.Resources.oured30sec;
                    sp.Play();
                }
                if (timerRedCounter == 2)
                {
                    sp.Stream = Properties.Resources.ourredspawned;
                    sp.Play();
                }
            }
            else
            {
                timerRed.Stop();
                timerRedCounter = 300;
                buttonRed.Text = "Red";
            }
        }
        void timerBlue2_Tick(object sender, EventArgs e)
        {
            if (timerBlueCounter2 != 0)
            {
                this.buttonBlue2.Text = (--timerBlueCounter2).ToString();
                if (timerBlueCounter2 == 62)
                {
                    sp.Stream = Properties.Resources.theirblue1min;
                    sp.Play();
                }
                if (timerBlueCounter2 == 32)
                {
                    sp.Stream = Properties.Resources.theirblue30sec;
                    sp.Play();
                }
                if (timerBlueCounter2 == 2)
                {
                    sp.Stream = Properties.Resources.theirbluespawned;
                    sp.Play();
                }
            }
            else
            {
                timerBlue2.Stop();
                timerBlueCounter2 = 300;
                buttonBlue2.Text = "Blue";
            }
        }
        void timerRed2_Tick(object sender, EventArgs e)
        {
            if (timerRedCounter2 != 0)
            {
                this.buttonRed2.Text = (--timerRedCounter2).ToString();
                if (timerRedCounter2 == 62)
                {
                    sp.Stream = Properties.Resources.theirred1min;
                    sp.Play();
                }
                if (timerRedCounter2 == 32)
                {
                    sp.Stream = Properties.Resources.theirred30sec;
                    sp.Play();
                }
                if (timerRedCounter2 == 2)
                {
                    sp.Stream = Properties.Resources.theirredspawned;
                    sp.Play();
                }
            }
            else
            {
                timerRed2.Stop();
                timerRedCounter2 = 300;
                buttonRed2.Text = "Red";
            }
        }
        void timerDrake_Tick(object sender, EventArgs e)
        {
            if (timerDrakeCounter != 0)
            {
                this.buttonDrake.Text = (--timerDrakeCounter).ToString();
                if (timerDrakeCounter == 62)
                {
                    sp.Stream = Properties.Resources.darke1min;
                    sp.Play();
                }
                if (timerDrakeCounter == 32)
                {
                    sp.Stream = Properties.Resources.drake30sec;
                    sp.Play();
                }
                if (timerDrakeCounter == 2)
                {
                    sp.Stream = Properties.Resources.drakespawned;
                    sp.Play();
                }
            }
            else
            {
                timerDrake.Stop();
                timerDrakeCounter = 360;
                buttonDrake.Text = "Dragon";
            }
        }
        void timerBaron_Tick(object sender, EventArgs e)
        {
            if (timerBaronCounter != 0)
            {
                this.buttonBaron.Text = (--timerBaronCounter).ToString();
                if (timerBaronCounter == 62)
                {
                    sp.Stream = Properties.Resources.nashor1min;
                    sp.Play();
                }
                if (timerBaronCounter == 32)
                {
                    sp.Stream = Properties.Resources.nashor30sec;
                    sp.Play();
                }
                if (timerBaronCounter == 2)
                {
                    sp.Stream = Properties.Resources.nashorspawned;
                    sp.Play();
                }
            }
            else
            {
                timerBaron.Stop();
                timerBaronCounter = 420;
                buttonBaron.Text = "Baron";
            }
        }
        //старт таймеров с кнопок
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            timerBlue.Start();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            timerRed.Start();
        }
        public void buttonBlue2_Click(object sender, EventArgs e)
        {
            timerBlue2.Start();
        }

        private void buttonRed2_Click(object sender, EventArgs e)
        {
            timerRed2.Start();
        }
        private void buttonDrake_Click(object sender, EventArgs e)
        {
            timerDrake.Start();
        }
        private void buttonBaron_Click(object sender, EventArgs e)
        {
            timerBaron.Start();
        }
    }
}