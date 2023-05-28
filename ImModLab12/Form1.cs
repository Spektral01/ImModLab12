using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImModLab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool startStopStatus = true;

        double[,] Q = {
            { -0.4, 0.3, 0.1 },
            { 0.4, -0.8, 0.4 },
            { 0.1, 0.4, -0.5 }
        };
        double[] probs = new double[3];
        string[] states = { "Clear", "Cloudy", "Overcast" };
        Random rnd = new Random();
        int T, amountN, state = 0;
        double dt, probability, t = 0;

        int countClear = 0, countCloud = 0, countOverc = 0;

        double[] freq = new double[3];

        int k = 0;

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            T = (int)edTime.Value;
            amountN = (int)edAmount.Value;
            countClear = 0;
            countCloud = 0;
            countOverc = 0;
            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k < amountN)
            {
                if (t < T)
                {
                    dt = Math.Log(rnd.NextDouble()) / Q[state, state];
                    t += dt;
                    switch (state + 1)
                    {
                        case 1:
                            countClear++;
                            clearDays.Text = countClear.ToString();
                            break;
                        case 2:
                            countCloud++;
                            cloudyDays.Text = countCloud.ToString();
                            break;
                        case 3:
                            countOverc++;
                            overcastDays.Text = countOverc.ToString();
                            break;
                    }

                    for (int i = 0; i < states.Length; i++)
                        if (i != state)
                            probs[i] = -Q[state, i] / Q[state, state];
                        else
                            probs[i] = 0;

                    probability = rnd.NextDouble();
                    for (int i = 0; i < 3; i++)
                    {
                        probability -= probs[i];
                        if (probability <= 0)
                        {
                            state = i;
                            break;
                        }
                    }
                    switch (state + 1)
                    {
                        case 1:
                            countClear++;
                            clearDays.Text = countClear.ToString();
                            break;
                        case 2:
                            countCloud++;
                            cloudyDays.Text = countCloud.ToString();
                            break;
                        case 3:
                            countOverc++;
                            overcastDays.Text = countOverc.ToString();
                            break;
                    }

                }
                else
                {
                    freq[state]++;
                    state = 0;
                    k++;
                    t = 0;

                    switch (state + 1)
                    {
                        case 1:
                            countClear++;
                            clearDays.Text = countClear.ToString();
                            break;
                        case 2:
                            countCloud++;
                            cloudyDays.Text = countCloud.ToString();
                            break;
                        case 3:
                            countOverc++;
                            overcastDays.Text = countOverc.ToString();
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    freq[i] = freq[i] / amountN;
                    switch (i)
                    {
                        case 0:
                            stDistClear.Text = freq[i].ToString();
                            break;
                        case 1:
                            stDistCloudy.Text = freq[i].ToString();
                            break;
                        case 2:
                            stDistOverc.Text = freq[i].ToString();
                            break;
                    }

                }
                timer1.Stop();
            }
        }
    }
}
