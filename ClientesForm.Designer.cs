﻿namespace Umbrella_System
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabctrlClientes = new TabControl();
            tabRegistrarCliente = new TabPage();
            MainPanel = new Panel();
            btnRegistrarCliente = new Button();
            btnCancelarRegistro = new Button();
            panelForm = new Panel();
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
            // txtDireccionCliente
            // 
            txtDireccionCliente.Anchor = AnchorStyles.None;
            txtDireccionCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccionCliente.ForeColor = Color.FromArgb(213, 70, 189);
            txtDireccionCliente.Location = new Point(104, 279);
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
            lblDireccionCliente.Location = new Point(34, 253);
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
            txtTelefonoCliente.Location = new Point(104, 193);
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
            lblTelefonoCliente.Location = new Point(34, 167);
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
            txtNombreCliente.Location = new Point(104, 104);
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
            lblNombreCliente.Location = new Point(34, 71);
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
            tabTodosLosClientes.Location = new Point(4, 27);
            tabTodosLosClientes.Name = "tabTodosLosClientes";
            tabTodosLosClientes.Padding = new Padding(3);
            tabTodosLosClientes.Size = new Size(779, 519);
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
            btnEliminarCliente.Location = new Point(6, 423);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(90, 27);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Anchor = AnchorStyles.None;
            btnModificarCliente.BackColor = Color.FromArgb(250, 146, 186);
            btnModificarCliente.FlatStyle = FlatStyle.Popup;
            btnModificarCliente.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModificarCliente.ForeColor = Color.White;
            btnModificarCliente.Location = new Point(684, 423);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(90, 27);
            btnModificarCliente.TabIndex = 13;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Location = new Point(19, -31);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(737, 448);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
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
        private Button btnCancelarRegistro;
        private Button btnRegistrarCliente;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private DataGridView dgvClientes;
        private FlowLayoutPanel flowPanelServicios;
    }
}