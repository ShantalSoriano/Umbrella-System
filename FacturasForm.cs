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
    public partial class FacturasForm : Form
    {
        public FacturasForm()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                dgvGestionarFacturas.Rows.Add(i, "Christina Matos ", "12/07/24 ", "1,200 ");
            }

            for (int i = 0; i < 10; i++)
            {
                dgvRecuentoServicios.Rows.Add("Manicura", "3", "100", "300");
            }
        }

        private void FacturasForm_Load(object sender, EventArgs e)
        {

        }

        private void lblServicioFactura_Click(object sender, EventArgs e)
        {

        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autoPrecioServicio_Click(object sender, EventArgs e)
        {

        }

        private void innerPanelCrearFactura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void autoDevuelta_Click(object sender, EventArgs e)
        {

        }

        private void dgvGestionarFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el índice de la columna corresponde a la columna de la imagen
            if (e.ColumnIndex == dgvGestionarFacturas.Columns["iconVerDetallesFactura"].Index && e.RowIndex >= 0)
            {
                // Abre el formulario de detalles
                FacturaDetallesForm facturaDetallesForm = new FacturaDetallesForm();
                facturaDetallesForm.Show();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
