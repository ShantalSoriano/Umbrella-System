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
            btnEliminarInventario = new Button();
            btnAnadirInventario = new Button();
            dgvInventario = new DataGridView();
            btnModificarInventario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarInventario
            // 
            btnEliminarInventario.Anchor = AnchorStyles.None;
            btnEliminarInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnEliminarInventario.FlatStyle = FlatStyle.Popup;
            btnEliminarInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEliminarInventario.ForeColor = Color.White;
            btnEliminarInventario.Location = new Point(9, 490);
            btnEliminarInventario.Name = "btnEliminarInventario";
            btnEliminarInventario.Size = new Size(90, 27);
            btnEliminarInventario.TabIndex = 18;
            btnEliminarInventario.Text = "Eliminar";
            btnEliminarInventario.UseVisualStyleBackColor = false;
            // 
            // btnAnadirInventario
            // 
            btnAnadirInventario.Anchor = AnchorStyles.None;
            btnAnadirInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnAnadirInventario.FlatStyle = FlatStyle.Popup;
            btnAnadirInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnAnadirInventario.ForeColor = Color.White;
            btnAnadirInventario.Location = new Point(687, 490);
            btnAnadirInventario.Name = "btnAnadirInventario";
            btnAnadirInventario.Size = new Size(90, 27);
            btnAnadirInventario.TabIndex = 17;
            btnAnadirInventario.Text = "Anadir";
            btnAnadirInventario.UseVisualStyleBackColor = false;
            // 
            // dgvInventario
            // 
            dgvInventario.Anchor = AnchorStyles.None;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(31, 33);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(730, 448);
            dgvInventario.TabIndex = 16;
            // 
            // btnModificarInventario
            // 
            btnModificarInventario.Anchor = AnchorStyles.None;
            btnModificarInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnModificarInventario.FlatStyle = FlatStyle.Popup;
            btnModificarInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModificarInventario.ForeColor = Color.White;
            btnModificarInventario.Location = new Point(591, 490);
            btnModificarInventario.Name = "btnModificarInventario";
            btnModificarInventario.Size = new Size(90, 27);
            btnModificarInventario.TabIndex = 19;
            btnModificarInventario.Text = "Modificar";
            btnModificarInventario.UseVisualStyleBackColor = false;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(787, 550);
            Controls.Add(btnModificarInventario);
            Controls.Add(btnEliminarInventario);
            Controls.Add(btnAnadirInventario);
            Controls.Add(dgvInventario);
            Name = "InventarioForm";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminarInventario;
        private Button btnAnadirInventario;
        private DataGridView dgvInventario;
        private Button btnModificarInventario;
    }
}