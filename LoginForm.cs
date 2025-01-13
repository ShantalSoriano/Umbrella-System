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
    }
}
