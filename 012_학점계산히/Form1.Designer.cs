namespace _012_학점계산히
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
            this.rbkorea = new System.Windows.Forms.RadioButton();
            this.rbchina = new System.Windows.Forms.RadioButton();
            this.rbjapan = new System.Windows.Forms.RadioButton();
            this.rbetc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbetc);
            this.groupBox1.Controls.Add(this.rbjapan);
            this.groupBox1.Controls.Add(this.rbchina);
            this.groupBox1.Controls.Add(this.rbkorea);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // rbkorea
            // 
            this.rbkorea.AutoSize = true;
            this.rbkorea.Location = new System.Drawing.Point(24, 33);
            this.rbkorea.Name = "rbkorea";
            this.rbkorea.Size = new System.Drawing.Size(71, 16);
            this.rbkorea.TabIndex = 0;
            this.rbkorea.TabStop = true;
            this.rbkorea.Text = "대한민국";
            this.rbkorea.UseVisualStyleBackColor = true;
            // 
            // rbchina
            // 
            this.rbchina.AutoSize = true;
            this.rbchina.Location = new System.Drawing.Point(24, 68);
            this.rbchina.Name = "rbchina";
            this.rbchina.Size = new System.Drawing.Size(47, 16);
            this.rbchina.TabIndex = 1;
            this.rbchina.TabStop = true;
            this.rbchina.Text = "중국";
            this.rbchina.UseVisualStyleBackColor = true;
            // 
            // rbjapan
            // 
            this.rbjapan.AutoSize = true;
            this.rbjapan.Location = new System.Drawing.Point(24, 103);
            this.rbjapan.Name = "rbjapan";
            this.rbjapan.Size = new System.Drawing.Size(47, 16);
            this.rbjapan.TabIndex = 2;
            this.rbjapan.TabStop = true;
            this.rbjapan.Text = "일본";
            this.rbjapan.UseVisualStyleBackColor = true;
            // 
            // rbetc
            // 
            this.rbetc.AutoSize = true;
            this.rbetc.Location = new System.Drawing.Point(24, 138);
            this.rbetc.Name = "rbetc";
            this.rbetc.Size = new System.Drawing.Size(79, 16);
            this.rbetc.TabIndex = 3;
            this.rbetc.TabStop = true;
            this.rbetc.Text = "그 외 국가";
            this.rbetc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfemale);
            this.groupBox2.Controls.Add(this.rbmale);
            this.groupBox2.Location = new System.Drawing.Point(268, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(37, 21);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(35, 16);
            this.rbmale.TabIndex = 0;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "남";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(118, 21);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(35, 16);
            this.rbfemale.TabIndex = 1;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "여";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbetc;
        private System.Windows.Forms.RadioButton rbjapan;
        private System.Windows.Forms.RadioButton rbchina;
        private System.Windows.Forms.RadioButton rbkorea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Button button1;
    }
}

