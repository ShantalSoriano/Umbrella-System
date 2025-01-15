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
    }

}
