using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AirHeatModel_Sim
{
    public partial class Form1 : Form
    {
        double Theta_t, Kh, Tenv, Delay, Ts, Tstop, Tout, ToutPlOne;
        //bool radA, radM;
        int count;

        int time = 0;
        double[] uk;

        PidController pi = new PidController();
        
        //double[] Tout, u1, u2, uk, t;

        public Form1()
        {
            InitializeComponent();
            radMan.Checked = true;

            //Model parameters
            Theta_t = 22;
            Kh = 3.5;
            Tenv = 21.5;
            Delay = 2/0.1;

            //Simulation Parameters
            Ts = 0.1;
            Tstop = 200;
            uk = new double[(int)(Tstop / Ts)];
            Tout = 20;

            //Pid controller Parameters
            pi.Ts = Ts;
            numSP.Value = 23;
            numKp.Value = 3;
            numTi.Value = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (uk[time]+20 == uk.Length)
            {
                timer1.Stop();
                MessageBox.Show("Runtime exceded, please restart application");
            }

            if (radAut.Checked)
            {
                radMan.Checked = false;
                try
                {
                    pi.Kp = Convert.ToDouble(numKp.Value);
                    pi.Ti = Convert.ToDouble(numTi.Value);
                    pi.r = Convert.ToDouble(numSP.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid number");
                    throw;
                }

                uk[time + Convert.ToInt32(Delay)] = pi.PiController(Tout);
            }
            else if (radMan.Checked)
            {
                radAut.Checked = false;
                uk[time + Convert.ToInt32(Delay)] = Convert.ToDouble(numUpDown.Value);
            }
            Run();
            time++;
        }

        public void Run()
        {
            ToutPlOne = Tout + (Ts / Theta_t) * (-Tout + Kh * uk[time] + Tenv);
            Tout = ToutPlOne;
            Plot(Tout, time);
            txtPV.Text = Tout.ToString();
        }

        private void Plot(double Tout, double t)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            chart1.Series["Temperature"].ChartType = SeriesChartType.Line;
            chart1.Series["Temperature"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Temperature"].BorderWidth = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 26;
            chart1.ChartAreas[0].AxisX.Maximum = 2000;
            chart1.Series["Temperature"].Points.AddXY(t, Tout);
            
        }


    }
}
