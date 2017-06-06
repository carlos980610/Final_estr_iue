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
        public Menu_client()
        {
            InitializeComponent();
        }

        private void Menu_client_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_client_Load_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();

                
                var query = "select IdClient, Client_name, Client_phone, Client_user, Client_address, Client_id_card from tblClient where IdClient = '" + Login.getId() + "'";

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();

                adapter.Fill(data_table);

                dgvClient_Info.DataSource = data_table;

                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {

            }
        }
    }
}
