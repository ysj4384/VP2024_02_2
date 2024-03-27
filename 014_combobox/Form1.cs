using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_combobox
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()//생성자 함수(멤버함수)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txb1.Text = "인체의 구조와 기능I";
            txb2.Text = "일반수학I";
            txb3.Text = "영어";
            txb4.Text = "데이터 사이언스";
            txb5.Text = "비주얼프로그래밍";
            txb6.Text = "디지털기술입문";
            txb7.Text = "전기전자공학및실험";
            txb8.Text = "설계";

            //학점 콤보박스 배열
            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8 };
            //성적 콤보박스 배열
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7, grd8 };
            //교과목 텍스트박스 배열
            titles = new TextBox[] { txb1, txb2, txb3, txb4, txb5, txb6, txb7, txb8 };

            //학점을 콤보박스에 표시하기위한 배열
            int[] arr = { 1, 2, 3, 4, 5 };

            //성적을 콤보박스에 표시하기위한 리스트
            List<String> list = new List<string> { "A+", "A", "B+", "B", "C+","C", "D+", "D", "F"};

            /*학점 콤보박스 배열 crds의 각 요소에 대해 arr의 각 요소를 Items로 등록하고
             최로에 3을 selectedltem으로 지정.*/
            foreach(var combo in crds)
            {
                foreach(var i in arr)
                    combo.Items.Add(i);
                combo.SelectedItem = 3;

                foreach(var cb in grds)
                    foreach(var gr in list)
                        cb.Items.Add(gr);
            }
        }

        private void btcrd_Click(object sender, EventArgs e)
        {
            double totalscore = 0;
            int totalcredit = 0;

            for (int i = 0; i<10/*crds.Length*/; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalcredit += crd;
                    totalscore += crd * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            txbgrade.Text = (totalscore / totalcredit).ToString("0.00");
        }

        private double GetGrade(string v)
        {
            double grade = 0;

            if (v == "A+") grade = 4.5;
            else if (v == "A") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D") grade = 1.0;
            else grade = 0.0;

            return grade;
        }
    }
}
