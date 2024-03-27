using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbmi_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtbH.Text)/100;
            double w = double.Parse(txtbW.Text);

            double bmi = w / (h * h);

            //[ctrl] + KC : comment
            //[ctrl] + KU : uncomment
            //result.Text = "bmi =" + bmi;
            result.Text = string.Format("BMI = {0:F2}", bmi);

            if (bmi < 20)
            {
                lbl_result.Text = "저체중";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (bmi < 25)
            {
                lbl_result.Text = "정상체중";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi < 30)
            {
                lbl_result.Text = "경도비만";
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (bmi < 40)
            {
                lbl_result.Text = "비만";
                pictureBox1.BackColor = Color.Orange;
            }
            else
            {
                lbl_result.Text = "고도비만";
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}
