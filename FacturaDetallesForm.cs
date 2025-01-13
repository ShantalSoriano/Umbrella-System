using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella_System
{
    public partial class FacturaDetallesForm : Form
    {
        public FacturaDetallesForm()
        {
            InitializeComponent();

            // Eliminar la barra (borde) del formulario

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // sample
            dgvDetalleFactura.Rows.Add("Manicura", "3", "100");
            dgvDetalleFactura.Rows.Add("Pedicura", "2", "150");
        }

        // Mover el formulario sin bordes 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FacturaDetallesForm_Load(object sender, EventArgs e)
        {

        }

        private void titleBarDetalleFactura_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
