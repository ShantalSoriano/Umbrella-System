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
        private readonly InventarioForm inventarioForm;

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
            try
            {
                // Crear una instancia de Articulo y asignar los valores del formulario
                Articulo articulo = new Articulo
                {
                    nombreArticulo = txtNombreArticulo_aa.Text,
                    cantidadArticulo = (int)numCantidadArticulo_aa.Value,
                    fechaAdquiArticulo = dtpFechaAdquisicion_aa.Value,
                    fechaVenciArticulo = dtpFechaVencimiento_aa.Value == DateTime.MinValue ? (DateTime?)null : dtpFechaVencimiento_aa.Value,
                    descripcionArticulo = txtDescripArticulo_aa.Text,
                    idTipoArticulo = (int)cmbTipoArticulo_aa.SelectedValue,
                    UnidadMedidaArticulo = txtUnidadMedida_aa.Text
                };

                // Llamar al método AddArticulo para insertar en la base de datos
                int filasAfectadas = ArticuloRepository.AddArticulo(articulo);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El artículo se ha agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Llamar al método para recargar el DataGridView con los datos actualizados
                    inventarioForm.CargarArticulos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpiar o cerrar el formulario según sea necesario
                this.Close();  // O mantener el formulario abierto si deseas agregar más artículos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

