namespace _004연습
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
            this.lbH = new System.Windows.Forms.Label();
            this.txtbH = new System.Windows.Forms.TextBox();
            this.txtbW = new System.Windows.Forms.TextBox();
            this.lbW = new System.Windows.Forms.Label();
            this.btbmi = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbH.Location = new System.Drawing.Point(35, 41);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(44, 15);
            this.lbH.TabIndex = 0;
            this.lbH.Text = "키(cm)";
            // 
            // txtbH
            // 
            this.txtbH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbH.Location = new System.Drawing.Point(98, 38);
            this.txtbH.Name = "txtbH";
            this.txtbH.Size = new System.Drawing.Size(100, 23);
            this.txtbH.TabIndex = 1;
            this.txtbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbW
            // 
            this.txtbW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbW.Location = new System.Drawing.Point(98, 87);
            this.txtbW.Name = "txtbW";
            this.txtbW.Size = new System.Drawing.Size(100, 23);
            this.txtbW.TabIndex = 3;
            this.txtbW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbW.Location = new System.Drawing.Point(35, 90);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(52, 15);
            this.lbW.TabIndex = 2;
            this.lbW.Text = "체중(kg)";
            // 
            // btbmi
            // 
            this.btbmi.BackColor = System.Drawing.SystemColors.Control;
            this.btbmi.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btbmi.Location = new System.Drawing.Point(107, 131);
            this.btbmi.Name = "btbmi";
            this.btbmi.Size = new System.Drawing.Size(75, 23);
            this.btbmi.TabIndex = 4;
            this.btbmi.Text = "BMI";
            this.btbmi.UseVisualStyleBackColor = false;
            this.btbmi.Click += new System.EventHandler(this.btbmi_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.Location = new System.Drawing.Point(35, 188);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 15);
            this.result.TabIndex = 5;
            this.result.Text = "BMI =";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_result.Location = new System.Drawing.Point(35, 232);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(38, 15);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "판정 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(151, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 59);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(273, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btbmi);
            this.Controls.Add(this.txtbW);
            this.Controls.Add(this.lbW);
            this.Controls.Add(this.txtbH);
            this.Controls.Add(this.lbH);
            this.Name = "Form1";
            this.Text = "BMI 계산기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.TextBox txtbH;
        private System.Windows.Forms.TextBox txtbW;
        private System.Windows.Forms.Label lbW;
        private System.Windows.Forms.Button btbmi;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

