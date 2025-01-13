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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirArticuloForm));
            panelAnadirArticulo = new Panel();
            txtDescripArticulo_aa = new TextBox();
            lblDescripArticulo_aa = new Label();
            cmbUnidadMedidaArticulo_aa = new ComboBox();
            lblUnidadMedida_aa = new Label();
            dateFechaVencimiArticulo_aa = new DateTimePicker();
            lblFechaVencimiArticulo_aa = new Label();
            numCantidadArticulo_aa = new NumericUpDown();
            dateFechaArticulo_aa = new DateTimePicker();
            lblFechaAdquiArticulo_aa = new Label();
            lblCantidadArticulo_aa = new Label();
            cmbTipoArticulo_aa = new ComboBox();
            lblTipoArticulo_aa = new Label();
            titleBar = new Panel();
            panelControlsTitleBar = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            txtNombreArticulo_aa = new TextBox();
            lblNombreArticulo_aa = new Label();
            btnAnadirArticulo_aa = new Button();
            btnCancelarArticulo_aa = new Button();
            panelAnadirArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadArticulo_aa).BeginInit();
            titleBar.SuspendLayout();
            panelControlsTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panelAnadirArticulo
            // 
            panelAnadirArticulo.Controls.Add(txtDescripArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblDescripArticulo_aa);
            panelAnadirArticulo.Controls.Add(cmbUnidadMedidaArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblUnidadMedida_aa);
            panelAnadirArticulo.Controls.Add(dateFechaVencimiArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblFechaVencimiArticulo_aa);
            panelAnadirArticulo.Controls.Add(numCantidadArticulo_aa);
            panelAnadirArticulo.Controls.Add(dateFechaArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblFechaAdquiArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblCantidadArticulo_aa);
            panelAnadirArticulo.Controls.Add(cmbTipoArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblTipoArticulo_aa);
            panelAnadirArticulo.Controls.Add(titleBar);
            panelAnadirArticulo.Controls.Add(txtNombreArticulo_aa);
            panelAnadirArticulo.Controls.Add(lblNombreArticulo_aa);
            panelAnadirArticulo.Controls.Add(btnAnadirArticulo_aa);
            panelAnadirArticulo.Controls.Add(btnCancelarArticulo_aa);
            panelAnadirArticulo.Dock = DockStyle.Fill;
            panelAnadirArticulo.Location = new Point(0, 0);
            panelAnadirArticulo.Name = "panelAnadirArticulo";
            panelAnadirArticulo.Size = new Size(533, 406);
            panelAnadirArticulo.TabIndex = 0;
            panelAnadirArticulo.Paint += panelAnadirArticulo_Paint;
            // 
            // txtDescripArticulo_aa
            // 
            txtDescripArticulo_aa.Location = new Point(219, 284);
            txtDescripArticulo_aa.Multiline = true;
            txtDescripArticulo_aa.Name = "txtDescripArticulo_aa";
            txtDescripArticulo_aa.Size = new Size(171, 56);
            txtDescripArticulo_aa.TabIndex = 40;
            // 
            // lblDescripArticulo_aa
            // 
            lblDescripArticulo_aa.Anchor = AnchorStyles.Right;
            lblDescripArticulo_aa.AutoSize = true;
            lblDescripArticulo_aa.Font = new Font("Impact", 13F);
            lblDescripArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblDescripArticulo_aa.Location = new Point(115, 284);
            lblDescripArticulo_aa.Name = "lblDescripArticulo_aa";
            lblDescripArticulo_aa.Size = new Size(98, 22);
            lblDescripArticulo_aa.TabIndex = 39;
            lblDescripArticulo_aa.Text = "Descripción";
            // 
            // cmbUnidadMedidaArticulo_aa
            // 
            cmbUnidadMedidaArticulo_aa.FormattingEnabled = true;
            cmbUnidadMedidaArticulo_aa.ItemHeight = 15;
            cmbUnidadMedidaArticulo_aa.Location = new Point(260, 243);
            cmbUnidadMedidaArticulo_aa.Name = "cmbUnidadMedidaArticulo_aa";
            cmbUnidadMedidaArticulo_aa.Size = new Size(73, 23);
            cmbUnidadMedidaArticulo_aa.TabIndex = 38;
            // 
            // lblUnidadMedida_aa
            // 
            lblUnidadMedida_aa.Anchor = AnchorStyles.Right;
            lblUnidadMedida_aa.AutoSize = true;
            lblUnidadMedida_aa.Font = new Font("Impact", 13F);
            lblUnidadMedida_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblUnidadMedida_aa.Location = new Point(115, 244);
            lblUnidadMedida_aa.Name = "lblUnidadMedida_aa";
            lblUnidadMedida_aa.Size = new Size(139, 22);
            lblUnidadMedida_aa.TabIndex = 37;
            lblUnidadMedida_aa.Text = "Unidad de Medida";
            // 
            // dateFechaVencimiArticulo_aa
            // 
            dateFechaVencimiArticulo_aa.Format = DateTimePickerFormat.Short;
            dateFechaVencimiArticulo_aa.Location = new Point(284, 208);
            dateFechaVencimiArticulo_aa.Name = "dateFechaVencimiArticulo_aa";
            dateFechaVencimiArticulo_aa.Size = new Size(97, 23);
            dateFechaVencimiArticulo_aa.TabIndex = 36;
            // 
            // lblFechaVencimiArticulo_aa
            // 
            lblFechaVencimiArticulo_aa.Anchor = AnchorStyles.Right;
            lblFechaVencimiArticulo_aa.AutoSize = true;
            lblFechaVencimiArticulo_aa.Font = new Font("Impact", 13F);
            lblFechaVencimiArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblFechaVencimiArticulo_aa.Location = new Point(115, 208);
            lblFechaVencimiArticulo_aa.Name = "lblFechaVencimiArticulo_aa";
            lblFechaVencimiArticulo_aa.Size = new Size(168, 22);
            lblFechaVencimiArticulo_aa.TabIndex = 35;
            lblFechaVencimiArticulo_aa.Text = "Fecha de Vencimiento";
            // 
            // numCantidadArticulo_aa
            // 
            numCantidadArticulo_aa.Location = new Point(196, 133);
            numCantidadArticulo_aa.Name = "numCantidadArticulo_aa";
            numCantidadArticulo_aa.Size = new Size(66, 23);
            numCantidadArticulo_aa.TabIndex = 34;
            numCantidadArticulo_aa.TextAlign = HorizontalAlignment.Center;
            numCantidadArticulo_aa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateFechaArticulo_aa
            // 
            dateFechaArticulo_aa.Format = DateTimePickerFormat.Short;
            dateFechaArticulo_aa.Location = new Point(284, 172);
            dateFechaArticulo_aa.Name = "dateFechaArticulo_aa";
            dateFechaArticulo_aa.Size = new Size(97, 23);
            dateFechaArticulo_aa.TabIndex = 33;
            // 
            // lblFechaAdquiArticulo_aa
            // 
            lblFechaAdquiArticulo_aa.Anchor = AnchorStyles.Right;
            lblFechaAdquiArticulo_aa.AutoSize = true;
            lblFechaAdquiArticulo_aa.Font = new Font("Impact", 13F);
            lblFechaAdquiArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblFechaAdquiArticulo_aa.Location = new Point(115, 172);
            lblFechaAdquiArticulo_aa.Name = "lblFechaAdquiArticulo_aa";
            lblFechaAdquiArticulo_aa.Size = new Size(163, 22);
            lblFechaAdquiArticulo_aa.TabIndex = 20;
            lblFechaAdquiArticulo_aa.Text = "Fecha de Adquisición";
            // 
            // lblCantidadArticulo_aa
            // 
            lblCantidadArticulo_aa.Anchor = AnchorStyles.Right;
            lblCantidadArticulo_aa.AutoSize = true;
            lblCantidadArticulo_aa.Font = new Font("Impact", 13F);
            lblCantidadArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblCantidadArticulo_aa.Location = new Point(115, 133);
            lblCantidadArticulo_aa.Name = "lblCantidadArticulo_aa";
            lblCantidadArticulo_aa.Size = new Size(75, 22);
            lblCantidadArticulo_aa.TabIndex = 27;
            lblCantidadArticulo_aa.Text = "Cantidad";
            // 
            // cmbTipoArticulo_aa
            // 
            cmbTipoArticulo_aa.FormattingEnabled = true;
            cmbTipoArticulo_aa.ItemHeight = 15;
            cmbTipoArticulo_aa.Location = new Point(162, 95);
            cmbTipoArticulo_aa.Name = "cmbTipoArticulo_aa";
            cmbTipoArticulo_aa.Size = new Size(121, 23);
            cmbTipoArticulo_aa.TabIndex = 26;
            // 
            // lblTipoArticulo_aa
            // 
            lblTipoArticulo_aa.Anchor = AnchorStyles.Right;
            lblTipoArticulo_aa.AutoSize = true;
            lblTipoArticulo_aa.Font = new Font("Impact", 13F);
            lblTipoArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblTipoArticulo_aa.Location = new Point(115, 93);
            lblTipoArticulo_aa.Name = "lblTipoArticulo_aa";
            lblTipoArticulo_aa.Size = new Size(41, 22);
            lblTipoArticulo_aa.TabIndex = 22;
            lblTipoArticulo_aa.Text = "Tipo";
            // 
            // titleBar
            // 
            titleBar.Controls.Add(panelControlsTitleBar);
            titleBar.Dock = DockStyle.Top;
            titleBar.Location = new Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Size = new Size(533, 25);
            titleBar.TabIndex = 21;
            titleBar.MouseDown += titleBar_MouseDown;
            // 
            // panelControlsTitleBar
            // 
            panelControlsTitleBar.Controls.Add(btnMinimize);
            panelControlsTitleBar.Controls.Add(btnClose);
            panelControlsTitleBar.Dock = DockStyle.Right;
            panelControlsTitleBar.Location = new Point(473, 0);
            panelControlsTitleBar.Name = "panelControlsTitleBar";
            panelControlsTitleBar.Size = new Size(60, 25);
            panelControlsTitleBar.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.None;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(10, -8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(0, 0, 20, 0);
            btnMinimize.Size = new Size(26, 26);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(36, 3);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 0, 20, 0);
            btnClose.Size = new Size(24, 20);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtNombreArticulo_aa
            // 
            txtNombreArticulo_aa.Anchor = AnchorStyles.None;
            txtNombreArticulo_aa.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreArticulo_aa.ForeColor = Color.FromArgb(213, 70, 189);
            txtNombreArticulo_aa.Location = new Point(268, 53);
            txtNombreArticulo_aa.Name = "txtNombreArticulo_aa";
            txtNombreArticulo_aa.Size = new Size(148, 27);
            txtNombreArticulo_aa.TabIndex = 18;
            // 
            // lblNombreArticulo_aa
            // 
            lblNombreArticulo_aa.Anchor = AnchorStyles.Right;
            lblNombreArticulo_aa.AutoSize = true;
            lblNombreArticulo_aa.Font = new Font("Impact", 13F);
            lblNombreArticulo_aa.ForeColor = Color.FromArgb(250, 146, 186);
            lblNombreArticulo_aa.Location = new Point(115, 55);
            lblNombreArticulo_aa.Name = "lblNombreArticulo_aa";
            lblNombreArticulo_aa.Size = new Size(147, 22);
            lblNombreArticulo_aa.TabIndex = 17;
            lblNombreArticulo_aa.Text = "Nombre de Articulo";
            // 
            // btnAnadirArticulo_aa
            // 
            btnAnadirArticulo_aa.Anchor = AnchorStyles.None;
            btnAnadirArticulo_aa.BackColor = Color.FromArgb(250, 146, 186);
            btnAnadirArticulo_aa.FlatStyle = FlatStyle.Popup;
            btnAnadirArticulo_aa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnAnadirArticulo_aa.ForeColor = Color.White;
            btnAnadirArticulo_aa.Location = new Point(431, 367);
            btnAnadirArticulo_aa.Name = "btnAnadirArticulo_aa";
            btnAnadirArticulo_aa.Size = new Size(90, 27);
            btnAnadirArticulo_aa.TabIndex = 20;
            btnAnadirArticulo_aa.Text = "Añadir";
            btnAnadirArticulo_aa.UseVisualStyleBackColor = false;
            // 
            // btnCancelarArticulo_aa
            // 
            btnCancelarArticulo_aa.Anchor = AnchorStyles.None;
            btnCancelarArticulo_aa.BackColor = Color.FromArgb(250, 146, 186);
            btnCancelarArticulo_aa.FlatStyle = FlatStyle.Popup;
            btnCancelarArticulo_aa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnCancelarArticulo_aa.ForeColor = Color.White;
            btnCancelarArticulo_aa.Location = new Point(12, 367);
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
            ((System.ComponentModel.ISupportInitialize)numCantidadArticulo_aa).EndInit();
            titleBar.ResumeLayout(false);
            panelControlsTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAnadirArticulo;
        private TextBox txtNombreArticulo_aa;
        private Label lblNombreArticulo_aa;
        private Button btnAnadirArticulo_aa;
        private Button btnCancelarArticulo_aa;
        private Panel titleBar;
        private PictureBox btnMinimize;
        private Panel panelControlsTitleBar;
        private PictureBox btnClose;
        private ComboBox cmbTipoArticulo_aa;
        private Label lblTipoArticulo_aa;
        private TextBox textBox3;
        private Label label3;
        private Label lblFechaAdquiArticulo_aa;
        private Label lblCantidadArticulo_aa;
        private NumericUpDown numCantidadArticulo_aa;
        private DateTimePicker dateFechaArticulo_aa;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaVencimiArticulo_aa;
        private ComboBox cmbUnidadMedidaArticulo_aa;
        private Label lblUnidadMedida_aa;
        private TextBox txtDescripArticulo_aa;
        private Label lblDescripArticulo_aa;
        private DateTimePicker dateFechaVencimiArticulo_aa;
    }
}
