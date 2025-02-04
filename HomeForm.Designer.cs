﻿namespace Umbrella_System
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
            titleBarHome = new Panel();
            panelControlsTitleBar = new Panel();
            btnMinimize = new PictureBox();
            btnMaximize = new PictureBox();
            btnClose = new PictureBox();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            sideBarPanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoUmbrella).BeginInit();
            titleBarHome.SuspendLayout();
            panelControlsTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            iconFacturas.Anchor = AnchorStyles.None;
            iconFacturas.FlatAppearance.BorderSize = 0;
            iconFacturas.FlatStyle = FlatStyle.Flat;
            iconFacturas.ForeColor = Color.White;
            iconFacturas.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconFacturas.IconColor = Color.FromArgb(250, 146, 186);
            iconFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFacturas.IconSize = 33;
            iconFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            iconFacturas.Location = new Point(0, 298);
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
            iconInventario.Anchor = AnchorStyles.None;
            iconInventario.FlatAppearance.BorderSize = 0;
            iconInventario.FlatStyle = FlatStyle.Flat;
            iconInventario.ForeColor = Color.White;
            iconInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconInventario.IconColor = Color.FromArgb(250, 146, 186);
            iconInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInventario.IconSize = 38;
            iconInventario.ImageAlign = ContentAlignment.MiddleLeft;
            iconInventario.Location = new Point(0, 215);
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
            iconClientes.Anchor = AnchorStyles.None;
            iconClientes.FlatAppearance.BorderSize = 0;
            iconClientes.FlatStyle = FlatStyle.Flat;
            iconClientes.ForeColor = Color.White;
            iconClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconClientes.IconColor = Color.FromArgb(250, 146, 186);
            iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClientes.IconSize = 40;
            iconClientes.ImageAlign = ContentAlignment.MiddleLeft;
            iconClientes.Location = new Point(0, 138);
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
            panelLogo.Paint += panelLogo_Paint;
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
            // titleBarHome
            // 
            titleBarHome.BackColor = Color.White;
            titleBarHome.Controls.Add(panelControlsTitleBar);
            titleBarHome.Controls.Add(iconCurrentChildForm);
            titleBarHome.Dock = DockStyle.Top;
            titleBarHome.Location = new Point(181, 0);
            titleBarHome.Name = "titleBarHome";
            titleBarHome.Size = new Size(803, 42);
            titleBarHome.TabIndex = 2;
            titleBarHome.Paint += titleBarHome_Paint;
            titleBarHome.MouseDown += titleBarHome_MouseDown;
            // 
            // panelControlsTitleBar
            // 
            panelControlsTitleBar.Controls.Add(btnMinimize);
            panelControlsTitleBar.Controls.Add(btnMaximize);
            panelControlsTitleBar.Controls.Add(btnClose);
            panelControlsTitleBar.Dock = DockStyle.Right;
            panelControlsTitleBar.Location = new Point(700, 0);
            panelControlsTitleBar.Name = "panelControlsTitleBar";
            panelControlsTitleBar.Size = new Size(103, 42);
            panelControlsTitleBar.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(3, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(0, 0, 20, 0);
            btnMinimize.Size = new Size(26, 26);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(34, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Padding = new Padding(0, 0, 20, 0);
            btnMaximize.Size = new Size(27, 20);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 1;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(67, 12);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 0, 20, 0);
            btnClose.Size = new Size(24, 20);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.Anchor = AnchorStyles.None;
            iconCurrentChildForm.BackColor = Color.White;
            iconCurrentChildForm.ForeColor = Color.FromArgb(250, 146, 186);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(250, 146, 186);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 28;
            iconCurrentChildForm.Location = new Point(367, 12);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(28, 28);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(181, 42);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(803, 589);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 631);
            Controls.Add(panelDesktop);
            Controls.Add(titleBarHome);
            Controls.Add(sideBarPanel);
            Controls.Add(panel1);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += HomeForm_Load;
            sideBarPanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoUmbrella).EndInit();
            titleBarHome.ResumeLayout(false);
            panelControlsTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel titleBarHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Panel panelControlsTitleBar;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
    }
}