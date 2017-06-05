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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu_user new_from = new Menu_user();
            new_from.Show();
            Close();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DataBaseConnection.DataBase_Open_Connection();
                var query = "Select * from tblCar";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvCars.DataSource = table;

                DataBaseConnection.DataBase_Close_Connection(connection);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al recuperar registros, intentelo de nuevo \nInfo: " + exception);
            }
            
        }
    }
}
