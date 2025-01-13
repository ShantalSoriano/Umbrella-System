namespace Umbrella_System
{
    partial class AnadirArticuloForm
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
            panelAnadirArticulo = new Panel();
            titleBar = new Panel();
            txtNombreArticulo_aa = new TextBox();
            lblNombreArticulo_aa = new Label();
            btnAnadirArticulo_bb = new Button();
            btnCancelarArticulo_aa = new Button();
            panelAnadirArticulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelAnadirArticulo
            // 
            panelAnadirArticulo.Controls.Add(titleBar);
            panelAnadirArticulo.Controls.Add(txtNombreArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblNombreArticulo_aa);
            panelAnadirArticulo.Controls.Add(btnAnadirArticulo_bb);
            panelAnadirArticulo.Controls.Add(btnCancelarArticulo_aa);
            panelAnadirArticulo.Dock = DockStyle.Fill;
            panelAnadirArticulo.Location = new Point(0, 0);
            panelAnadirArticulo.Name = "panelAnadirArticulo";
            panelAnadirArticulo.Size = new Size(533, 406);
            panelAnadirArticulo.TabIndex = 0;
            // 
            // titleBar
            // 
            titleBar.Dock = DockStyle.Top;
            titleBar.Location = new Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Size = new Size(533, 34);
            titleBar.TabIndex = 21;
            titleBar.MouseDown += titleBar_MouseDown;
            // 
            // txtNombreArticulo_aa
            // 
            txtNombreArticulo_aa.Anchor = AnchorStyles.None;
            txtNombreArticulo_aa.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreArticulo_aa.ForeColor = Color.FromArgb(213, 70, 189);
            txtNombreArticulo_aa.Location = new Point(112, 99);
            txtNombreArticulo_aa.Multiline = true;
            txtNombreArticulo_aa.Name = "txtNombreArticulo_aa";
            txtNombreArticulo_aa.Size = new Size(320, 37);
            txtNombreArticulo_aa.TabIndex = 18;
            // 
            // lblNombreArticulo_aa
            // 
            lblNombreArticulo_aa.Anchor = AnchorStyles.Right;
            lblNombreArticulo_aa.AutoSize = true;
            lblNombreArticulo_aa.Font = new Font("Impact", 13F);
            lblNombreArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblNombreArticulo_aa.Location = new Point(54, 66);
            lblNombreArticulo_aa.Name = "lblNombreArticulo_aa";
            lblNombreArticulo_aa.Size = new Size(147, 22);
            lblNombreArticulo_aa.TabIndex = 17;
            lblNombreArticulo_aa.Text = "Nombre de Articulo";
            // 
            // btnAnadirArticulo_bb
            // 
            btnAnadirArticulo_bb.Anchor = AnchorStyles.None;
            btnAnadirArticulo_bb.BackColor = Color.FromArgb(250, 146, 186);
            btnAnadirArticulo_bb.FlatStyle = FlatStyle.Popup;
            btnAnadirArticulo_bb.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnAnadirArticulo_bb.ForeColor = Color.White;
            btnAnadirArticulo_bb.Location = new Point(401, 314);
            btnAnadirArticulo_bb.Name = "btnAnadirArticulo_bb";
            btnAnadirArticulo_bb.Size = new Size(90, 27);
            btnAnadirArticulo_bb.TabIndex = 20;
            btnAnadirArticulo_bb.Text = "Anadir";
            btnAnadirArticulo_bb.UseVisualStyleBackColor = false;
            // 
            // btnCancelarArticulo_aa
            // 
            btnCancelarArticulo_aa.Anchor = AnchorStyles.None;
            btnCancelarArticulo_aa.BackColor = Color.FromArgb(250, 146, 186);
            btnCancelarArticulo_aa.FlatStyle = FlatStyle.Popup;
            btnCancelarArticulo_aa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnCancelarArticulo_aa.ForeColor = Color.White;
            btnCancelarArticulo_aa.Location = new Point(42, 294);
            btnCancelarArticulo_aa.Name = "btnCancelarArticulo_aa";
            btnCancelarArticulo_aa.Size = new Size(90, 27);
            btnCancelarArticulo_aa.TabIndex = 19;
            btnCancelarArticulo_aa.Text = "Cancelar";
            btnCancelarArticulo_aa.UseVisualStyleBackColor = false;
            btnCancelarArticulo_aa.Click += btnCancelarArticulo_aa_Click;
            // 
            // AnadirArticuloForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(533, 406);
            Controls.Add(panelAnadirArticulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnadirArticuloForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AnadirArticuloForm_Load;
            panelAnadirArticulo.ResumeLayout(false);
            panelAnadirArticulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAnadirArticulo;
        private TextBox txtNombreArticulo_aa;
        private Label lblNombreArticulo_aa;
        private Button btnAnadirArticulo_bb;
        private Button btnCancelarArticulo_aa;
        private Panel titleBar;
    }
}