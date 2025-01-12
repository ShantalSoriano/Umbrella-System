using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Umbrella_System
{
    public partial class HomeForm : Form
    {
        //Campos para mostrar una barra al presionar cada icono
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public HomeForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            sideBarPanel.Controls.Add(leftBorderBtn);

            // Eliminar la barra (borde) del formulario

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
        }

        // color de los botones (structura)

        private struct RGBColors
        {
            public static Color colorPressing = Color.FromArgb(250, 146, 186);
        }



        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Boton

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(250, 146, 186);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icono actual del formulario
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(22, 97, 58);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(250, 146, 186);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Close the currently open form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void iconClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorPressing);
            OpenChildForm(new ClientesForm());
        }

        private void iconInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorPressing);
            OpenChildForm(new InventarioForm());
        }

        private void iconFacturas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorPressing);
            OpenChildForm(new FacturasForm());
        }

        private void iconLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorPressing);
        }

        private void logoUmbrella_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(250, 146, 186);
        }


        // Mover el formulario sin bordes 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
