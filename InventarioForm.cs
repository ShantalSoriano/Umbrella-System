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
            

            AnadirArticuloForm anadirArticuloForm = new AnadirArticuloForm();
            anadirArticuloForm.ShowDialog();
            
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = ArticuloRepository.ObtenerTodos();
            CargarDatos();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgvInventario.DataSource = ArticuloRepository.ObtenerTodos();
        }

        public void CargarDatos()
        {
            try
            {
                // Obtén la lista de artículos desde la base de datos
                List<Articulo> listaArticulos = ArticuloRepository.ObtenerTodos();

                // Asigna la lista al DataGridView
                dgvInventario.DataSource = listaArticulos;

                // Ajusta los valores nulos en las columnas de fechas
                foreach (DataGridViewRow row in dgvInventario.Rows)
                {
                    if (row.Cells["fechaAdquiArticulo"].Value == null || row.Cells["fechaAdquiArticulo"].Value == DBNull.Value)
                    {
                        row.Cells["fechaAdquiArticulo"].Value = "Sin fecha";
                    }
                    if (row.Cells["fechaVenciArticulo"].Value == null || row.Cells["fechaVenciArticulo"].Value == DBNull.Value)
                    {
                        row.Cells["fechaVenciArticulo"].Value = "Sin fecha";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
