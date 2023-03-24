using System;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            CodigoUsuarioTextBox1.Focus();
        }

        private void CancelarButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton1_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox1.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox1, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();
            if (ContraseñaTextBox2.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñaTextBox2, "Ingrese una contraseña");
                return;
            }
        }
    }
}
