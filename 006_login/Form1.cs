using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txb_id.Text == "abcd" && txb_pass.Text == "1234")
            
                txb_result.Text = "로그인 성공";
            
            else
            
                txb_result.Text = "로그인 실패";
            
        }
    }
}
