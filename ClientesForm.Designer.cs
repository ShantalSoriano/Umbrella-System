namespace Umbrella_System
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabctrlClientes = new TabControl();
            tabRegistrarCliente = new TabPage();
            MainPanel = new Panel();
            btnRegistrarCliente = new Button();
            btnCancelarRegistro = new Button();
            panelForm = new Panel();
            flowPanelServicios = new FlowLayoutPanel();
            lblServiciosPrefCliente = new Label();
            txtDireccionCliente = new TextBox();
            lblDireccionCliente = new Label();
            txtTelefonoCliente = new TextBox();
            lblTelefonoCliente = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            panelPic = new Panel();
            picCliente = new PictureBox();
            tabTodosLosClientes = new TabPage();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            dgvClientes = new DataGridView();
            tabctrlClientes.SuspendLayout();
            tabRegistrarCliente.SuspendLayout();
            MainPanel.SuspendLayout();
            panelForm.SuspendLayout();
            panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCliente).BeginInit();
            tabTodosLosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // tabctrlClientes
            // 
            tabctrlClientes.Controls.Add(tabRegistrarCliente);
            tabctrlClientes.Controls.Add(tabTodosLosClientes);
            tabctrlClientes.Dock = DockStyle.Fill;
            tabctrlClientes.Location = new Point(0, 0);
            tabctrlClientes.Name = "tabctrlClientes";
            tabctrlClientes.SelectedIndex = 0;
            tabctrlClientes.Size = new Size(787, 550);
            tabctrlClientes.TabIndex = 0;
            // 
            // tabRegistrarCliente
            // 
            tabRegistrarCliente.BackColor = Color.Transparent;
            tabRegistrarCliente.BorderStyle = BorderStyle.FixedSingle;
            tabRegistrarCliente.Controls.Add(MainPanel);
            tabRegistrarCliente.Controls.Add(panelPic);
            tabRegistrarCliente.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabRegistrarCliente.ForeColor = Color.FromArgb(250, 146, 186);
            tabRegistrarCliente.Location = new Point(4, 27);
            tabRegistrarCliente.Name = "tabRegistrarCliente";
            tabRegistrarCliente.Padding = new Padding(3);
            tabRegistrarCliente.Size = new Size(779, 519);
            tabRegistrarCliente.TabIndex = 0;
            tabRegistrarCliente.Text = "Registrar Cliente";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.None;
            MainPanel.Controls.Add(btnRegistrarCliente);
            MainPanel.Controls.Add(btnCancelarRegistro);
            MainPanel.Controls.Add(panelForm);
            MainPanel.Location = new Point(238, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(536, 511);
            MainPanel.TabIndex = 1;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Anchor = AnchorStyles.None;
            btnRegistrarCliente.BackColor = Color.FromArgb(250, 146, 186);
            btnRegistrarCliente.FlatStyle = FlatStyle.Popup;
            btnRegistrarCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnRegistrarCliente.ForeColor = Color.White;
            btnRegistrarCliente.Location = new Point(442, 476);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(90, 27);
            btnRegistrarCliente.TabIndex = 12;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnCancelarRegistro
            // 
            btnCancelarRegistro.Anchor = AnchorStyles.None;
            btnCancelarRegistro.BackColor = Color.FromArgb(250, 146, 186);
            btnCancelarRegistro.FlatStyle = FlatStyle.Popup;
            btnCancelarRegistro.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnCancelarRegistro.ForeColor = Color.White;
            btnCancelarRegistro.Location = new Point(17, 476);
            btnCancelarRegistro.Name = "btnCancelarRegistro";
            btnCancelarRegistro.Size = new Size(90, 27);
            btnCancelarRegistro.TabIndex = 11;
            btnCancelarRegistro.Text = "Cancelar";
            btnCancelarRegistro.UseVisualStyleBackColor = false;
            btnCancelarRegistro.Click += btnCancelarRegistro_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.None;
            panelForm.BackColor = Color.FromArgb(22, 97, 58);
            panelForm.Controls.Add(flowPanelServicios);
            panelForm.Controls.Add(lblServiciosPrefCliente);
            panelForm.Controls.Add(txtDireccionCliente);
            panelForm.Controls.Add(lblDireccionCliente);
            panelForm.Controls.Add(txtTelefonoCliente);
            panelForm.Controls.Add(lblTelefonoCliente);
            panelForm.Controls.Add(txtNombreCliente);
            panelForm.Controls.Add(lblNombreCliente);
            panelForm.Location = new Point(32, 36);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(475, 429);
            panelForm.TabIndex = 0;
            // 
            // flowPanelServicios
            // 
            flowPanelServicios.AutoScroll = true;
            flowPanelServicios.FlowDirection = FlowDirection.TopDown;
            flowPanelServicios.Location = new Point(45, 346);
            flowPanelServicios.Name = "flowPanelServicios";
            flowPanelServicios.Size = new Size(394, 88);
            flowPanelServicios.TabIndex = 13;
            flowPanelServicios.WrapContents = false;
            // 
            // lblServiciosPrefCliente
            // 
            lblServiciosPrefCliente.Anchor = AnchorStyles.Right;
            lblServiciosPrefCliente.AutoSize = true;
            lblServiciosPrefCliente.Font = new Font("Impact", 13F);
            lblServiciosPrefCliente.ForeColor = Color.FromArgb(250, 146, 186);
            lblServiciosPrefCliente.Location = new Point(28, 299);
            lblServiciosPrefCliente.Name = "lblServiciosPrefCliente";
            lblServiciosPrefCliente.Size = new Size(155, 22);
            lblServiciosPrefCliente.TabIndex = 12;
            lblServiciosPrefCliente.Text = "Servicios Preferidos";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Anchor = AnchorStyles.None;
            txtDireccionCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccionCliente.ForeColor = Color.FromArgb(213, 70, 189);
            txtDireccionCliente.Location = new Point(98, 236);
            txtDireccionCliente.Multiline = true;
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(320, 37);
            txtDireccionCliente.TabIndex = 11;
            // 
            // lblDireccionCliente
            // 
            lblDireccionCliente.Anchor = AnchorStyles.Right;
            lblDireccionCliente.AutoSize = true;
            lblDireccionCliente.Font = new Font("Impact", 13F);
            lblDireccionCliente.ForeColor = Color.FromArgb(250, 146, 186);
            lblDireccionCliente.Location = new Point(28, 210);
            lblDireccionCliente.Name = "lblDireccionCliente";
            lblDireccionCliente.Size = new Size(81, 22);
            lblDireccionCliente.TabIndex = 10;
            lblDireccionCliente.Text = "Dirección";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Anchor = AnchorStyles.None;
            txtTelefonoCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefonoCliente.ForeColor = Color.FromArgb(213, 70, 189);
            txtTelefonoCliente.Location = new Point(98, 150);
            txtTelefonoCliente.Multiline = true;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(320, 37);
            txtTelefonoCliente.TabIndex = 9;
            txtTelefonoCliente.TextChanged += textBox1_TextChanged;
            // 
            // lblTelefonoCliente
            // 
            lblTelefonoCliente.Anchor = AnchorStyles.Right;
            lblTelefonoCliente.AutoSize = true;
            lblTelefonoCliente.Font = new Font("Impact", 13F);
            lblTelefonoCliente.ForeColor = Color.FromArgb(250, 146, 186);
            lblTelefonoCliente.Location = new Point(28, 124);
            lblTelefonoCliente.Name = "lblTelefonoCliente";
            lblTelefonoCliente.Size = new Size(72, 22);
            lblTelefonoCliente.TabIndex = 8;
            lblTelefonoCliente.Text = "Telefono";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = AnchorStyles.None;
            txtNombreCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCliente.ForeColor = Color.FromArgb(213, 70, 189);
            txtNombreCliente.Location = new Point(98, 61);
            txtNombreCliente.Multiline = true;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(320, 37);
            txtNombreCliente.TabIndex = 7;
            txtNombreCliente.TextChanged += txtUsuario_TextChanged;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.Anchor = AnchorStyles.Right;
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Impact", 13F);
            lblNombreCliente.ForeColor = Color.FromArgb(250, 146, 186);
            lblNombreCliente.Location = new Point(28, 28);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(138, 22);
            lblNombreCliente.TabIndex = 6;
            lblNombreCliente.Text = "Nombre Completo";
            // 
            // panelPic
            // 
            panelPic.Anchor = AnchorStyles.None;
            panelPic.Controls.Add(picCliente);
            panelPic.Location = new Point(3, 3);
            panelPic.Name = "panelPic";
            panelPic.Size = new Size(235, 511);
            panelPic.TabIndex = 0;
            // 
            // picCliente
            // 
            picCliente.Anchor = AnchorStyles.None;
            picCliente.Image = (Image)resources.GetObject("picCliente.Image");
            picCliente.Location = new Point(42, 140);
            picCliente.Name = "picCliente";
            picCliente.Size = new Size(146, 202);
            picCliente.SizeMode = PictureBoxSizeMode.Zoom;
            picCliente.TabIndex = 0;
            picCliente.TabStop = false;
            // 
            // tabTodosLosClientes
            // 
            tabTodosLosClientes.BorderStyle = BorderStyle.Fixed3D;
            tabTodosLosClientes.Controls.Add(btnEliminarCliente);
            tabTodosLosClientes.Controls.Add(btnModificarCliente);
            tabTodosLosClientes.Controls.Add(dgvClientes);
            tabTodosLosClientes.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabTodosLosClientes.ForeColor = Color.FromArgb(250, 146, 186);
            tabTodosLosClientes.Location = new Point(4, 24);
            tabTodosLosClientes.Name = "tabTodosLosClientes";
            tabTodosLosClientes.Padding = new Padding(3);
            tabTodosLosClientes.Size = new Size(779, 522);
            tabTodosLosClientes.TabIndex = 1;
            tabTodosLosClientes.Text = "Todos los Clientes";
            tabTodosLosClientes.UseVisualStyleBackColor = true;
            tabTodosLosClientes.Click += tabTodosLosClientes_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Anchor = AnchorStyles.None;
            btnEliminarCliente.BackColor = Color.FromArgb(250, 146, 186);
            btnEliminarCliente.FlatStyle = FlatStyle.Popup;
            btnEliminarCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(6, 453);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(90, 27);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Anchor = AnchorStyles.None;
            btnModificarCliente.BackColor = Color.FromArgb(250, 146, 186);
            btnModificarCliente.FlatStyle = FlatStyle.Popup;
            btnModificarCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModificarCliente.ForeColor = Color.White;
            btnModificarCliente.Location = new Point(684, 453);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(90, 27);
            btnModificarCliente.TabIndex = 13;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.None;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Location = new Point(28, -4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(730, 448);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(787, 550);
            Controls.Add(tabctrlClientes);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(250, 146, 186);
            Name = "ClientesForm";
            Text = "Clientes";
            Load += ClientesForm_Load;
            tabctrlClientes.ResumeLayout(false);
            tabRegistrarCliente.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCliente).EndInit();
            tabTodosLosClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabctrlClientes;
        private TabPage tabRegistrarCliente;
        private TabPage tabTodosLosClientes;
        private Panel MainPanel;
        private Panel panelPic;
        private PictureBox picCliente;
        private Panel panelForm;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private TextBox txtTelefonoCliente;
        private Label lblTelefonoCliente;
        private TextBox txtDireccionCliente;
        private Label lblDireccionCliente;
        private Label lblServiciosPrefCliente;
        private Button btnCancelarRegistro;
        private Button btnRegistrarCliente;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private DataGridView dgvClientes;
        private FlowLayoutPanel flowPanelServicios;
    }
}