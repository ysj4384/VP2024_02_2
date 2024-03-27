namespace _006_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(123, 55);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(100, 21);
            this.txb_id.TabIndex = 1;
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(123, 111);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '●';
            this.txb_pass.Size = new System.Drawing.Size(100, 21);
            this.txb_pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "패스워드";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(123, 166);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(100, 23);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "로그인";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(123, 230);
            this.txb_result.Name = "txb_result";
            this.txb_result.ReadOnly = true;
            this.txb_result.Size = new System.Drawing.Size(100, 21);
            this.txb_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(282, 299);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txb_result;
    }
}

