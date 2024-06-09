using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 역설계
{
    public partial class Form3 : Form
    {
        IFirebaseConfig cf = new FirebaseConfig
        {
            AuthSecret = "ZEpcMdLJsITyck2aswguegmFcxuxqq0pLySo3rCk",
            BasePath = "https://sleep-4b82b-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private async void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(cf);
            FirebaseResponse response = await client.GetAsync("sleepstate");
            var data = response.ResultAs<Dictionary<string, object>>();

            if (data != null)
            {
                foreach (var item in data)
                {
                    comboBox1.Items.Add(item.Key); // 필드 이름을 추가합니다. 
                }
            }
        }
    

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("sleepstate/" + comboBox1.SelectedItem);

            data obj = res.ResultAs<data>();
            textBox1.Text = obj.heartstate;
            textBox2.Text = obj.movingstate;
            textBox3.Text = obj.spstate;
        }
    }
}
