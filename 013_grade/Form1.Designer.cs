namespace _013_grade
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbkor = new System.Windows.Forms.TextBox();
            this.txbmath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbeng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbsum = new System.Windows.Forms.TextBox();
            this.txbavg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbeng);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbmath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbkor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(197, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력란";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbavg);
            this.groupBox2.Controls.Add(this.txbsum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(283, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // txbkor
            // 
            this.txbkor.Location = new System.Drawing.Point(75, 42);
            this.txbkor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbkor.Name = "txbkor";
            this.txbkor.Size = new System.Drawing.Size(100, 23);
            this.txbkor.TabIndex = 1;
            // 
            // txbmath
            // 
            this.txbmath.Location = new System.Drawing.Point(75, 119);
            this.txbmath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbmath.Name = "txbmath";
            this.txbmath.Size = new System.Drawing.Size(100, 23);
            this.txbmath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "수학";
            // 
            // txbeng
            // 
            this.txbeng.Location = new System.Drawing.Point(75, 195);
            this.txbeng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbeng.Name = "txbeng";
            this.txbeng.Size = new System.Drawing.Size(100, 23);
            this.txbeng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "영어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "평균";
            // 
            // txbsum
            // 
            this.txbsum.BackColor = System.Drawing.SystemColors.Control;
            this.txbsum.Location = new System.Drawing.Point(72, 34);
            this.txbsum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbsum.Name = "txbsum";
            this.txbsum.Size = new System.Drawing.Size(100, 23);
            this.txbsum.TabIndex = 2;
            // 
            // txbavg
            // 
            this.txbavg.BackColor = System.Drawing.SystemColors.Control;
            this.txbavg.Location = new System.Drawing.Point(72, 80);
            this.txbavg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbavg.Name = "txbavg";
            this.txbavg.Size = new System.Drawing.Size(100, 23);
            this.txbavg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbeng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbmath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbsum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbavg;
    }
}

