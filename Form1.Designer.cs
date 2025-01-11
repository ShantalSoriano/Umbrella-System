namespace Umbrella_System
{
    partial class Form1
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
            greenPanel = new Panel();
            imgPanel = new Panel();
            loginPanel = new Panel();
            greenPanel.SuspendLayout();
            SuspendLayout();
            // 
            // greenPanel
            // 
            greenPanel.BackColor = Color.FromArgb(22, 97, 58);
            greenPanel.Controls.Add(loginPanel);
            greenPanel.Controls.Add(imgPanel);
            greenPanel.Location = new Point(33, 34);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(761, 378);
            greenPanel.TabIndex = 0;
            // 
            // imgPanel
            // 
            imgPanel.Dock = DockStyle.Left;
            imgPanel.Location = new Point(0, 0);
            imgPanel.Name = "imgPanel";
            imgPanel.Size = new Size(350, 378);
            imgPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            loginPanel.Dock = DockStyle.Right;
            loginPanel.Location = new Point(394, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(367, 378);
            loginPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 455);
            Controls.Add(greenPanel);
            Name = "Form1";
            Text = "Form1";
            greenPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel greenPanel;
        private Panel loginPanel;
        private Panel imgPanel;
    }
}
