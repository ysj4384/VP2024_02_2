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
using System.IO.Ports;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using Newtonsoft.Json.Linq;


namespace 역설계
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        Timer clocktimer = new Timer(); //현재시간 타이머
        Timer stoptimer = new Timer(); //측정시간 타이머
        Timer addtimer = new Timer(); // 전체 수면분의 비렘수면 비율을 구해서 프린트할 타이머
        Timer avgtimer = new Timer(); //1분동안의 평균값을 구하는 타이머
        TimeSpan elapsedTime = TimeSpan.Zero; //측정 시간을 구하기위한 timespan
        private DateTime starttime;

        int xcount = 4;

        int h; // 아두이노 값을 받기위한 변수
        int m;
        int o;

        int heartsum; //아두이노 값 합산을 위한 변수
        double movingsum;
        int O2sum;

        int heartavg; // 평균값을 내기위한 변수
        int movingavg;
        int O2avg;

        string aduino; //
        
        string now; //good night 버튼을 누를때 시간이 저장되는 문자열;

        //파이어베이스 주소 및 비밀번호
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZEpcMdLJsITyck2aswguegmFcxuxqq0pLySo3rCk",
            BasePath = "https://sleep-4b82b-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form2()
        {

            //타이머
            InitializeComponent();
            Initializeclocktiemr();
            Initializestoptiemr();
            //Initializeaduinotimer();
            Initializeavgtimer();
            Initializeaddtimer();

            chartsetting();
            client = new FireSharp.FirebaseClient(config);

            // 데이터베이스
            dt.Columns.Add("날짜");
            dt.Columns.Add("심박수");
            dt.Columns.Add("뒤척임");
            dt.Columns.Add("산소포화도");
        }

        double overh = 0;// 파이어 베이스에서 받아온 데이터가 40~85의 값의 범주를 넘을 경우에 1씩 넣을 변수
        double allsp = 0;
        double allmoving = 0;
        double allsleep = 0;// 전체 수면 시간을 구하기위한 변수
        int cnt2 = 1;
        double sleepstate1;
        double sleepstate2;

        private void Initializeaddtimer()//전체 수면분의 비렘수면 비율과 평균 산소포화도를 구해서 프린트할 타이머
        {
            addtimer.Enabled = false;
            addtimer.Interval = 60000;
            addtimer.Tick += A_Tick;
        }

        private async void A_Tick(object sender, EventArgs e)
        {
            string s = $"sleep/{cnt2}";
            FirebaseResponse response = await client.GetAsync(s);
            data obj = response.ResultAs<data>();

            int h = obj.heart; //아두이노에서 받은 심박수중 85 이하인 값을 더하는 코드
            if (h < 85)
            {
                overh++;
            }

            int o = obj.sleep_apena; //아두이노에서 받은 산소포화도로를 모두 더하는 코드
            allsp += o;

            double m = obj.moving; //뒤척임값을 모두 더하는 코드
            allmoving += m;


            allsleep++;
            sleepstate1 = overh / allsleep;
            sleepstate2 = allsp / allsleep; //수면중 평균 산소포화도

            cnt2++;
        }

        private void chartsetting() //기본 차트 세팅
        {
            chart1.Titles.Add("심박수 & 산소포화도 & 뒤척임");

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = xcount;
            chart1.ChartAreas[0].AxisX.Interval = xcount/xcount;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 150;
            chart1.ChartAreas[0].AxisY.Interval = 25;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.Series.Clear();
            chart1.Series.Add("심박수");
            chart1.Series.Add("산소포화도");
            chart1.Series.Add("뒤척임");
            chart1.Series.Add("최고 심박수");
            chart1.Series.Add("최저 심박수");
            chart1.Series.Add("최저 산소포화도");
            chart1.Series.Add("최고 뒤척임");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[2].Color = Color.Blue;
            chart1.Series[2].BorderWidth = 3;
            chart1.Series[3].ChartType = SeriesChartType.Line;
            chart1.Series[3].Color = Color.Red;
            chart1.Series[3].BorderWidth = 1;
            chart1.Series[4].ChartType = SeriesChartType.Line;
            chart1.Series[4].Color = Color.Black;
            chart1.Series[4].BorderWidth = 1;
            chart1.Series[5].ChartType = SeriesChartType.Line;
            chart1.Series[5].Color = Color.Red;
            chart1.Series[5].BorderWidth = 1;
            chart1.Series[6].ChartType = SeriesChartType.Line;
            chart1.Series[6].Color = Color.Red;
            chart1.Series[6].BorderWidth = 1;

            chart1.Series[3].Enabled = false;
            chart1.Series[4].Enabled = false;
            chart1.Series[5].Enabled = false;
            chart1.Series[6].Enabled = false;

        }

        private void Initializeavgtimer() //1분마다 파이어 베이스에서 값을 받는 타이머
        {
            avgtimer.Interval = 60000;
            avgtimer.Tick += avg_Tick;
            avgtimer.Enabled = false;
        }

        int cnt = 1;
        private async void avg_Tick(object sender, EventArgs e) // 평균값을 차트에 1분마다 띄우는 함수
        {
            string path = $"sleep/{cnt}";

            FirebaseResponse response = await client.GetAsync(path);
            data obj = response.ResultAs<data>();

            heartsum = obj.heart;
            movingsum = obj.moving;
            O2sum = obj.sleep_apena;

            int heartavg = heartsum;
            double movingavg = movingsum;
            int O2avg = O2sum;

            string aduino = string.Format("{0}\t{1}\t{2}", heartavg, O2avg, movingavg);
            chartvalue(aduino);

            cnt++;
        }
        static int counter = 0;
        private void chartvalue(string aduino) // 차트에 데이터를 추가하는 함수
        {
            counter++;

            string[] sub = new string[3];
            sub = aduino.Split('\t');

            int h = int.Parse(sub[0]);
            int o = int.Parse(sub[1]);
            int m = int.Parse(sub[2]);

            chart1.Series[0].Points.Add(h);
            chart1.Series[1].Points.Add(o);
            chart1.Series[2].Points.Add(m);
            chart1.Series[3].Points.Add(85);
            chart1.Series[4].Points.Add(40);
            chart1.Series[5].Points.Add(90);
            chart1.Series[6].Points.Add(40);

            chart1.ChartAreas[0].AxisX.Minimum = 0; //차트의 X축이 설정해둔 값보다 커질때 자동으로 증가하는 코드
            chart1.ChartAreas[0].AxisX.Maximum = (counter >= xcount) ? counter : xcount;

            if (counter > xcount)
            {
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xcount, counter);
            }

            string[] str = new string[1];
        }

        private void Initializestoptiemr() // 측정시간 타이머
        {
            stoptimer.Interval = 1000;
            stoptimer.Tick += s_Tick;
            stoptimer.Enabled = false;
        }

        private void s_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            label2.Text = "측정시간 : " + elapsedTime.ToString();
        }

        private void Initializeclocktiemr() // 현재시간 타이머
        {
            clocktimer.Interval = 1000;
            clocktimer.Tick += c_Tick;
            clocktimer.Start();
        }

        private void c_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;
            string time = string.Format("{0:D2} : {1:D2} : {2:D2}", c.Hour, c.Minute, c.Second);
            label1.Text = "현재 시간 : " + DateTime.Today.ToString("D") + " "+ time;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e) //심박수만 표시하는 버튼
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = false;
            chart1.Series[2].Enabled = false;
            chart1.Series[3].Enabled = true;
            chart1.Series[4].Enabled = true;
            chart1.Series[5].Enabled = false;
            chart1.Series[6].Enabled = false;


            string m = string.Format("전체 수면시간 : {0}시간, 비렘수면 시간 : {1}시간" +
                "\n비렘수면 비율 : {2:F1}% " +
                "\n\n비렘수면 비율이 75~80%를 차지하면 이상적인 수면이고," +
                "\n75% 미만일 경우 수면 장애일 가능성이 높다." +
                "\n\n※ 이렇게 해보세요!" +
                "\n\n① 낮잠을 피합니다." +
                "\n\n② 매일 규칙적인 운동을 합니다." +
                "\n\n③ 수면에 적절한 환경을 만듭니다." +
                "\n\n④ 잠들기 위해 지나치게 노력하기보다는 긴장을 풀고 편안한 느낌이 들도록 노력합니다.", allsleep, overh, sleepstate1 * 100);

            MessageBox.Show(m, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e) //산소포화도만 표시하는 버튼
        {
            chart1.Series[0].Enabled = false;
            chart1.Series[1].Enabled = true;
            chart1.Series[2].Enabled = false;
            chart1.Series[3].Enabled = false;
            chart1.Series[4].Enabled = false;
            chart1.Series[5].Enabled = true;
            chart1.Series[6].Enabled = false;

            string n = string.Format("전체 수면시간 : {0}시간, 평균 산소포화도 : {1}%" +
                "\n\n산소포화도가 90% 이하일 경우 수면 무호흡증을 가능성이 높습니다." +
                "\n\n※ 이렇게 해보세요!" +
                "\n\n① 적정 체중을 유지하세요!" +
                "\n   수면무호흡증 환자의 대부분이 기도 주변과 혀의 지방조직 증가로 기도가 좁아지는 이상 증상을 가지고 있으며, 이러한 증상은 비만해질수록 심하다. 또한, 비만은 폐 기능을 감소시켜 증상을 악화시킨다." +
                "\n\n② 술과 담배를 끊어라!" +
                "\n   알코올을 섭취하면 점막 부종으로 기도가 좁아지게 되며, 근육의 힘을 약화시키기 때문에 코골이와 수면무호흡증이 심해진다." +
                "\n\n③ 코막힘, 고혈압 질환을 치료하라!" +
                "\n   코골이와 수면무호흡증은 코막힘이 심할수록 심해지는 질환이다. 또한, 고혈압 환자의 30%가 수면무호흡증이 있고, 수면무호흡증 환자의 50%가 고혈압이 있어, 심뇌혈관질환 발생과 관련이 깊다."
                , allsleep, sleepstate2);

            MessageBox.Show(n, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button4_Click(object sender, EventArgs e) //움직임만 표시하는 버튼
        {
            chart1.Series[0].Enabled = false;
            chart1.Series[1].Enabled = false;
            chart1.Series[2].Enabled = true;
            chart1.Series[3].Enabled = false;
            chart1.Series[4].Enabled = false;
            chart1.Series[5].Enabled = false;
            chart1.Series[6].Enabled = true;

            string ms = string.Format("전체 수면 시간 : {0}시간, 수면 중 뒤척임 횟수 : {1}번" +
                "\n\n 수면 중 평균 20~40회의 뒤척임은 체온 조절이나 피로를 회복하여 숙면에 들게한다. " +
                "\n\n 그러나 그 이상의 뒤척임이 나타날때에는 렘수면 기간이 길다는 것은 의미한다." +
                "\n\n 또한, 렘수면행동장애, 수면 무호흡증 등의 증상이 의심되니 정밀 검사를 받는 것을 추천한다.", allsleep, allmoving);

            MessageBox.Show(ms, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button6_Click(object sender, EventArgs e) //모두 표시하는 버튼
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = true;
            chart1.Series[2].Enabled = true;
            chart1.Series[3].Enabled = false;
            chart1.Series[4].Enabled = false;
            chart1.Series[5].Enabled = false;
            chart1.Series[6].Enabled = false;

        }
        int deletecnt = 1;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Show();
        }
        string heartrate;
        string sprate;
        string movingrate;
        private async void button7_Click(object sender, EventArgs e) //버튼클릭시 데이터 베이스에 해당 날짜와 수면 상태가 업데이트 되고 세부 기록은 삭제되는 코드
        {

            if (sleepstate1>75)
            {
                heartrate = "이상 없음";
            }
            else
            {
                heartrate = "이상 있음";
            }

            if (sleepstate2<90)
            {
                sprate = "수면 무호흡증 의심";
            }
            else
            {
                sprate ="정상";
            }

            if (allmoving>40)
            {
                movingrate = "너무 많음";
            }
            else
            {
                movingrate = "적당함";
            }

            var data = new data
            {
                date = starttime.ToString("yyyy-MM-dd"),
                heartstate = heartrate,
                movingstate = movingrate,
                spstate = sprate,
                time = starttime.ToString("HH:mm")
            };
            SetResponse response = await client.SetAsync("sleepstate/" + starttime.ToString("yyyy-MM-dd HH:mm"), data);
            data result = response.ResultAs<data>(); //데이터 베이스에 수면 상태가 업데이트 되는 코드

            FirebaseResponse delete = await client.DeleteAsync("sleep");

            stoptimer.Enabled = false;
            avgtimer.Enabled = false;
            addtimer.Enabled = false;
        }

        int chartcnt = 0;
        private void chart1_Click(object sender, EventArgs e)
        {
            if (chartcnt % 2 == 0)
            {
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, counter);
            }
            else
            {
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(counter - xcount, counter);
            }
            chartcnt++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            starttime = DateTime.Now; //측정을 시작한 시간
            stoptimer.Enabled = true;
            avgtimer.Enabled = true;
            addtimer.Enabled = true;
        }
    }
}