namespace Umbrella_System
{
    partial class InventarioForm
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
            btnEliminarArticuloInventario = new Button();
            btnNuevoArticuloInventario = new Button();
            dgvInventario = new DataGridView();
            btnModificarArticuloInventario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarArticuloInventario
            // 
            btnEliminarArticuloInventario.Anchor = AnchorStyles.None;
            btnEliminarArticuloInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnEliminarArticuloInventario.FlatStyle = FlatStyle.Popup;
            btnEliminarArticuloInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEliminarArticuloInventario.ForeColor = Color.White;
            btnEliminarArticuloInventario.Location = new Point(12, 511);
            btnEliminarArticuloInventario.Name = "btnEliminarArticuloInventario";
            btnEliminarArticuloInventario.Size = new Size(90, 27);
            btnEliminarArticuloInventario.TabIndex = 18;
            btnEliminarArticuloInventario.Text = "Eliminar";
            btnEliminarArticuloInventario.UseVisualStyleBackColor = false;
            // 
            // btnNuevoArticuloInventario
            // 
            btnNuevoArticuloInventario.Anchor = AnchorStyles.None;
            btnNuevoArticuloInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnNuevoArticuloInventario.FlatStyle = FlatStyle.Popup;
            btnNuevoArticuloInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnNuevoArticuloInventario.ForeColor = Color.White;
            btnNuevoArticuloInventario.Location = new Point(687, 511);
            btnNuevoArticuloInventario.Name = "btnNuevoArticuloInventario";
            btnNuevoArticuloInventario.Size = new Size(90, 27);
            btnNuevoArticuloInventario.TabIndex = 17;
            btnNuevoArticuloInventario.Text = "Nuevo";
            btnNuevoArticuloInventario.UseVisualStyleBackColor = false;
            btnNuevoArticuloInventario.Click += btnAnadirInventario_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.None;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvInventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvInventario.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(161, 0, 113);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.Location = new Point(9, 5);
            dgvInventario.Name = "dgvInventario";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 146, 186);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInventario.Size = new Size(768, 500);
            dgvInventario.TabIndex = 16;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // btnModificarArticuloInventario
            // 
            btnModificarArticuloInventario.Anchor = AnchorStyles.None;
            btnModificarArticuloInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnModificarArticuloInventario.FlatStyle = FlatStyle.Popup;
            btnModificarArticuloInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModificarArticuloInventario.ForeColor = Color.White;
            btnModificarArticuloInventario.Location = new Point(591, 511);
            btnModificarArticuloInventario.Name = "btnModificarArticuloInventario";
            btnModificarArticuloInventario.Size = new Size(90, 27);
            btnModificarArticuloInventario.TabIndex = 19;
            btnModificarArticuloInventario.Text = "Modificar";
            btnModificarArticuloInventario.UseVisualStyleBackColor = false;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(787, 550);
            Controls.Add(btnModificarArticuloInventario);
            Controls.Add(btnEliminarArticuloInventario);
            Controls.Add(btnNuevoArticuloInventario);
            Controls.Add(dgvInventario);
            Name = "InventarioForm";
            Text = "Inventario";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminarArticuloInventario;
        private Button btnNuevoArticuloInventario;
        private DataGridView dgvInventario;
        private Button btnModificarArticuloInventario;
    }
}