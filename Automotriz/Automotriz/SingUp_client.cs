using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Automotriz
{
    public partial class SingUp_client : Form
    {

        public SingUp_client()
        {
            InitializeComponent();
        }

        private void btnAdd_Client_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DataBaseConnection.DataBase_Open_Connection();
                var query = "Insert into tblClient (Client_name, Client_phone, Client_user, Client_password, Client_address, Client_id_card) values ('" + txtName.Text + "','" + txtPhone.Text + "','" + txtUser.Text + "','" + txtPassword.Text + "','" + txtAddress.Text + "','" + txtId_Card.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                DataBaseConnection.DataBase_Close_Connection(connection);
                MessageBox.Show("Cliente agregado con exito");
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se agrego el cliente \nInfo " + exception);
            }
        }

        private void SingUp_client_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Operation_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
