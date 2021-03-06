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
using NationalInstruments.NetworkVariable;

namespace AirHeatModel_Sim
{
    public partial class Form1 : Form
    {
        double Theta_t, Kh, Tenv, Delay, Ts, Tstop, Tout, ToutPlOne, ToutF;

        int time = 0;
        double[] uk;

        PidController pi = new PidController();
        Filter filter = new Filter();
        DateTime dateTime = new DateTime();

        private NetworkVariableWriter<double> _writer;
        private const string NetworkVariableLocation = @"\\localhost\OPC_SCADA\PV";
        private NetworkVariableWriter<double> _writer2;
        private const string NetworkVariableLocation2 = @"\\localhost\OPC_SCADA\MV";

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
            Tout = Tenv;
            numMV.Maximum = 5;

            //Pid controller Parameters
            pi.Ts = Ts;
            numSP.DecimalPlaces = 1;
            numSP.Value = new decimal((double)23.1);
            numKp.DecimalPlaces = 1;
            numKp.Value = new decimal((double)2.8);
            numTi.DecimalPlaces = 1;
            numTi.Maximum = 10000000;
            numTi.Value = new decimal((double)110.0);

            //Filter Parameters
            filter.Ts = Ts;
            filter.Tf = 0.5;
            filter.yk = Tenv;

            ConnectOPCServer();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _writer.Disconnect();
            _writer2.Disconnect();
        }


        private void ConnectOPCServer()
        {
            _writer = new NetworkVariableWriter<double>(NetworkVariableLocation);
            _writer.Connect();
            _writer2 = new NetworkVariableWriter<double>(NetworkVariableLocation2);
            _writer2.Connect();
            txtStatus.Text = _writer.ConnectionStatus.ToString();
        }

        private void radAut_Click(object sender, EventArgs e)
        {
            radMan.Checked = false;
        }

        private void radMan_Click(object sender, EventArgs e)
        {
            radAut.Checked = false;
        }

        private double LimitCheck(double uk)
        {
            double max = 5;
            double min = 0;
            if (uk > max)
            {
                return uk = max;
            }
            else if (uk < min)
            {
                return uk = min;
            }
            else
            {
                return uk;
            }
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
                uk[time + Convert.ToInt32(Delay)] = LimitCheck(pi.PiController(Tout));
            }
            else if (radMan.Checked)
            {
                uk[time + Convert.ToInt32(Delay)] = LimitCheck(Convert.ToDouble(numMV.Value));
            }
            Run();
            time++;
        }

        public void Run()
        {
            ToutPlOne = Tout + (Ts / Theta_t) * (-Tout + Kh * uk[time] + Tenv);
            ToutF= filter.LowPassFilter(Tout);
            dateTime = DateTime.Now;
            Plot(Tout, "Temperature Un-Filtered", chart1, 26, 20, dateTime);
            Plot(ToutF, "Temperature Filtered", chart1, 26, 20, dateTime);
            Plot(uk[time], "Control Signal", chart2, 5, 0, dateTime);
            txtPV.Text = Tout.ToString("N1");
            txtMV.Text = uk[time].ToString("N1");
            try
            {
                _writer.WriteValue(Tout);
                _writer2.WriteValue(uk[time]);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The read has timed out.", "Timeout");
                return;
            }
            Tout = ToutPlOne;
        }

        //private int GridlinesOffset = 0;
        private void Plot(double data, string chartN, Chart chart, int max, int min, DateTime dateTime)
        {
            //InitChart(chart1);
            chart.Series[chartN].ChartType = SeriesChartType.Line;
            chart.ResetAutoValues();
            //chart1.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -GridlinesOffset; //https://stackoverflow.com/questions/31667086/how-to-move-x-axis-grids-on-chart-whenever-a-data-is-added-on-the-chart
            //GridlinesOffset++;
            //GridlinesOffset %= (int)chart1.ChartAreas[0].AxisX.MajorGrid.Interval; //Moving chart, calculating next offset
            chart.Series[chartN].BorderWidth = 2;
            chart.ChartAreas[0].AxisY.Minimum = min;
            chart.ChartAreas[0].AxisY.Maximum = max;
            chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart.Series[chartN].Points.AddXY(dateTime, data);
        }
    }
}
