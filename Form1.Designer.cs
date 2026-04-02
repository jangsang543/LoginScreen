namespace LoginScreen
{
    partial class formName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            btnLogin = new Button();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = SystemColors.ActiveCaption;
            lblAppName.Font = new Font("휴먼엑스포", 72F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Yellow;
            lblAppName.Location = new Point(347, 43);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(488, 161);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += lblAppName_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(263, 242);
            txtID.Name = "txtID";
            txtID.Size = new Size(636, 82);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.Font = new Font("한컴 고딕", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(382, 549);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(417, 161);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(263, 369);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(636, 82);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(263, 469);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(460, 32);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // formName
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1179, 764);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "formName";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private Button btnLogin;
        private TextBox txtPW;
        private Label lblErrorMsg;
    }
}
