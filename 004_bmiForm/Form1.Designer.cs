namespace _004_bmiForm
{
    partial class form
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
            this.txt_H = new System.Windows.Forms.TextBox();
            this.lbh = new System.Windows.Forms.Label();
            this.lbw = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lbbmi = new System.Windows.Forms.Label();
            this.btnbmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_H
            // 
            this.txt_H.Location = new System.Drawing.Point(103, 40);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(100, 21);
            this.txt_H.TabIndex = 0;
            // 
            // lbh
            // 
            this.lbh.AutoSize = true;
            this.lbh.Location = new System.Drawing.Point(22, 43);
            this.lbh.Name = "lbh";
            this.lbh.Size = new System.Drawing.Size(45, 12);
            this.lbh.TabIndex = 1;
            this.lbh.Text = "키(cm)";
            // 
            // lbw
            // 
            this.lbw.AutoSize = true;
            this.lbw.Location = new System.Drawing.Point(22, 79);
            this.lbw.Name = "lbw";
            this.lbw.Size = new System.Drawing.Size(52, 12);
            this.lbw.TabIndex = 3;
            this.lbw.Text = "체중(kg)";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(103, 76);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 21);
            this.txtW.TabIndex = 2;
            this.txtW.TextChanged += new System.EventHandler(this.txtW_TextChanged);
            // 
            // lbbmi
            // 
            this.lbbmi.AutoSize = true;
            this.lbbmi.Location = new System.Drawing.Point(22, 181);
            this.lbbmi.Name = "lbbmi";
            this.lbbmi.Size = new System.Drawing.Size(37, 12);
            this.lbbmi.TabIndex = 5;
            this.lbbmi.Text = "BMI =";
            // 
            // btnbmi
            // 
            this.btnbmi.Location = new System.Drawing.Point(103, 121);
            this.btnbmi.Name = "btnbmi";
            this.btnbmi.Size = new System.Drawing.Size(100, 23);
            this.btnbmi.TabIndex = 7;
            this.btnbmi.Text = "BMI";
            this.btnbmi.UseVisualStyleBackColor = true;
            this.btnbmi.Click += new System.EventHandler(this.button2_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(369, 331);
            this.Controls.Add(this.btnbmi);
            this.Controls.Add(this.lbbmi);
            this.Controls.Add(this.lbw);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lbh);
            this.Controls.Add(this.txt_H);
            this.Name = "form";
            this.Text = "BMI 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.Label lbh;
        private System.Windows.Forms.Label lbw;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lbbmi;
        private System.Windows.Forms.Button btnbmi;
    }
}

