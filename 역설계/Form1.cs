using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 역설계
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 착용 위치" +
                    "\n   밴드 형태의 기기를 손목에 착용하고 집게 형태의 기기를 검지 손가락에 착용한다.\n" +
                    "\n2. 시작 방법" +
                    "\n   ① '시작하기' 버튼을 누른다." +
                    "\n   ② '측정 시작' 버튼을 선택한다" +
                    "\n   ③ 기기를 착용한후 연결된 포트를 선택하면 측정이 시작된다." +
                    "\n   ④ 측정을 멈추고 싶다면 기상버튼을 누른다.\n" +
                    "\n3. 결과 확인" +
                    "\n   차트가 보이는 창에서 각 버튼을 클릭하면 수면 상태와 해결책을 확인 할 수있다..", "사용 방법", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
