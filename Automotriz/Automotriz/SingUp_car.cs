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
    public partial class SingUp_car : Form
    {

        private void btnSearch_Client_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DataBaseConnection.DataBase_Open_Connection();
                var query = "Select IdClient, Client_name, Client_id_card, Client_phone, Client_address from tblClient where IdClient = '" + txtId_Client.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader data_reader = command.ExecuteReader();

                if (data_reader.Read())
                {
                    lblId_client.Text = data_reader["IdClient"].ToString();   
                    lblName.Text = data_reader["Client_name"].ToString();
                    lblId_Card.Text = data_reader["Client_id_card"].ToString();
                    lblPhone.Text = data_reader["Client_phone"].ToString();
                    lblAddress.Text = data_reader["Client_address"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el ID, favor verificar");
                    lblId_client.Text = "Not ID";
                }

                DataBaseConnection.DataBase_Close_Connection(connection);
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se encontró registro \n Info " + exception);
            }
        }

        public SingUp_car()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DataBaseConnection.DataBase_Open_Connection();
                var query = "Insert into tblCar (Car_mark, Car_model, Car_cylinder, Car_kilometer, Car_carriage_plate, Car_owner_id) values ('" + txtMark.Text + "','" + txtModel.Text + "','" + txtCylinder.Text + "','" + txtKilometer.Text + "','" + txtPlate.Text + "','" + lblId_client.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea registrar este vehiculo", "Sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vehiculo registrado con exito");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El vehiculo no se ha registrado, si creo algún usuario este si quedo registrado");
                }
                DataBaseConnection.DataBase_Close_Connection(connection);
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se logró realizar el registro, intentelo nuevamente \n Info " + exception);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu_user new_form = new Menu_user();
            new_form.Show();
            Close();
        }

        private void btnNew_Client_Click(object sender, EventArgs e)
        {
            SingUp_client new_form = new SingUp_client();
            new_form.ShowDialog();
        }
    }
}
