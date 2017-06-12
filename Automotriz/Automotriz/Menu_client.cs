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
    public partial class Menu_client : Form
    {
        string id;
        public Menu_client (string id)
        {
            InitializeComponent();
            lblId_Cliente.Text = id;
            dgvClient_Info.Enabled = false;

            //Trae la información del cliente y la coloca en el DatGridView
            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                var query = "select IdClient, Client_name, Client_phone, Client_user, Client_address, Client_id_card from tblClient where IdClient = " + id;

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();

                adapter.Fill(data_table);

                dgvClient_Info.DataSource = data_table;

                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {
                MessageBox.Show("No consultó");
            }

            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                var query = "select * from tblCar where Car_owner_id = " + id;

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();

                adapter.Fill(data_table);

                dgvCars_Owner.DataSource = data_table;

                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {
                MessageBox.Show("No consultó");
            }
        }

        private void Menu_client_Load(object sender, EventArgs e)
        {
            //Carga el ID del cliente en el formulario
            SendClass sendclass = new SendClass();
            id = sendclass.SetterId();
            lblId_Cliente.Text = id;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarvehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Car_life_sheet new_form = new Car_life_sheet(txtBuscarvehiculo.Text, lblId_Cliente.Text);
                new_form.Show();  //TODO - aplicar parametro ID para poder cerrar el formulario de cliente
            }
            catch (Exception)
            {

            }
            txtBuscarvehiculo.Text = "";
        }
        private void txtBuscarvehiculo_TextChanged(object sender, EventArgs e)
        {

        }
        private void Menu_client_Load_1(object sender, EventArgs e)
        {

        }
    }
}
