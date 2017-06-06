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
    public partial class Workshop : Form
    {
        public Workshop()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Workshop_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();

                var query_id_workshop_repair = "select * from tblCars_in_Repair";

                SqlCommand command_repair = new SqlCommand(query_id_workshop_repair, conn);
                SqlDataAdapter adapter_repair = new SqlDataAdapter(command_repair);
                DataTable data_table_repair = new DataTable();

                adapter_repair.Fill(data_table_repair);

                SqlCommand command;
                SqlDataAdapter adapter;
                DataTable table = new DataTable();

                foreach (DataRow rows in data_table_repair.Rows)
                {
                    var query = "select * from tblCar where Id_Car = " + rows["IdCar"].ToString();

                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    

                    adapter.Fill(table);

                    
                }
                dgvCars_in_repair.DataSource = table;



                var query_id_workshop_maintenance = "select * from tblCars_in_Maintenance";


                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al cargar los datos");
            }
            
        }
    }
}
