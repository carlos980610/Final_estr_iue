using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotriz
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            cmbUserType.Text = "Taller";
            txtUser.Text = "Manuela";
            txtPassword.Text = "2";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "", password, user_type = cmbUserType.Text, id = ""; //Variables de login
            bool result = false; //Resultado del login query



            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Credenciales no validas, intentelo de nuevo");
            }
            else
            {
                user = txtUser.Text;
                password = txtPassword.Text;
                result = DataBaseConnection.Login(user, password, user_type);
                //Reenvio a formulario
                if (result && user_type.Equals("Taller"))
                {
                    id = DataBaseConnection.Credentials_in_menu(user, password, user_type);
                    Menu_user new_form = new Menu_user();
                    new_form.Show();
                    Hide();
                }
                else if (result && user_type.Equals("Cliente"))
                {

                    id = DataBaseConnection.Credentials_in_menu(user, password, user_type);
                    SendClass sendclass = new SendClass();
                    sendclass.GetterId(id);
                    Menu_client new_form = new Menu_client();
                    new_form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, por favor intentelo de nuevo");
                }
            }
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
