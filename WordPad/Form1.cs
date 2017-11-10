using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {

        Button[,] buttons;
        List<int> values = new List<int>();
        int currentStep = -1;
        int sizeSqr = 5;
        public Form1()
        {
            InitializeComponent();
            Time.Text = TrackTime.Value.ToString();
            sizeSqr = (int)SizeSpin.Value;
            SizeSpin_ValueChanged(null, null);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
        
            Reset();
            Start.Text = "Start";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Click -= Start_Click;
            Start.Click += Stop_Click;
            Start.Text = "Stop";
            Restart.Visible = true;
            Random rand = new Random();
            
            buttons = new Button[sizeSqr, sizeSqr];
            Box.Controls.Clear();

            int koef = 290 / sizeSqr;
            for (int i = 0; i < sizeSqr; i++)
            {
                for (int j = 0; j < sizeSqr; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(koef * i, koef * j);
                    buttons[i, j].Size = new Size(koef, koef);
                    buttons[i, j].TabIndex = 10;
                    buttons[i, j].UseVisualStyleBackColor = true;
                    buttons[i, j].Click += PlayButton_Click;

                    int min = (int)Min.Value;
                    int max = (int)Max.Value;
                    int res = rand.Next(min,max);
                    while(values.IndexOf(res) != -1)
                        res = rand.Next(min,max);
                    
                    values.Add(res);

                    buttons[i, j].Text = res.ToString();
                    buttons[i, j].Visible = true;

                    Box.Controls.Add(buttons[i, j]);
                }
            }
            values.Sort();
            TimerProgress.Start();
            ControlsParam.Enabled = false;
            Progress.Maximum = (int)TrackTime.Value;

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            ControlsParam.Enabled = false;
            Button clickable = sender as Button;
            int value = int.Parse(clickable.Text);
            if (currentStep != -1)
            {
                if(value != values[currentStep])
                {
                    Reset();
                    MessageBox.Show("Вы проиграли!");
                }
                else
                {
                    currentStep++;
                    
                    clickable.Visible = false;
                    if (currentStep == values.Count)
                    {
                        Reset();
                        MessageBox.Show("Вы победили!");
                    }
                }
                
            }
            else if (currentStep == -1)
            {
                if (values[0] != value)
                {
                    Reset();
                    MessageBox.Show("Вы проиграли!");
                }
                else
                {
                    currentStep = 1;
                    clickable.Visible = false;
                }
            }
            
        }

        private void Reset()
        {
            currentStep = -1;
            values.Clear();
            Progress.Value = 0;
            for (int i = 0; i < sizeSqr; i++)
            {
                for (int j = 0; j < sizeSqr; j++)
                {
                    buttons[i, j].Visible = false;
                }
            }
            ControlsParam.Enabled = true;
            Start.Enabled = true;
            TimerProgress.Stop();
            Start.Click += Start_Click;
            Start.Click -= Stop_Click;
            Start.Text = "Start";
            Restart.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Progress.Increment(1);
            if (Progress.Value == Progress.Maximum)
            {
                TimerProgress.Stop();
                MessageBox.Show("Время вышло!");
                Reset();
            }
        }

        

        private void Min_ValueChanged(object sender, EventArgs e)
        {
            if(Max.Value - Min.Value < (sizeSqr * sizeSqr))
                 Max.Value = Min.Value + sizeSqr * sizeSqr;
        }

        private void Max_ValueChanged(object sender, EventArgs e)
        {
            if (Max.Value - Min.Value < sizeSqr * sizeSqr)
                Min.Value = Max.Value - sizeSqr * sizeSqr;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Reset();
            Start_Click(null, null);
        }

        private void SizeSpin_ValueChanged(object sender, EventArgs e)
        {
            sizeSqr = (int)SizeSpin.Value;
            Max.Maximum = sizeSqr * 25;
            Max.Minimum = sizeSqr * sizeSqr;
            Min.Maximum = Max.Maximum - Max.Minimum;
            Max_ValueChanged(null, null);
            Min_ValueChanged(null, null);
            TrackTime.Minimum = ((sizeSqr - 1) * (sizeSqr - 1)) + 1;
            TrackTime.Maximum = (sizeSqr * sizeSqr) * 2;
            Time.Text = TrackTime.Value.ToString();
        }
    }
}
