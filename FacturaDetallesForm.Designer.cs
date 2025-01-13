namespace Umbrella_System
{
    partial class FacturaDetallesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaDetallesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            titleBarDetalleFactura = new Panel();
            panelControlsTitleBar = new Panel();
            btnMinimize2 = new PictureBox();
            btnClose2 = new PictureBox();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            dgvDetalleFactura = new DataGridView();
            detalleServicio = new DataGridViewTextBoxColumn();
            detalleCantidad = new DataGridViewTextBoxColumn();
            detallePrecioUnitario = new DataGridViewTextBoxColumn();
            titleBarDetalleFactura.SuspendLayout();
            panelControlsTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // titleBarDetalleFactura
            // 
            titleBarDetalleFactura.BackColor = Color.OldLace;
            titleBarDetalleFactura.Controls.Add(panelControlsTitleBar);
            titleBarDetalleFactura.Dock = DockStyle.Top;
            titleBarDetalleFactura.Location = new Point(0, 0);
            titleBarDetalleFactura.Name = "titleBarDetalleFactura";
            titleBarDetalleFactura.Size = new Size(593, 25);
            titleBarDetalleFactura.TabIndex = 22;
            titleBarDetalleFactura.MouseDown += titleBarDetalleFactura_MouseDown;
            // 
            // panelControlsTitleBar
            // 
            panelControlsTitleBar.Controls.Add(btnMinimize2);
            panelControlsTitleBar.Controls.Add(btnClose2);
            panelControlsTitleBar.Controls.Add(btnMinimize);
            panelControlsTitleBar.Controls.Add(btnClose);
            panelControlsTitleBar.Dock = DockStyle.Right;
            panelControlsTitleBar.Location = new Point(533, 0);
            panelControlsTitleBar.Name = "panelControlsTitleBar";
            panelControlsTitleBar.Size = new Size(60, 25);
            panelControlsTitleBar.TabIndex = 2;
            // 
            // btnMinimize2
            // 
            btnMinimize2.Anchor = AnchorStyles.None;
            btnMinimize2.Image = (Image)resources.GetObject("btnMinimize2.Image");
            btnMinimize2.Location = new Point(6, -8);
            btnMinimize2.Name = "btnMinimize2";
            btnMinimize2.Padding = new Padding(0, 0, 20, 0);
            btnMinimize2.Size = new Size(26, 26);
            btnMinimize2.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize2.TabIndex = 4;
            btnMinimize2.TabStop = false;
            btnMinimize2.Click += btnMinimize2_Click;
            // 
            // btnClose2
            // 
            btnClose2.Anchor = AnchorStyles.None;
            btnClose2.Image = (Image)resources.GetObject("btnClose2.Image");
            btnClose2.Location = new Point(33, 2);
            btnClose2.Name = "btnClose2";
            btnClose2.Padding = new Padding(0, 0, 20, 0);
            btnClose2.Size = new Size(24, 20);
            btnClose2.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose2.TabIndex = 3;
            btnClose2.TabStop = false;
            btnClose2.Click += btnClose2_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.None;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(-60, -46);
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
            btnClose.Location = new Point(-34, -35);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 0, 20, 0);
            btnClose.Size = new Size(24, 20);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.AllowUserToResizeColumns = false;
            dgvDetalleFactura.AllowUserToResizeRows = false;
            dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDetalleFactura.BackgroundColor = SystemColors.AppWorkspace;
            dgvDetalleFactura.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.ColumnHeadersVisible = false;
            dgvDetalleFactura.Columns.AddRange(new DataGridViewColumn[] { detalleServicio, detalleCantidad, detallePrecioUnitario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleFactura.GridColor = SystemColors.ControlDark;
            dgvDetalleFactura.Location = new Point(12, 67);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleFactura.Size = new Size(569, 299);
            dgvDetalleFactura.TabIndex = 23;
            dgvDetalleFactura.CellContentClick += dgvDetalleFactura_CellContentClick;
            // 
            // detalleServicio
            // 
            detalleServicio.HeaderText = "Servicio";
            detalleServicio.Name = "detalleServicio";
            // 
            // detalleCantidad
            // 
            detalleCantidad.HeaderText = "Cantidad";
            detalleCantidad.Name = "detalleCantidad";
            // 
            // detallePrecioUnitario
            // 
            detallePrecioUnitario.HeaderText = "Precio Unitario";
            detallePrecioUnitario.Name = "detallePrecioUnitario";
            // 
            // FacturaDetallesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 97, 58);
            ClientSize = new Size(593, 437);
            Controls.Add(dgvDetalleFactura);
            Controls.Add(titleBarDetalleFactura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacturaDetallesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FacturaDetallesForm_Load;
            titleBarDetalleFactura.ResumeLayout(false);
            panelControlsTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel titleBarDetalleFactura;
        private Panel panelControlsTitleBar;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private PictureBox btnMinimize2;
        private PictureBox btnClose2;
        private DataGridView dgvDetalleFactura;
        private DataGridViewTextBoxColumn detalleServicio;
        private DataGridViewTextBoxColumn detalleCantidad;
        private DataGridViewTextBoxColumn detallePrecioUnitario;
    }
}