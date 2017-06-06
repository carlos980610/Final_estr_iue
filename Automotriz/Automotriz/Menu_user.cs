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
    public partial class Menu_user : Form
    {
        public Menu_user()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_user_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login new_form = new Login();
            new_form.Show();
            this.Close();
        }

        private void btnSee_Cars_Click(object sender, EventArgs e)
        {
            Cars new_form = new Cars();
            new_form.Show();
            Hide();
        }

        private void btnSee_Clients_Click(object sender, EventArgs e)
        {
            Clients new_form = new Clients();
            new_form.Show();
            Hide();
        }

        private void btnRegister_Car_Click(object sender, EventArgs e)
        {
            SingUp_car new_from = new SingUp_car();
            new_from.Show();
            Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        { 
            Close();
            Application.Exit();
        }

        private void btnSeeGarage_Click(object sender, EventArgs e)
        {
            Workshop new_form = new Workshop();
            new_form.ShowDialog();
        }
    }
}
