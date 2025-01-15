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

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = txtNombreCliente.Text;
            cliente.telefono = txtTelefonoCliente.Text;
            cliente.direccion = txtDireccionCliente.Text;

            int result = ClienteRepository.AgregarCliente(cliente);

            if (result > 0)
            {
                MessageBox.Show("Cliente registrado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo registrar el cliente");
            }

        }
    }
}
