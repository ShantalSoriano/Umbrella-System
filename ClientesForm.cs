using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella_System
{

    public partial class ClientesForm : Form
    {
        private int? clienteIdSeleccionado = null; // Variable para almacenar el id del cliente seleccionado
                                                   // Null significa que no hay cliente seleccionado
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = txtNombreCliente.Text;
            cliente.telefono = txtTelefonoCliente.Text;
            cliente.direccion = txtDireccionCliente.Text;

            int result;

            if (clienteIdSeleccionado == null) // Registro de un nuevo cliente
            {
                result = ClienteRepository.AgregarCliente(cliente);
                if (result > 0)
                {
                    MessageBox.Show("Cliente registrado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente");
                }
            }
            else // Actualización de un cliente existente
            {
                cliente.idCliente = clienteIdSeleccionado.Value;
                result = new ClienteRepository().ActualizarCliente(cliente);
                if (result > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente");
                }
                clienteIdSeleccionado = null;
            }

            ActualizarTabla();
            LimpiarCampos();
        }

        private void tabTodosLosClientes_Click(object sender, EventArgs e)
        {

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClienteRepository.ObtenerTodos();
            ActualizarTabla();
        }


        private void ActualizarTabla()
        {
            dgvClientes.DataSource = ClienteRepository.ObtenerTodos();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txtDireccionCliente.Clear();
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            if (clienteIdSeleccionado != null)
            {
                // Cambia a la tab "Registrar Cliente"
                tabctrlClientes.SelectedTab = tabRegistrarCliente;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para modificar.");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = this.dgvClientes.Rows[e.RowIndex];



                // Obtener los datos del cliente seleccionado
                clienteIdSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value); // Ajusta el nombre de la columna al de tu base de datos
                txtNombreCliente.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtTelefonoCliente.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                txtDireccionCliente.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txtDireccionCliente.Clear();
            clienteIdSeleccionado = null; // Reinicia el estado de selección
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var valor = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (valor == DialogResult.Yes)
            {
                if (clienteIdSeleccionado != null)
                {
                    int result = new ClienteRepository().EliminarCliente(clienteIdSeleccionado.Value);
                    if (result > 0)
                    {
                        MessageBox.Show("Cliente eliminado correctamente");
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("No se encontró un cliente con el ID proporcionado.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el cliente.");
                    }

                    ActualizarTabla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                }
            }
        }
    }
}
    



