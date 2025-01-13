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
            btnEliminarArticuloInventario.Location = new Point(9, 490);
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
            btnNuevoArticuloInventario.Location = new Point(687, 490);
            btnNuevoArticuloInventario.Name = "btnNuevoArticuloInventario";
            btnNuevoArticuloInventario.Size = new Size(90, 27);
            btnNuevoArticuloInventario.TabIndex = 17;
            btnNuevoArticuloInventario.Text = "Nuevo";
            btnNuevoArticuloInventario.UseVisualStyleBackColor = false;
            btnNuevoArticuloInventario.Click += btnAnadirInventario_Click;
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
            // btnModificarArticuloInventario
            // 
            btnModificarArticuloInventario.Anchor = AnchorStyles.None;
            btnModificarArticuloInventario.BackColor = Color.FromArgb(250, 146, 186);
            btnModificarArticuloInventario.FlatStyle = FlatStyle.Popup;
            btnModificarArticuloInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnModificarArticuloInventario.ForeColor = Color.White;
            btnModificarArticuloInventario.Location = new Point(591, 490);
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