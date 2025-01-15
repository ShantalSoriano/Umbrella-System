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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasForm));
            tabctrlFacturas = new TabControl();
            tabCrearFactura = new TabPage();
            Cancelar = new Button();
            panel1 = new Panel();
            innerPanelCrearFactura = new Panel();
            cmbCliente_fa = new ComboBox();
            lblClienteFactura = new Label();
            btnGuardarFac = new Button();
            autoDevuelta = new Label();
            lblDevuelta = new Label();
            txtEfectivo = new TextBox();
            lblEfectivo = new Label();
            autoTotal = new Label();
            lblTotal = new Label();
            dgvRecuentoServicios = new DataGridView();
            nombreServicio = new DataGridViewTextBoxColumn();
            cantidadServicio = new DataGridViewTextBoxColumn();
            subtotalServicio = new DataGridViewTextBoxColumn();
            totalServicio = new DataGridViewTextBoxColumn();
            btnEliminarServicio = new Button();
            numCantidadServicio = new NumericUpDown();
            btnAgregarServicio = new Button();
            lblCantidadServicio = new Label();
            autoNombreServicio = new Label();
            lblNombreServicio = new Label();
            lblDigito1 = new Label();
            autoPrecioServicio = new Label();
            lblPrecioServicio = new Label();
            lblServicioFactura = new Label();
            cmbServicio_fa = new ComboBox();
            tabGestionarFacturas = new TabPage();
            dgvGestionarFacturas = new DataGridView();
            NumeroFactura = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            iconVerDetallesFactura = new DataGridViewImageColumn();
            iconEditar = new DataGridViewImageColumn();
            iconEliminarFactura = new DataGridViewImageColumn();
            tabctrlFacturas.SuspendLayout();
            tabCrearFactura.SuspendLayout();
            panel1.SuspendLayout();
            innerPanelCrearFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecuentoServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadServicio).BeginInit();
            tabGestionarFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionarFacturas).BeginInit();
            SuspendLayout();
            // 
            // tabctrlFacturas
            // 
            tabctrlFacturas.Controls.Add(tabCrearFactura);
            tabctrlFacturas.Controls.Add(tabGestionarFacturas);
            tabctrlFacturas.Dock = DockStyle.Fill;
            tabctrlFacturas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            tabctrlFacturas.Location = new Point(0, 0);
            tabctrlFacturas.Name = "tabctrlFacturas";
            tabctrlFacturas.SelectedIndex = 0;
            tabctrlFacturas.Size = new Size(787, 550);
            tabctrlFacturas.TabIndex = 0;
            // 
            // tabCrearFactura
            // 
            tabCrearFactura.BackColor = Color.FromArgb(22, 97, 58);
            tabCrearFactura.Controls.Add(Cancelar);
            tabCrearFactura.Controls.Add(panel1);
            tabCrearFactura.ForeColor = SystemColors.ActiveCaptionText;
            tabCrearFactura.Location = new Point(4, 27);
            tabCrearFactura.Name = "tabCrearFactura";
            tabCrearFactura.Padding = new Padding(3);
            tabCrearFactura.Size = new Size(779, 519);
            tabCrearFactura.TabIndex = 0;
            tabCrearFactura.Text = "Crear Factura";
            // 
            // Cancelar
            // 
            Cancelar.Anchor = AnchorStyles.None;
            Cancelar.BackColor = Color.FromArgb(250, 146, 186);
            Cancelar.FlatStyle = FlatStyle.Popup;
            Cancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Cancelar.ForeColor = Color.White;
            Cancelar.Location = new Point(20, 486);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(90, 27);
            Cancelar.TabIndex = 28;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 247, 242);
            panel1.Controls.Add(innerPanelCrearFactura);
            panel1.Location = new Point(40, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 445);
            panel1.TabIndex = 0;
            // 
            // innerPanelCrearFactura
            // 
            innerPanelCrearFactura.Controls.Add(cmbCliente_fa);
            innerPanelCrearFactura.Controls.Add(lblClienteFactura);
            innerPanelCrearFactura.Controls.Add(btnGuardarFac);
            innerPanelCrearFactura.Controls.Add(autoDevuelta);
            innerPanelCrearFactura.Controls.Add(lblDevuelta);
            innerPanelCrearFactura.Controls.Add(txtEfectivo);
            innerPanelCrearFactura.Controls.Add(lblEfectivo);
            innerPanelCrearFactura.Controls.Add(autoTotal);
            innerPanelCrearFactura.Controls.Add(lblTotal);
            innerPanelCrearFactura.Controls.Add(dgvRecuentoServicios);
            innerPanelCrearFactura.Controls.Add(btnEliminarServicio);
            innerPanelCrearFactura.Controls.Add(numCantidadServicio);
            innerPanelCrearFactura.Controls.Add(btnAgregarServicio);
            innerPanelCrearFactura.Controls.Add(lblCantidadServicio);
            innerPanelCrearFactura.Controls.Add(autoNombreServicio);
            innerPanelCrearFactura.Controls.Add(lblNombreServicio);
            innerPanelCrearFactura.Controls.Add(lblDigito1);
            innerPanelCrearFactura.Controls.Add(autoPrecioServicio);
            innerPanelCrearFactura.Controls.Add(lblPrecioServicio);
            innerPanelCrearFactura.Controls.Add(lblServicioFactura);
            innerPanelCrearFactura.Controls.Add(cmbServicio_fa);
            innerPanelCrearFactura.Location = new Point(16, 18);
            innerPanelCrearFactura.Name = "innerPanelCrearFactura";
            innerPanelCrearFactura.Size = new Size(661, 408);
            innerPanelCrearFactura.TabIndex = 10;
            innerPanelCrearFactura.Paint += innerPanelCrearFactura_Paint;
            // 
            // cmbCliente_fa
            // 
            cmbCliente_fa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            cmbCliente_fa.ForeColor = Color.FromArgb(22, 97, 58);
            cmbCliente_fa.FormattingEnabled = true;
            cmbCliente_fa.Location = new Point(234, 5);
            cmbCliente_fa.Name = "cmbCliente_fa";
            cmbCliente_fa.Size = new Size(210, 26);
            cmbCliente_fa.TabIndex = 27;
            cmbCliente_fa.SelectedIndexChanged += cmbCliente_fa_SelectedIndexChanged;
            // 
            // lblClienteFactura
            // 
            lblClienteFactura.Anchor = AnchorStyles.Right;
            lblClienteFactura.AutoSize = true;
            lblClienteFactura.Font = new Font("Impact", 13F);
            lblClienteFactura.ForeColor = Color.FromArgb(250, 146, 186);
            lblClienteFactura.Location = new Point(166, 9);
            lblClienteFactura.Name = "lblClienteFactura";
            lblClienteFactura.Size = new Size(62, 22);
            lblClienteFactura.TabIndex = 26;
            lblClienteFactura.Text = "Cliente";
            // 
            // btnGuardarFac
            // 
            btnGuardarFac.Anchor = AnchorStyles.None;
            btnGuardarFac.BackColor = Color.FromArgb(250, 146, 186);
            btnGuardarFac.FlatStyle = FlatStyle.Popup;
            btnGuardarFac.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnGuardarFac.ForeColor = Color.White;
            btnGuardarFac.Location = new Point(525, 364);
            btnGuardarFac.Name = "btnGuardarFac";
            btnGuardarFac.Size = new Size(90, 27);
            btnGuardarFac.TabIndex = 25;
            btnGuardarFac.Text = "Guardar";
            btnGuardarFac.UseVisualStyleBackColor = false;
            btnGuardarFac.Click += Guardar_Click;
            // 
            // autoDevuelta
            // 
            autoDevuelta.AutoSize = true;
            autoDevuelta.Font = new Font("Microsoft Sans Serif", 11.25F);
            autoDevuelta.ForeColor = Color.FromArgb(22, 97, 58);
            autoDevuelta.Location = new Point(523, 328);
            autoDevuelta.Name = "autoDevuelta";
            autoDevuelta.Size = new Size(13, 18);
            autoDevuelta.TabIndex = 22;
            autoDevuelta.Text = "-";
            autoDevuelta.Click += autoDevuelta_Click;
            // 
            // lblDevuelta
            // 
            lblDevuelta.Anchor = AnchorStyles.Right;
            lblDevuelta.AutoSize = true;
            lblDevuelta.Font = new Font("Impact", 13F);
            lblDevuelta.ForeColor = Color.FromArgb(250, 146, 186);
            lblDevuelta.Location = new Point(490, 296);
            lblDevuelta.Name = "lblDevuelta";
            lblDevuelta.Size = new Size(73, 22);
            lblDevuelta.TabIndex = 21;
            lblDevuelta.Text = "Devuelta";
            // 
            // txtEfectivo
            // 
            txtEfectivo.ForeColor = Color.FromArgb(22, 97, 58);
            txtEfectivo.Location = new Point(515, 257);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(100, 24);
            txtEfectivo.TabIndex = 20;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // lblEfectivo
            // 
            lblEfectivo.Anchor = AnchorStyles.Right;
            lblEfectivo.AutoSize = true;
            lblEfectivo.Font = new Font("Impact", 13F);
            lblEfectivo.ForeColor = Color.FromArgb(250, 146, 186);
            lblEfectivo.Location = new Point(490, 232);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(66, 22);
            lblEfectivo.TabIndex = 19;
            lblEfectivo.Text = "Efectivo";
            // 
            // autoTotal
            // 
            autoTotal.AutoSize = true;
            autoTotal.Font = new Font("Microsoft Sans Serif", 11.25F);
            autoTotal.ForeColor = Color.FromArgb(22, 97, 58);
            autoTotal.Location = new Point(515, 203);
            autoTotal.Name = "autoTotal";
            autoTotal.Size = new Size(13, 18);
            autoTotal.TabIndex = 18;
            autoTotal.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Impact", 13F);
            lblTotal.ForeColor = Color.FromArgb(250, 146, 186);
            lblTotal.Location = new Point(490, 179);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 22);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total";
            // 
            // dgvRecuentoServicios
            // 
            dgvRecuentoServicios.AllowUserToAddRows = false;
            dgvRecuentoServicios.AllowUserToDeleteRows = false;
            dgvRecuentoServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvRecuentoServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecuentoServicios.Columns.AddRange(new DataGridViewColumn[] { nombreServicio, cantidadServicio, subtotalServicio, totalServicio });
            dgvRecuentoServicios.Location = new Point(7, 168);
            dgvRecuentoServicios.Name = "dgvRecuentoServicios";
            dgvRecuentoServicios.ReadOnly = true;
            dgvRecuentoServicios.Size = new Size(483, 233);
            dgvRecuentoServicios.TabIndex = 16;
            // 
            // nombreServicio
            // 
            nombreServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreServicio.HeaderText = "Servicio";
            nombreServicio.Name = "nombreServicio";
            nombreServicio.ReadOnly = true;
            // 
            // cantidadServicio
            // 
            cantidadServicio.HeaderText = "Cantidad";
            cantidadServicio.Name = "cantidadServicio";
            cantidadServicio.ReadOnly = true;
            cantidadServicio.Width = 99;
            // 
            // subtotalServicio
            // 
            subtotalServicio.HeaderText = "Subtotal";
            subtotalServicio.Name = "subtotalServicio";
            subtotalServicio.ReadOnly = true;
            subtotalServicio.Width = 95;
            // 
            // totalServicio
            // 
            totalServicio.HeaderText = "Total";
            totalServicio.Name = "totalServicio";
            totalServicio.ReadOnly = true;
            totalServicio.Width = 71;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.Anchor = AnchorStyles.None;
            btnEliminarServicio.BackColor = Color.FromArgb(250, 146, 186);
            btnEliminarServicio.FlatStyle = FlatStyle.Popup;
            btnEliminarServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEliminarServicio.ForeColor = Color.White;
            btnEliminarServicio.Location = new Point(437, 109);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(90, 27);
            btnEliminarServicio.TabIndex = 13;
            btnEliminarServicio.Text = "Eliminar";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            btnEliminarServicio.Click += btnEliminarServicio_Click;
            // 
            // numCantidadServicio
            // 
            numCantidadServicio.Font = new Font("Microsoft Sans Serif", 11.25F);
            numCantidadServicio.ForeColor = Color.FromArgb(22, 97, 58);
            numCantidadServicio.Location = new Point(247, 136);
            numCantidadServicio.Name = "numCantidadServicio";
            numCantidadServicio.Size = new Size(47, 24);
            numCantidadServicio.TabIndex = 15;
            numCantidadServicio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Anchor = AnchorStyles.None;
            btnAgregarServicio.BackColor = Color.FromArgb(250, 146, 186);
            btnAgregarServicio.FlatStyle = FlatStyle.Popup;
            btnAgregarServicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnAgregarServicio.ForeColor = Color.White;
            btnAgregarServicio.Location = new Point(437, 76);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(90, 27);
            btnAgregarServicio.TabIndex = 14;
            btnAgregarServicio.Text = "Agregar";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // lblCantidadServicio
            // 
            lblCantidadServicio.Anchor = AnchorStyles.Right;
            lblCantidadServicio.AutoSize = true;
            lblCantidadServicio.Font = new Font("Impact", 13F);
            lblCantidadServicio.ForeColor = Color.FromArgb(250, 146, 186);
            lblCantidadServicio.Location = new Point(166, 138);
            lblCantidadServicio.Name = "lblCantidadServicio";
            lblCantidadServicio.Size = new Size(75, 22);
            lblCantidadServicio.TabIndex = 14;
            lblCantidadServicio.Text = "Cantidad";
            // 
            // autoNombreServicio
            // 
            autoNombreServicio.AutoSize = true;
            autoNombreServicio.Font = new Font("Microsoft Sans Serif", 11.25F);
            autoNombreServicio.ForeColor = Color.FromArgb(22, 97, 58);
            autoNombreServicio.Location = new Point(242, 76);
            autoNombreServicio.Name = "autoNombreServicio";
            autoNombreServicio.Size = new Size(69, 18);
            autoNombreServicio.TabIndex = 13;
            autoNombreServicio.Text = "Manicura";
            // 
            // lblNombreServicio
            // 
            lblNombreServicio.Anchor = AnchorStyles.Right;
            lblNombreServicio.AutoSize = true;
            lblNombreServicio.Font = new Font("Impact", 13F);
            lblNombreServicio.ForeColor = Color.FromArgb(250, 146, 186);
            lblNombreServicio.Location = new Point(166, 74);
            lblNombreServicio.Name = "lblNombreServicio";
            lblNombreServicio.Size = new Size(66, 22);
            lblNombreServicio.TabIndex = 12;
            lblNombreServicio.Text = "Nombre";
            // 
            // lblDigito1
            // 
            lblDigito1.AutoSize = true;
            lblDigito1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigito1.ForeColor = Color.FromArgb(22, 97, 58);
            lblDigito1.Location = new Point(229, 108);
            lblDigito1.Name = "lblDigito1";
            lblDigito1.Size = new Size(16, 18);
            lblDigito1.TabIndex = 11;
            lblDigito1.Text = "$";
            // 
            // autoPrecioServicio
            // 
            autoPrecioServicio.AutoSize = true;
            autoPrecioServicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoPrecioServicio.ForeColor = Color.FromArgb(22, 97, 58);
            autoPrecioServicio.Location = new Point(242, 108);
            autoPrecioServicio.Name = "autoPrecioServicio";
            autoPrecioServicio.Size = new Size(13, 18);
            autoPrecioServicio.TabIndex = 10;
            autoPrecioServicio.Text = "-";
            autoPrecioServicio.Click += autoPrecioServicio_Click;
            // 
            // lblPrecioServicio
            // 
            lblPrecioServicio.Anchor = AnchorStyles.Right;
            lblPrecioServicio.AutoSize = true;
            lblPrecioServicio.Font = new Font("Impact", 13F);
            lblPrecioServicio.ForeColor = Color.FromArgb(250, 146, 186);
            lblPrecioServicio.Location = new Point(166, 106);
            lblPrecioServicio.Name = "lblPrecioServicio";
            lblPrecioServicio.Size = new Size(57, 22);
            lblPrecioServicio.TabIndex = 9;
            lblPrecioServicio.Text = "Precio";
            // 
            // lblServicioFactura
            // 
            lblServicioFactura.Anchor = AnchorStyles.Right;
            lblServicioFactura.AutoSize = true;
            lblServicioFactura.Font = new Font("Impact", 13F);
            lblServicioFactura.ForeColor = Color.FromArgb(250, 146, 186);
            lblServicioFactura.Location = new Point(166, 41);
            lblServicioFactura.Name = "lblServicioFactura";
            lblServicioFactura.Size = new Size(69, 22);
            lblServicioFactura.TabIndex = 7;
            lblServicioFactura.Text = "Servicio";
            lblServicioFactura.Click += lblServicioFactura_Click;
            // 
            // cmbServicio_fa
            // 
            cmbServicio_fa.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            cmbServicio_fa.ForeColor = Color.FromArgb(22, 97, 58);
            cmbServicio_fa.FormattingEnabled = true;
            cmbServicio_fa.Location = new Point(241, 37);
            cmbServicio_fa.Name = "cmbServicio_fa";
            cmbServicio_fa.Size = new Size(203, 26);
            cmbServicio_fa.TabIndex = 8;
            cmbServicio_fa.SelectedIndexChanged += cmbServicio_fa_SelectedIndexChanged;
            // 
            // tabGestionarFacturas
            // 
            tabGestionarFacturas.Controls.Add(dgvGestionarFacturas);
            tabGestionarFacturas.Location = new Point(4, 27);
            tabGestionarFacturas.Name = "tabGestionarFacturas";
            tabGestionarFacturas.Padding = new Padding(3);
            tabGestionarFacturas.Size = new Size(779, 519);
            tabGestionarFacturas.TabIndex = 1;
            tabGestionarFacturas.Text = "Gestionar Facturas";
            tabGestionarFacturas.UseVisualStyleBackColor = true;
            // 
            // dgvGestionarFacturas
            // 
            dgvGestionarFacturas.AllowUserToAddRows = false;
            dgvGestionarFacturas.AllowUserToDeleteRows = false;
            dgvGestionarFacturas.AllowUserToResizeColumns = false;
            dgvGestionarFacturas.AllowUserToResizeRows = false;
            dgvGestionarFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvGestionarFacturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Impact", 10F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGestionarFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionarFacturas.ColumnHeadersHeight = 30;
            dgvGestionarFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGestionarFacturas.Columns.AddRange(new DataGridViewColumn[] { NumeroFactura, Cliente, Fecha, Total, iconVerDetallesFactura, iconEditar, iconEliminarFactura });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGestionarFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGestionarFacturas.EnableHeadersVisualStyles = false;
            dgvGestionarFacturas.Location = new Point(8, 6);
            dgvGestionarFacturas.Name = "dgvGestionarFacturas";
            dgvGestionarFacturas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Impact", 11.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGestionarFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGestionarFacturas.RowHeadersVisible = false;
            dgvGestionarFacturas.Size = new Size(765, 505);
            dgvGestionarFacturas.TabIndex = 0;
            dgvGestionarFacturas.CellContentClick += dgvGestionarFacturas_CellContentClick;
            // 
            // NumeroFactura
            // 
            NumeroFactura.FillWeight = 355.223877F;
            NumeroFactura.HeaderText = "Numero de Factura";
            NumeroFactura.Name = "NumeroFactura";
            NumeroFactura.ReadOnly = true;
            NumeroFactura.Resizable = DataGridViewTriState.True;
            NumeroFactura.Width = 136;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cliente.FillWeight = 14.925374F;
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.FillWeight = 14.925374F;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 65;
            // 
            // Total
            // 
            Total.FillWeight = 14.925374F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 59;
            // 
            // iconVerDetallesFactura
            // 
            iconVerDetallesFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            iconVerDetallesFactura.FillWeight = 20F;
            iconVerDetallesFactura.HeaderText = "";
            iconVerDetallesFactura.Image = (Image)resources.GetObject("iconVerDetallesFactura.Image");
            iconVerDetallesFactura.ImageLayout = DataGridViewImageCellLayout.Zoom;
            iconVerDetallesFactura.Name = "iconVerDetallesFactura";
            iconVerDetallesFactura.ReadOnly = true;
            iconVerDetallesFactura.Width = 5;
            // 
            // iconEditar
            // 
            iconEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            iconEditar.HeaderText = "";
            iconEditar.Image = (Image)resources.GetObject("iconEditar.Image");
            iconEditar.Name = "iconEditar";
            iconEditar.ReadOnly = true;
            iconEditar.Width = 5;
            // 
            // iconEliminarFactura
            // 
            iconEliminarFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            iconEliminarFactura.HeaderText = "";
            iconEliminarFactura.Image = (Image)resources.GetObject("iconEliminarFactura.Image");
            iconEliminarFactura.Name = "iconEliminarFactura";
            iconEliminarFactura.ReadOnly = true;
            iconEliminarFactura.Width = 5;
            // 
            // FacturasForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(787, 550);
            Controls.Add(tabctrlFacturas);
            Name = "FacturasForm";
            Text = "Facturas";
            Load += FacturasForm_Load;
            tabctrlFacturas.ResumeLayout(false);
            tabCrearFactura.ResumeLayout(false);
            panel1.ResumeLayout(false);
            innerPanelCrearFactura.ResumeLayout(false);
            innerPanelCrearFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecuentoServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadServicio).EndInit();
            tabGestionarFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGestionarFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabctrlFacturas;
        private TabPage tabCrearFactura;
        private TabPage tabGestionarFacturas;
        private Panel panel1;
        private Label lblServicioFactura;
        private Button btnAgregarServicio;
        private Button btnEliminarServicio;
        private ComboBox cmbServicio_fa;
        private Label lblPrecioServicio;
        private Panel innerPanelCrearFactura;
        private Label lblDigito1;
        private Label autoPrecioServicio;
        private Label autoNombreServicio;
        private Label lblNombreServicio;
        private NumericUpDown numCantidadServicio;
        private Label lblCantidadServicio;
        private DataGridView dgvRecuentoServicios;
        private Label autoDevuelta;
        private Label lblDevuelta;
        private TextBox txtEfectivo;
        private Label lblEfectivo;
        private Label autoTotal;
        private Label lblTotal;
        private ComboBox cmbCliente_fa;
        private Label lblClienteFactura;
        private Button btnGuardarFac;
        private Button Cancelar;
        private DataGridView dgvGestionarFacturas;
        private DataGridViewTextBoxColumn nombreServicio;
        private DataGridViewTextBoxColumn cantidadServicio;
        private DataGridViewTextBoxColumn subtotalServicio;
        private DataGridViewTextBoxColumn totalServicio;
        private DataGridViewTextBoxColumn NumeroFactura;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewImageColumn iconVerDetallesFactura;
        private DataGridViewImageColumn iconEditar;
        private DataGridViewImageColumn iconEliminarFactura;
    }
}