using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Umbrella_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Eliminar la barra (borde) del formulario

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        // Mover el formulario sin bordes 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleBarLog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los datos del usuario
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // Verificar si las credenciales son correctas
            if (authenticate_cred(user, pass))
            {
                // Si es correcto, mostrar HomeForm
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        private bool authenticate_cred(string username, string password)
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = DBConnection.ObtenerConexion();

            // Crear la consulta para verificar las credenciales
            string query = "SELECT COUNT(*) FROM Usuarios WHERE usernameUsuario = @username AND passwordUsuario = @password";

            // Crear el comando
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);

            // Ejecutar la consulta y obtener el resultado 
            int result = (int)comando.ExecuteScalar(); // Ejecuta la consulta y devuelve el número de filas encontradas

            // Cerrar la conexión
            conexion.Close();

            return result > 0; // Si el resultado es mayor que 0, entonces las credenciales son correctas
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que la tecla Enter realice la acción borrar los campos
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que la tecla Enter realice la acción borrar los campos
            }
        }
    }
}
