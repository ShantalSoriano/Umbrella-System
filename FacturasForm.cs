using Microsoft.Data.SqlClient;
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

        }

        private void FacturasForm_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarServicios();
        }

        private void CargarClientes()
        {
            string query = "SELECT idCliente, nombreCliente FROM Clientes";
            SqlCommand command = new SqlCommand(query, DBConnection.ObtenerConexion());

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbCliente_fa.DataSource = dt;
            cmbCliente_fa.DisplayMember = "nombreCliente";
            cmbCliente_fa.ValueMember = "idCliente";
        }

        private void CargarServicios()
        {
            string query = "SELECT idServicio, nombreServicio FROM Servicios";
            using (SqlConnection connection = DBConnection.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbServicio_fa.DataSource = dt;
                cmbServicio_fa.DisplayMember = "nombreServicio";
                cmbServicio_fa.ValueMember = "idServicio";
            }
        }






        private void lblServicioFactura_Click(object sender, EventArgs e)
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

        private void cmbCliente_fa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbServicio_fa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio_fa.SelectedItem != null)
            {
                // Obtenemos el DataRowView seleccionado
                DataRowView selectedRow = cmbServicio_fa.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    // Obtenemos el valor del idServicio de la fila seleccionada
                    string selectedServiceId = selectedRow["idServicio"].ToString();

                    // Usamos using para asegurar que la conexión se cierre automáticamente
                    using (SqlConnection connection = DBConnection.ObtenerConexion())
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string query = "SELECT nombreServicio, precioServicio FROM Servicios WHERE idServicio = @idServicio";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idServicio", selectedServiceId);

                        // Ejecutamos la consulta y leemos los resultados
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                autoNombreServicio.Text = reader["nombreServicio"].ToString();
                                autoPrecioServicio.Text = reader["precioServicio"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidadServicio.Value;
            decimal precio = decimal.Parse(autoPrecioServicio.Text);
            decimal subtotal = cantidad * precio;

            dgvRecuentoServicios.Rows.Add(autoNombreServicio.Text, cantidad, subtotal, subtotal);
            ActualizarTotal();
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (dgvRecuentoServicios.SelectedRows.Count > 0)
            {
                dgvRecuentoServicios.Rows.RemoveAt(dgvRecuentoServicios.SelectedRows[0].Index);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvRecuentoServicios.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotalServicio"].Value);
            }
            autoTotal.Text = total.ToString("C2");
        }

    }
}
