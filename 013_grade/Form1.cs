using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double sum = double.Parse(txbkor.Text) + double.Parse(txbmath.Text) + double.Parse(txbeng.Text);
            double sum = Convert.ToDouble(txbkor.Text) + Convert.ToDouble(txbmath.Text) + Convert.ToDouble(txbeng.Text);

            double avg = sum / 3;

            txbsum.Text = sum.ToString();
            txbavg.Text = avg.ToString();
        }
    }
}
