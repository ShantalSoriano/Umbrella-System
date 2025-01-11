namespace Umbrella_System
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            greenPanel = new Panel();
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
            greenPanel.Controls.Add(loginPanel);
            greenPanel.Controls.Add(imgPanel);
            greenPanel.Location = new Point(-31, -12);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(761, 378);
            greenPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.Controls.Add(LinkLBLForgotPass);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(pictureBox2);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtUsuario);
            loginPanel.Controls.Add(lblUsuario);
            loginPanel.Location = new Point(394, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(367, 378);
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
            pictureBox2.Location = new Point(147, 28);
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
            txtPassword.Location = new Point(18, 235);
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
            lblPassword.Location = new Point(18, 209);
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
            txtUsuario.Location = new Point(18, 128);
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
            lblUsuario.Location = new Point(18, 102);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // imgPanel
            // 
            imgPanel.Anchor = AnchorStyles.None;
            imgPanel.Controls.Add(pictureBox1);
            imgPanel.Location = new Point(0, 0);
            imgPanel.Name = "imgPanel";
            imgPanel.Size = new Size(388, 378);
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
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(242, 247, 242);
            ClientSize = new Size(711, 362);
            Controls.Add(greenPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            greenPanel.ResumeLayout(false);
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
    }
}
