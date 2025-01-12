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
            tabctrlClientes = new TabControl();
            tabRegistrarCliente = new TabPage();
            MainPanel = new Panel();
            btnRegistrarCliente = new Button();
            btnCancelarRegistro = new Button();
            panelForm = new Panel();
            panelServiciosPref = new Panel();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lblServiciosPrefCliente = new Label();
            textBox2 = new TextBox();
            lblDireccionCliente = new Label();
            textBox1 = new TextBox();
            lblTelefonoCliente = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            panelPic = new Panel();
            picCliente = new PictureBox();
            tabTodosLosClientes = new TabPage();
            button3 = new Button();
            button1 = new Button();
            dgvClientes = new DataGridView();
            tabctrlClientes.SuspendLayout();
            tabRegistrarCliente.SuspendLayout();
            MainPanel.SuspendLayout();
            panelForm.SuspendLayout();
            panelServiciosPref.SuspendLayout();
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
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.None;
            panelForm.BackColor = Color.FromArgb(22, 97, 58);
            panelForm.Controls.Add(panelServiciosPref);
            panelForm.Controls.Add(lblServiciosPrefCliente);
            panelForm.Controls.Add(textBox2);
            panelForm.Controls.Add(lblDireccionCliente);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(lblTelefonoCliente);
            panelForm.Controls.Add(txtNombreCliente);
            panelForm.Controls.Add(lblNombreCliente);
            panelForm.Location = new Point(32, 36);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(475, 429);
            panelForm.TabIndex = 0;
            // 
            // panelServiciosPref
            // 
            panelServiciosPref.Controls.Add(checkBox8);
            panelServiciosPref.Controls.Add(checkBox7);
            panelServiciosPref.Controls.Add(checkBox6);
            panelServiciosPref.Controls.Add(checkBox5);
            panelServiciosPref.Controls.Add(checkBox4);
            panelServiciosPref.Controls.Add(checkBox3);
            panelServiciosPref.Controls.Add(checkBox2);
            panelServiciosPref.Controls.Add(checkBox1);
            panelServiciosPref.Dock = DockStyle.Bottom;
            panelServiciosPref.Location = new Point(0, 329);
            panelServiciosPref.Name = "panelServiciosPref";
            panelServiciosPref.Size = new Size(475, 100);
            panelServiciosPref.TabIndex = 13;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(260, 41);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(73, 23);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Rubber";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Impact", 10F);
            checkBox7.Location = new Point(362, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(113, 22);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Limpieza Facial";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(260, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(74, 23);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Acrilico";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(362, 41);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(54, 23);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Otro";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(26, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(87, 23);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Manicura";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(128, 41);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(126, 23);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Pintura Regular";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(128, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 23);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Pintura Gel";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Pedicura";
            checkBox1.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBox1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(213, 70, 189);
            textBox2.Location = new Point(98, 236);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 37);
            textBox2.TabIndex = 11;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(213, 70, 189);
            textBox1.Location = new Point(98, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 37);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
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
            tabTodosLosClientes.Controls.Add(button3);
            tabTodosLosClientes.Controls.Add(button1);
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
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(250, 146, 186);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 479);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 15;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(250, 146, 186);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(684, 479);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 13;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(28, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(730, 448);
            dgvClientes.TabIndex = 0;
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
            tabctrlClientes.ResumeLayout(false);
            tabRegistrarCliente.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelServiciosPref.ResumeLayout(false);
            panelServiciosPref.PerformLayout();
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
        private TextBox textBox1;
        private Label lblTelefonoCliente;
        private TextBox textBox2;
        private Label lblDireccionCliente;
        private Panel panelServiciosPref;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label lblServiciosPrefCliente;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Button btnCancelarRegistro;
        private Button btnRegistrarCliente;
        private Button button3;
        private Button button1;
        private DataGridView dgvClientes;
    }
}