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
            imgPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            greenPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // greenPanel
            // 
            greenPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            greenPanel.BackColor = Color.FromArgb(22, 97, 58);
            greenPanel.Controls.Add(loginPanel);
            greenPanel.Controls.Add(imgPanel);
            greenPanel.Location = new Point(33, 34);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(761, 378);
            greenPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtUsuario);
            loginPanel.Controls.Add(lblUsuario);
            loginPanel.Location = new Point(394, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(367, 378);
            loginPanel.TabIndex = 1;
            // 
            // imgPanel
            // 
            imgPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            imgPanel.Controls.Add(pictureBox1);
            imgPanel.Location = new Point(0, 0);
            imgPanel.Name = "imgPanel";
            imgPanel.Size = new Size(350, 378);
            imgPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(250, 146, 186);
            lblUsuario.Location = new Point(14, 77);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(14, 103);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(331, 37);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(14, 210);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(331, 37);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(250, 146, 186);
            lblPassword.Location = new Point(14, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(242, 247, 242);
            ClientSize = new Size(838, 455);
            Controls.Add(greenPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            greenPanel.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
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
    }
}
