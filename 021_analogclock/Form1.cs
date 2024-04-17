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

        const int clientsize = 400; //클라이언트으 ㅣ사이즈
        const int clocksize = 300; //시계의 사이즈

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
                clientsize / 2 - clocksize / 2,
                clientsize / 2 - clocksize / 2 + menuStrip1.Height);
            panelCenter.X = panel1.Width / 2;
            panelCenter.Y = panel1.Height / 2;

            g = panel1.CreateGraphics(); //패널1에서 무언가를 그려주는 객체

            aClockSetting();
            dClockSetting();
            timerSetting();
        }

        private void dClockSetting()
        {
            dfont = new Font("맑은 고딕", 12, FontStyle.Bold);
            tfont = new Font("맑은 고딕", 32,
                FontStyle.Bold | FontStyle.Italic);
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
            DateTime c = DateTime.Now;
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

                g.DrawString(date, dfont, bDate, new Point(70, 110));
                g.DrawString(time, tfont, bTime, new Point(30, 130));
            }
        }
        private void DrawClockFace()
        {
            const int penWidth = 30;

            Pen p = new Pen(Brushes.Orange, penWidth);
            g.DrawEllipse(p, penWidth / 2, penWidth / 2, clocksize - penWidth, clocksize - penWidth);

            //눈금그리기
            Pen lpen = new Pen(Brushes.Black, 10);
            for(int i = 0; i<360; i += 90)
            {
                int x1 = (int)(radius * 0.85 * Math.Sin(i * Math.PI / 180));
                int y1 = (int)(radius * 0.85 * Math.Cos(i * Math.PI / 180));
                int x2 = (int)(radius * 0.95 * Math.Sin(i * Math.PI / 180));
                int y2 = (int)(radius * 0.95 * Math.Cos(i * Math.PI / 180));
                g.DrawLine(lpen, panelCenter.X + x1, panelCenter.Y - y1, panelCenter.X + x2, panelCenter.Y - y2);
            }
            Pen spen = new Pen(Brushes.Gray, 6);
            for (int i = 0; i < 360; i += 30)
            {
                if (i % 90 == 0)
                {
                    continue;
                }
                int x1 = (int)(radius * 0.9 * Math.Sin(i * Math.PI / 180));
                int y1 = (int)(radius * 0.9 * Math.Cos(i * Math.PI / 180));
                int x2 = (int)(radius * 0.95 * Math.Sin(i * Math.PI / 180));
                int y2 = (int)(radius * 0.95 * Math.Cos(i * Math.PI / 180));
                g.DrawLine(spen, panelCenter.X + x1, panelCenter.Y - y1, panelCenter.X + x2, panelCenter.Y - y2);
            }
        }


        private void DrawHands(double radhr, double radmin, double radsec)
        {
            DrawLine(0, 0,
                (int)(hourhand * Math.Sin(radhr)),
                (int)(hourhand * Math.Cos(radhr)),
                Brushes.Red, 8);

            DrawLine(0, 0,
                (int)(minhand * Math.Sin(radmin)),
                (int)(minhand * Math.Cos(radmin)),
                Brushes.Yellow, 6);

            DrawLine(0, 0,
                (int)(sechand * Math.Sin(radsec)),
                (int)(sechand * Math.Cos(radsec)),
                Brushes.Blue, 4);

            //시계중앙
            int coresize = 16;
            Rectangle r = new Rectangle
                (panelCenter.X - coresize / 2, panelCenter.Y - coresize / 2,
                coresize, coresize);
            g.FillEllipse(Brushes.Gold, r);
            g.DrawEllipse(new Pen(Brushes.Green, 3), r);
        }

        private void DrawLine(int x1, int y1, int x2, int y2, Brush brush, int thick)
        {
            Pen p = new Pen(brush, thick);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(p, panelCenter.X + x1, panelCenter.Y + y1, panelCenter.X + x2, panelCenter.Y - y2);
        }

        private void aClockSetting()
        {
            center = new Point(clientsize / 2, clientsize / 2);
            radius = clocksize / 2;
            hourhand = (int)(radius * 0.45);
            minhand = (int)(radius * 0.65);
            sechand = (int)(radius * 0.7);
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = true;
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
