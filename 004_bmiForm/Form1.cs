using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmiForm
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txt_H.Text) / 100;
            double w = double.Parse(txtW.Text);

            double bmi = w / (h * h);

            lbbmi.Text = "BMI = " + bmi;
        }
    }
}
