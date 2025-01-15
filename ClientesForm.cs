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

        btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = txtNombreCliente.Text;
            cliente.telefono = txtTelefonoCliente.Text;
            cliente.direccion = txtDireccionCliente.Text;

            int result = ClienteRepository.AgregarCliente(cliente);

            if (result > 0)
            {
                MessageBox.Show("Cliente registrado correctamente");
                GuardarPreferenciasServicios(cliente); // Pass the instance of Cliente instead of the type name
            }
            else
            {
                MessageBox.Show("No se pudo registrar el cliente");
            }
            ActualizarTabla();

            txtNombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txtDireccionCliente.Clear();
        }

        private void GuardarPreferenciasServicios(Cliente cliente)
        {
            // Implementation of the method to save client service preferences
        }

        private void tabTodosLosClientes_Click(object sender, EventArgs e)
        {

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            CargarServicios();
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

        
        


    }
}


