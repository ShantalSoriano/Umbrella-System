namespace Umbrella_System
{
    partial class FacturasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Brown;
            panel1.Location = new Point(420, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 172);
            panel1.TabIndex = 0;
            // 
            // FacturasForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 631);
            Controls.Add(panel1);
            Name = "FacturasForm";
            Text = "Facturas";
            Load += FacturasForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}