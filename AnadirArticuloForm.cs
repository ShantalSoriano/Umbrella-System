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
    public partial class AnadirArticuloForm : Form
    {
        private InventarioForm inventarioForm;

        public AnadirArticuloForm()
        {
            InitializeComponent();

            // Eliminar la barra (borde) del formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public AnadirArticuloForm(InventarioForm inventarioForm)
        {
            InitializeComponent();

            // Eliminar la barra (borde) del formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.inventarioForm = inventarioForm;
        }

        // Mover el formulario sin bordes 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCancelarArticulo_aa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnadirArticuloForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener los tipos de artículos usando el procedimiento almacenado
                List<TipoArticulo> tiposArticulos = ArticuloRepository.ObtenerTiposArticulo();

                // Llenar el ComboBox con los datos obtenidos
                cmbTipoArticulo_aa.DataSource = tiposArticulos;
                cmbTipoArticulo_aa.ValueMember = "IdTipoArticulo";  // El valor que se enviará
                cmbTipoArticulo_aa.DisplayMember = "NombreTipo";  // Lo que verá el usuario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tipos de artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelAnadirArticulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnadirArticulo_aa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreArticulo_aa.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoArticulo_aa.Text) ||
                string.IsNullOrWhiteSpace(txtUnidadMedida_aa.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo articulo = new Articulo();
            articulo.nombreArticulo = txtNombreArticulo_aa.Text;
            articulo.cantidadArticulo = Convert.ToInt32(numCantidadArticulo_aa.Text);
            articulo.fechaAdquiArticulo = dtpFechaAdquisicion_aa.Value;
            articulo.fechaVenciArticulo = dtpFechaVencimiento_aa.Value;
            articulo.UnidadMedidaArticulo = txtUnidadMedida_aa.Text;
            articulo.descripcionArticulo = txtDescripArticulo_aa.Text;

            int result = ArticuloRepository.AddArticulo(articulo);

            if (result > 0)
            {
                MessageBox.Show("Artículo añadido correctamente");
                inventarioForm.CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo añadir el artículo");
            }

            this.Close();
            
        }
    }
}
