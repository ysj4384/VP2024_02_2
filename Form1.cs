using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sensormonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_SensorMoniter
{
    public partial class Form1 : Form
    {
        SerialPort sPort = null;
        private double xCount = 200;
        // List<SensorData> myData = new List<SensorData>();

        // 시뮬레이션용
        Timer t = new Timer();
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();

            foreach (var ports in SerialPort.GetPortNames())
                comboBox1.Items.Add(ports);
            comboBox1.Text = "Select Port";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1023;

            InitSetting();
            ChartsSetting();
        }

        private void ChartsSetting()
        {
            chart1.Titles.Add("조도");
            chart2.Titles.Add("온도/습도");

            chart1.Series.Clear();
            chart1.Series.Add("Lumi");
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = xCount;
            chart1.ChartAreas[0].AxisX.Interval = xCount / 4;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 800;
            chart1.ChartAreas[0].AxisY.Interval = 200;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].BackColor = Color.Black;

            chart2.Series.Clear();
            chart2.Series.Add("Temp");
            chart2.Series.Add("Humi");

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = xCount;
            chart2.ChartAreas[0].AxisX.Interval = xCount / 4;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisY.Interval = 20;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart2.ChartAreas[0].BackColor = Color.Black;

            // Series 디자인

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;

            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.LightBlue;
            chart2.Series[0].BorderWidth = 2;

            chart2.Series[1].ChartType = SeriesChartType.Line;
            chart2.Series[1].Color = Color.Orange;
            chart2.Series[1].BorderWidth = 2;


        }

        private void InitSetting()
        {
            btnPortValue.BackColor = Color.Blue;
            btnPortValue.ForeColor = Color.White;
            btnPortValue.Text = "";
            btnPortValue.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

            lblConnectionTime.Text = "Connection Time : ";
            txtCount.TextAlign = HorizontalAlignment.Center;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            // 시뮬레이션
            int value = r.Next(1024);
            int temp = r.Next(35);
            int humi = r.Next(30, 90);

            string s = string.Format("{0} {1} {2}", temp, humi, value);
            ShowValue(s);
        }
        static int counter = 0;
        static int skip = 0;
        private void ShowValue(string s)
        {
            // 시뮬레이션
            counter++;
            listBox1.Items.Add(s);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  // 커서가 쫒아감

            if (++skip < 3) //통신된 데이터 3개를 무시한다.
                return;
            else
                skip = 3;

            string[] sub = new string[3];
            sub = s.Split('\t');

            int lumi = 0;   // 조도
            double temp = 0;   // 온도
            double humi = 0;   // 습도

            temp = double.Parse(sub[0]);
            humi = double.Parse(sub[1]);
            lumi = int.Parse(sub[2]);


            progressBar1.Value = lumi;
            chart1.Series[0].Points.Add(lumi);
            chart2.Series[0].Points.Add(temp);
            chart2.Series[1].Points.Add(humi);

            // 차트에 스크롤 기능 추가
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = (counter >= xCount) ? counter : xCount;

            if (counter > xCount)
            {
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xCount, counter);
                chart2.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xCount, counter);
            }

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = (counter >= xCount) ? counter : xCount;
        }

        private void 끝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sPort != null)   // sPort가 이미 설정되었다면?
                return;
            ComboBox cb = sender as ComboBox;   // (Combobox)sender
            sPort = new SerialPort(cb.SelectedItem.ToString());
            sPort.Open();
            sPort.DataReceived += SPort_DataReceived;

            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;
        }

        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = sPort.ReadLine();
            this.BeginInvoke(new Action(() => { ShowValue(s); }));
        }
    }
}
