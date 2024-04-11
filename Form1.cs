using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_analogclock
{
    public partial class Form1 : Form
    {
        // 필드(멤버변수)
        Graphics g;
        bool aClockFlag = true; //아날로그 시게로 시작할것.
        Point center;
        int radius;
        int hourhand; //시침의 길이
        int minhand; //분침의 길이
        int sechand; // 초침의 길이

        const int clientsize = 500; //클라이언트으 ㅣ사이즈
        const int clocksize = 400; //시계의 사이즈

        Font dfont;
        Font tfont;
        Brush bDate;
        Brush bTime;

        Point panelCenter;
        //생성자
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(clientsize, clientsize + menuStrip1.Height);
            this.Text = "My Form Clock";
            
            //panel 지정
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Width = clocksize + 1;
            panel1.Height = clocksize + 1;
            panel1.Location = new Point(
                clientsize/2 - clocksize/2,
                clientsize / 2 - clocksize / 2 + menuStrip1.Height);

            g = panel1.CreateGraphics(); //패널1에서 무언가를 그려주는 객체

            aClockSetting();
            dClockSetting();
            timerSetting();
        }

        private void dClockSetting()
        {
            dfont = new Font("맑은 고딕", 12, FontStyle.Bold);
            tfont = new Font("맑은 고딕", 32,
                FontStyle.Bold|FontStyle.Italic);
            bDate = Brushes.SkyBlue;
            bTime = Brushes.Blue;

        }

        private void timerSetting()
        {
            Timer t = new Timer();
            t.Enabled = true;
            t.Interval = 1000;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            DateTime c =DateTime.Now;
            panel1.Refresh();

            if (aClockFlag == true) // 아날로그 시계
            {
                DrawClockFace();

                double radhr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
                double radmin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
                double radsec = c.Second * 6 * Math.PI / 180;

                DrawHands(radhr, radmin, radsec);
            }
            else //디지털 시계
            {
                string date = DateTime.Today.ToString("D");
                string time = string.Format("{0:D2} : {1:D2} : {2:D2}", c.Hour, c.Minute, c.Second);

                g.DrawString(date, dfont, bDate, new Point(120, 130));
                g.DrawString(time, tfont, bTime, new Point(70, 150));
            }
        }
        private void DrawClockFace()
        {
            const int penWidth = 30;

            Pen p = new Pen(Brushes.OrangeRed, penWidth);
            g.DrawEllipse(p, penWidth/2, penWidth/2, clocksize - penWidth/2, clocksize - penWidth/2);
        }


        private void DrawHands(double radhr, double radmin, double radsec)
        {
            
        }

        private void aClockSetting()
        {
            center = new Point(clientsize / 2, clientsize / 2);
            radius = clocksize / 2;
            hourhand = (int)(radius * 0.45);
            minhand = (int)(radius * 0.65);
            sechand = (int)(radius * 0.7);
        }
    }
}
