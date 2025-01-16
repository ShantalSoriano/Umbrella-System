using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Umbrella_System
{
    public partial class FacturasForm : Form
    {
        private Button Guardar; // Add this line to declare the 'Guardar' button

        public FacturasForm()
        {
            InitializeComponent();
            Guardar = new Button(); // Initialize the 'Guardar' button
            Guardar.Click += new EventHandler(Guardar_Click);
        }

        private void CargarFacturas()
        {
            try
            {
                FacturaRepository repository = new FacturaRepository();
                List<Factura> facturas = repository.ObtenerFacturas();
                dgvGestionarFacturas.DataSource = facturas;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Ocurrió un error al cargar las facturas: " + ex.Message);
            }
        }


        private void FacturasForm_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarServicios();
            CargarFacturasDGV();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvGestionarFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionarFacturas.ReadOnly = false; 
            dgvGestionarFacturas.Enabled = true;
            dgvGestionarFacturas.AllowUserToAddRows = false;
            dgvGestionarFacturas.AllowUserToDeleteRows = true;
        }

        private void CargarFacturasDGV()
        {
            try
            {
                FacturaRepository repository = new FacturaRepository();
                List<Factura> facturas = repository.ObtenerFacturas();

                dgvGestionarFacturas.AutoGenerateColumns = false;
                dgvGestionarFacturas.DataSource = facturas;

                dgvGestionarFacturas.Columns.Clear();

                dgvGestionarFacturas.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdFactura",
                    HeaderText = "Número Factura",
                    Name = "IdFactura"
                });

                dgvGestionarFacturas.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FechaFactura",
                    HeaderText = "Fecha",
                    Name = "Fecha"
                });

                dgvGestionarFacturas.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TotalFactura",
                    HeaderText = "Total",
                    Name = "Total"
                });

                dgvGestionarFacturas.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdCliente",
                    HeaderText = "Cliente",
                    Name = "Cliente"
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las facturas: " + ex.Message);
            }
        }



        private void CargarClientes()
        {
            string query = "SELECT idCliente, nombreCliente FROM Clientes";
            using (SqlConnection connection = DBConnection.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCliente_fa.DataSource = dt;
                cmbCliente_fa.DisplayMember = "nombreCliente";
                cmbCliente_fa.ValueMember = "idCliente";
            }
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


        }

        private void Guardar_Click(object? sender, EventArgs e) // Add nullable reference type for sender
        {
            // Obtener el valor total de la factura y asegurarse de que es válido
            decimal totalFactura;
            string totalFacturaString = autoTotal.Text;

            // Eliminar el símbolo '$' y las comas (si están presentes)
            totalFacturaString = totalFacturaString.Replace("$", "").Replace(",", "");

            // Intentar convertir el valor totalFacturaString a decimal
            if (!decimal.TryParse(totalFacturaString, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out totalFactura))
            {
                MessageBox.Show("El formato del total es incorrecto.");
                return;
            }

            // Crear una nueva instancia de factura
            Factura nuevaFactura = new Factura
            {
                FechaFactura = DateTime.Now,  // Usar la fecha actual o la fecha que el usuario elija
                TotalFactura = totalFactura,  // Asignar el total convertido
                IdCliente = Convert.ToInt32(cmbCliente_fa.SelectedValue)  // ID del cliente seleccionado
            };

            // Crear la factura en la base de datos
            FacturaRepository facturaRepository = new FacturaRepository();
            int idFacturaCreada = facturaRepository.CrearFactura(nuevaFactura);

            // Guardar los servicios asociados a la factura
            foreach (DataGridViewRow row in dgvRecuentoServicios.Rows)
            {
                if (row.IsNewRow) continue;  // Evitar intentar guardar la fila vacía

                // Validar los valores del servicio antes de guardarlos
                if (row.Cells["idServicio"].Value == null ||
                    row.Cells["cantidadServicio"].Value == null ||
                    row.Cells["subtotalServicio"].Value == null)
                {
                    MessageBox.Show("Uno o más valores de los servicios no son válidos.");
                    return;
                }

                int idServicio = Convert.ToInt32(row.Cells["nombreServicio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["cantidadServicio"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["subtotalServicio"].Value);

                // Verificar si los valores son válidos
                if (idServicio <= 0 || cantidad <= 0 || subtotal <= 0)
                {
                    MessageBox.Show("Uno o más valores de los servicios no son válidos.");
                    return;
                }

                // Guardar cada servicio relacionado con la factura
                string queryInsertarServicio = "INSERT INTO DetalleFactura (idFactura, idServicio, cantidadDetalle, subtotalDetalle) " +
                                                "VALUES (@idFactura, @idServicio, @cantidadDetalle, @subtotalDetalle)";

                using (SqlConnection connection = DBConnection.ObtenerConexion())
                {
                    SqlCommand command = new SqlCommand(queryInsertarServicio, connection);
                    command.Parameters.AddWithValue("@idFactura", idFacturaCreada);
                    command.Parameters.AddWithValue("@idServicio", idServicio);
                    command.Parameters.AddWithValue("@cantidadDetalle", cantidad);
                    command.Parameters.AddWithValue("@subtotalDetalle", subtotal);


                    command.ExecuteNonQuery();  // Ejecutar el comando para insertar el servicio
                }
            }

            // Mostrar mensaje de éxito o realizar alguna otra acción
            MessageBox.Show("Factura guardada exitosamente.");
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

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEfectivo.Text, out decimal efectivo))
            {
                if (decimal.TryParse(autoTotal.Text, System.Globalization.NumberStyles.Currency, null, out decimal total))
                {
                    decimal devuelta = efectivo - total;
                    autoDevuelta.Text = devuelta.ToString("C2");
                }
                else
                {
                    // Handle the case where autoTotal.Text is not a valid decimal
                    autoDevuelta.Text = "Invalid total";
                }
            }
        }

        private string GetNombreCliente(int idCliente)
        {
            string nombreCliente = "";

            using (SqlConnection connection = DBConnection.ObtenerConexion())
            {
                string query = "SELECT nombreCliente FROM Clientes WHERE idCliente = @idCliente";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCliente", idCliente);

                nombreCliente = (string)command.ExecuteScalar();
            }

            return nombreCliente;
        }



        private bool ActualizarFactura(int idFactura, DateTime fechaFactura, decimal totalFactura, int idCliente)
        {
            try
            {
                using (SqlConnection connection = DBConnection.ObtenerConexion())
                {
                    string query = "UPDATE Facturas SET FechaFactura = @FechaFactura, TotalFactura = @TotalFactura, IdCliente = @IdCliente WHERE IdFactura = @IdFactura";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdFactura", idFactura);
                    command.Parameters.AddWithValue("@FechaFactura", fechaFactura);
                    command.Parameters.AddWithValue("@TotalFactura", totalFactura);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar la factura: " + ex.Message);
                return false;
            }
        }

        private void btnEliminarFac_Click(object sender, EventArgs e)
        {
            if (dgvGestionarFacturas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvGestionarFacturas.SelectedRows[0];
                int idFactura = Convert.ToInt32(selectedRow.Cells["IdFactura"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar esta factura?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método para eliminar la factura en la base de datos
                    FacturaRepository repository = new FacturaRepository();
                    bool eliminado = repository.EliminarFactura(idFactura);

                    if (eliminado)
                    {
                        // Eliminar la factura de la lista de facturas (suponiendo que 'facturas' es una lista local)
                        List<Factura> facturas = (List<Factura>)dgvGestionarFacturas.DataSource;
                        Factura facturaAEliminar = facturas.FirstOrDefault(f => f.IdFactura == idFactura);
                        if (facturaAEliminar != null)
                        {
                            facturas.Remove(facturaAEliminar);
                        }

                        // Actualizar la fuente de datos del DataGridView
                        dgvGestionarFacturas.DataSource = null;
                        dgvGestionarFacturas.DataSource = facturas;

                        MessageBox.Show("Factura eliminada con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la factura.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void btnModificarFac_Click(object sender, EventArgs e)
        {
            if (dgvGestionarFacturas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvGestionarFacturas.SelectedRows[0];
                int idFactura = Convert.ToInt32(selectedRow.Cells["IdFactura"].Value);
                DateTime fechaFactura = Convert.ToDateTime(selectedRow.Cells["Fecha"].Value);
                decimal totalFactura = Convert.ToDecimal(selectedRow.Cells["Total"].Value);
                int idCliente = Convert.ToInt32(selectedRow.Cells["Cliente"].Value); // Asegúrate de que esté correctamente mapeado

                // Instanciar FacturaRepository
                FacturaRepository repository = new FacturaRepository();
                
                // Llamar al método para actualizar la factura en la base de datos
                bool actualizado = repository.ActualizarFactura(idFactura, fechaFactura, totalFactura, idCliente);

                if (actualizado)
                {
                    MessageBox.Show("Factura actualizada con éxito.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la factura.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }
    }
}
