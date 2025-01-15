using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella_System
{
    public partial class InventarioForm : Form
    {
        private int? articuloIdSeleccionado = null;  // Variable para almacenar el ID del artículo seleccionado

        public InventarioForm()
        {
            InitializeComponent();
        }

        private void btnAnadirInventario_Click(object sender, EventArgs e)
        {
            AnadirArticuloForm anadirArticuloForm = new AnadirArticuloForm(this);
            anadirArticuloForm.ShowDialog();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            // Cargar los artículos desde la base de datos y asignarlos al DataGridView
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            // Obtener los artículos desde el repositorio y asignarlos al DataGridView
            var articulos = ArticuloRepository.ObtenerTodos();
            dgvInventario.DataSource = articulos;
        }

        // Método para actualizar la tabla después de añadir un nuevo artículo
        public void CargarArticulos()
        {
            // Después de añadir el artículo, actualizar el DataGridView
            ActualizarTabla();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar eventos relacionados con el clic en las celdas, si es necesario
        }

        private void btnModificarArticuloInventario_Click(object sender, EventArgs e)
        {
            if (articuloIdSeleccionado != null)
            {
                Articulo articulo = ArticuloRepository.ObtenerPorId(articuloIdSeleccionado.Value);

                AnadirArticuloForm anadirArticuloForm = new AnadirArticuloForm(this, articulo);
                anadirArticuloForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el ID del artículo seleccionado
                articuloIdSeleccionado = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["idArticulo"].Value);
            }
        }

        private void btnEliminarArticuloInventario_Click(object sender, EventArgs e)
        {
            if (articuloIdSeleccionado != null)
            {
                // Mostrar mensaje de confirmación
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este artículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Intentar eliminar el artículo
                    int filasAfectadas = ArticuloRepository.EliminarArticulo(articuloIdSeleccionado.Value);

                    if (filasAfectadas > 0)
                    {
                        // El artículo fue eliminado correctamente, actualizar el DataGridView
                        MessageBox.Show("Artículo eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescar el DataGridView para reflejar la eliminación
                        ActualizarTabla();
                        CargarArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
