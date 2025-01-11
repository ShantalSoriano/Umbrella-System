namespace Umbrella_System
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            sideBarPanel = new Panel();
            iconLogout = new FontAwesome.Sharp.IconButton();
            iconFacturas = new FontAwesome.Sharp.IconButton();
            iconInventario = new FontAwesome.Sharp.IconButton();
            iconClientes = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            logoUmbrella = new PictureBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            sideBarPanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoUmbrella).BeginInit();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // panel1
            // 
            panel1.Location = new Point(130, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.FromArgb(22, 97, 58);
            sideBarPanel.Controls.Add(iconLogout);
            sideBarPanel.Controls.Add(iconFacturas);
            sideBarPanel.Controls.Add(iconInventario);
            sideBarPanel.Controls.Add(iconClientes);
            sideBarPanel.Controls.Add(panelLogo);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(181, 631);
            sideBarPanel.TabIndex = 1;
            // 
            // iconLogout
            // 
            iconLogout.Dock = DockStyle.Bottom;
            iconLogout.FlatAppearance.BorderSize = 0;
            iconLogout.FlatStyle = FlatStyle.Flat;
            iconLogout.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconLogout.ForeColor = Color.White;
            iconLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconLogout.IconColor = Color.FromArgb(250, 146, 186);
            iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLogout.IconSize = 38;
            iconLogout.Location = new Point(0, 571);
            iconLogout.Margin = new Padding(3, 50, 3, 50);
            iconLogout.Name = "iconLogout";
            iconLogout.Padding = new Padding(10, 0, 20, 0);
            iconLogout.Size = new Size(181, 60);
            iconLogout.TabIndex = 4;
            iconLogout.Text = "Logout";
            iconLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconLogout.UseVisualStyleBackColor = true;
            iconLogout.Click += iconLogout_Click;
            // 
            // iconFacturas
            // 
            iconFacturas.Dock = DockStyle.Top;
            iconFacturas.FlatAppearance.BorderSize = 0;
            iconFacturas.FlatStyle = FlatStyle.Flat;
            iconFacturas.ForeColor = Color.White;
            iconFacturas.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconFacturas.IconColor = Color.FromArgb(250, 146, 186);
            iconFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFacturas.IconSize = 33;
            iconFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            iconFacturas.Location = new Point(0, 162);
            iconFacturas.Margin = new Padding(3, 50, 3, 50);
            iconFacturas.Name = "iconFacturas";
            iconFacturas.Padding = new Padding(10, 0, 20, 0);
            iconFacturas.Size = new Size(181, 60);
            iconFacturas.TabIndex = 3;
            iconFacturas.Text = "Facturas";
            iconFacturas.TextAlign = ContentAlignment.MiddleLeft;
            iconFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconFacturas.UseVisualStyleBackColor = true;
            iconFacturas.Click += iconFacturas_Click;
            // 
            // iconInventario
            // 
            iconInventario.Dock = DockStyle.Top;
            iconInventario.FlatAppearance.BorderSize = 0;
            iconInventario.FlatStyle = FlatStyle.Flat;
            iconInventario.ForeColor = Color.White;
            iconInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconInventario.IconColor = Color.FromArgb(250, 146, 186);
            iconInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInventario.IconSize = 38;
            iconInventario.ImageAlign = ContentAlignment.MiddleLeft;
            iconInventario.Location = new Point(0, 102);
            iconInventario.Margin = new Padding(3, 50, 3, 50);
            iconInventario.Name = "iconInventario";
            iconInventario.Padding = new Padding(10, 0, 20, 0);
            iconInventario.Size = new Size(181, 60);
            iconInventario.TabIndex = 2;
            iconInventario.Text = "Inventario";
            iconInventario.TextAlign = ContentAlignment.MiddleLeft;
            iconInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconInventario.UseVisualStyleBackColor = true;
            iconInventario.Click += iconInventario_Click;
            // 
            // iconClientes
            // 
            iconClientes.Dock = DockStyle.Top;
            iconClientes.FlatAppearance.BorderSize = 0;
            iconClientes.FlatStyle = FlatStyle.Flat;
            iconClientes.ForeColor = Color.White;
            iconClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconClientes.IconColor = Color.FromArgb(250, 146, 186);
            iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClientes.IconSize = 40;
            iconClientes.ImageAlign = ContentAlignment.MiddleLeft;
            iconClientes.Location = new Point(0, 42);
            iconClientes.Margin = new Padding(3, 50, 3, 50);
            iconClientes.Name = "iconClientes";
            iconClientes.Padding = new Padding(10, 0, 20, 0);
            iconClientes.Size = new Size(181, 60);
            iconClientes.TabIndex = 1;
            iconClientes.Text = "Clientes";
            iconClientes.TextAlign = ContentAlignment.MiddleLeft;
            iconClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconClientes.UseVisualStyleBackColor = true;
            iconClientes.Click += iconClientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.White;
            panelLogo.Controls.Add(logoUmbrella);
            panelLogo.Controls.Add(iconButton2);
            panelLogo.Controls.Add(iconButton1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(181, 42);
            panelLogo.TabIndex = 0;
            // 
            // logoUmbrella
            // 
            logoUmbrella.BackColor = Color.White;
            logoUmbrella.Image = (Image)resources.GetObject("logoUmbrella.Image");
            logoUmbrella.Location = new Point(3, 0);
            logoUmbrella.Name = "logoUmbrella";
            logoUmbrella.Size = new Size(153, 42);
            logoUmbrella.SizeMode = PictureBoxSizeMode.Zoom;
            logoUmbrella.TabIndex = 2;
            logoUmbrella.TabStop = false;
            logoUmbrella.Click += logoUmbrella_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(49, 29);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(0, 0);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(55, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(0, 0);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 631);
            Controls.Add(sideBarPanel);
            Controls.Add(panel1);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umbrella System";
            sideBarPanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoUmbrella).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panel1;
        private Panel sideBarPanel;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconClientes;
        private FontAwesome.Sharp.IconButton iconLogout;
        private FontAwesome.Sharp.IconButton iconFacturas;
        private FontAwesome.Sharp.IconButton iconInventario;
        private PictureBox logoUmbrella;
    }
}