using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_학점계산히
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "국적 : ";

            if (rbkorea.Checked)
                result += "대한민국\n";
            else if (rbchina.Checked)
                result += "중국\n";
            else if (rbjapan.Checked)
                result += "일본\n";
            else if (rbetc.Checked)
                result += "그 외 국가\n";

            if (rbmale.Checked)
                result += "성별 : 남성";
            else if (rbfemale.Checked)
                result += "성별 : 여성";

            MessageBox.Show(result, "결과");
        }
    }
}
