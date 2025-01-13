namespace Umbrella_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            greenPanel = new Panel();
            titleBarLog = new Panel();
            panelControlsTitleBar = new Panel();
            btnMinimize3 = new PictureBox();
            btnClose3 = new PictureBox();
            btnMinimize2 = new PictureBox();
            btnClose2 = new PictureBox();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            loginPanel = new Panel();
            LinkLBLForgotPass = new LinkLabel();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            imgPanel = new Panel();
            pictureBox1 = new PictureBox();
            greenPanel.SuspendLayout();
            titleBarLog.SuspendLayout();
            panelControlsTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // greenPanel
            // 
            greenPanel.Anchor = AnchorStyles.None;
            greenPanel.BackColor = Color.FromArgb(22, 97, 58);
            greenPanel.Controls.Add(titleBarLog);
            greenPanel.Controls.Add(loginPanel);
            greenPanel.Controls.Add(imgPanel);
            greenPanel.Location = new Point(-31, -12);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(761, 378);
            greenPanel.TabIndex = 0;
            // 
            // titleBarLog
            // 
            titleBarLog.BackColor = Color.White;
            titleBarLog.Controls.Add(panelControlsTitleBar);
            titleBarLog.Location = new Point(29, 13);
            titleBarLog.Name = "titleBarLog";
            titleBarLog.Size = new Size(712, 19);
            titleBarLog.TabIndex = 2;
            titleBarLog.MouseDown += titleBarLog_MouseDown;
            // 
            // panelControlsTitleBar
            // 
            panelControlsTitleBar.Controls.Add(btnMinimize3);
            panelControlsTitleBar.Controls.Add(btnClose3);
            panelControlsTitleBar.Controls.Add(btnMinimize2);
            panelControlsTitleBar.Controls.Add(btnClose2);
            panelControlsTitleBar.Controls.Add(btnMinimize);
            panelControlsTitleBar.Controls.Add(btnClose);
            panelControlsTitleBar.Dock = DockStyle.Right;
            panelControlsTitleBar.Location = new Point(630, 0);
            panelControlsTitleBar.Name = "panelControlsTitleBar";
            panelControlsTitleBar.Size = new Size(82, 19);
            panelControlsTitleBar.TabIndex = 3;
            // 
            // btnMinimize3
            // 
            btnMinimize3.Anchor = AnchorStyles.None;
            btnMinimize3.Image = (Image)resources.GetObject("btnMinimize3.Image");
            btnMinimize3.Location = new Point(32, -11);
            btnMinimize3.Name = "btnMinimize3";
            btnMinimize3.Padding = new Padding(0, 0, 20, 0);
            btnMinimize3.Size = new Size(26, 26);
            btnMinimize3.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize3.TabIndex = 6;
            btnMinimize3.TabStop = false;
            btnMinimize3.Click += btnMinimize3_Click;
            // 
            // btnClose3
            // 
            btnClose3.Anchor = AnchorStyles.None;
            btnClose3.Image = (Image)resources.GetObject("btnClose3.Image");
            btnClose3.Location = new Point(57, 1);
            btnClose3.Name = "btnClose3";
            btnClose3.Padding = new Padding(0, 0, 20, 0);
            btnClose3.Size = new Size(24, 20);
            btnClose3.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose3.TabIndex = 5;
            btnClose3.TabStop = false;
            btnClose3.Click += btnClose3_Click;
            // 
            // btnMinimize2
            // 
            btnMinimize2.Anchor = AnchorStyles.None;
            btnMinimize2.Image = (Image)resources.GetObject("btnMinimize2.Image");
            btnMinimize2.Location = new Point(-53, -49);
            btnMinimize2.Name = "btnMinimize2";
            btnMinimize2.Padding = new Padding(0, 0, 20, 0);
            btnMinimize2.Size = new Size(26, 26);
            btnMinimize2.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize2.TabIndex = 4;
            btnMinimize2.TabStop = false;
            // 
            // btnClose2
            // 
            btnClose2.Anchor = AnchorStyles.None;
            btnClose2.Image = (Image)resources.GetObject("btnClose2.Image");
            btnClose2.Location = new Point(-26, -39);
            btnClose2.Name = "btnClose2";
            btnClose2.Padding = new Padding(0, 0, 20, 0);
            btnClose2.Size = new Size(24, 20);
            btnClose2.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose2.TabIndex = 3;
            btnClose2.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.None;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(-119, -87);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(0, 0, 20, 0);
            btnMinimize.Size = new Size(26, 26);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(-93, -76);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 0, 20, 0);
            btnClose.Size = new Size(24, 20);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(LinkLBLForgotPass);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtUsuario);
            loginPanel.Controls.Add(lblUsuario);
            loginPanel.Dock = DockStyle.Right;
            loginPanel.Location = new Point(358, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(403, 378);
            loginPanel.TabIndex = 1;
            // 
            // LinkLBLForgotPass
            // 
            LinkLBLForgotPass.AutoSize = true;
            LinkLBLForgotPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LinkLBLForgotPass.LinkColor = Color.FromArgb(250, 146, 186);
            LinkLBLForgotPass.Location = new Point(136, 348);
            LinkLBLForgotPass.Name = "LinkLBLForgotPass";
            LinkLBLForgotPass.Size = new Size(126, 17);
            LinkLBLForgotPass.TabIndex = 6;
            LinkLBLForgotPass.TabStop = true;
            LinkLBLForgotPass.Text = "Olvidé mi contraseña\r\n";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 146, 186);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.SeaShell;
            btnLogin.Location = new Point(130, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Right;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(213, 70, 189);
            txtPassword.Location = new Point(54, 235);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 37);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(250, 146, 186);
            lblPassword.Location = new Point(54, 209);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Right;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(213, 70, 189);
            txtUsuario.Location = new Point(54, 128);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 37);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(250, 146, 186);
            lblUsuario.Location = new Point(54, 102);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // imgPanel
            // 
            imgPanel.Controls.Add(pictureBox1);
            imgPanel.Dock = DockStyle.Left;
            imgPanel.Location = new Point(0, 0);
            imgPanel.Name = "imgPanel";
            imgPanel.Size = new Size(352, 378);
            imgPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(242, 247, 242);
            ClientSize = new Size(711, 362);
            Controls.Add(greenPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            greenPanel.ResumeLayout(false);
            titleBarLog.ResumeLayout(false);
            panelControlsTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            imgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel greenPanel;
        private Panel loginPanel;
        private Panel imgPanel;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsuario;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private LinkLabel LinkLBLForgotPass;
        private Panel titleBarLog;
        private Panel panelControlsTitleBar;
        private PictureBox btnMinimize2;
        private PictureBox btnClose2;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private PictureBox btnMinimize3;
        private PictureBox btnClose3;
    }
}
