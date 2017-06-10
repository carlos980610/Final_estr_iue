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

        int total_cars; //Cantidad total de carros en el taller
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
            btnAdd_to_Workshop.Enabled = false;

            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable table_r = new DataTable();
            DataTable table_m = new DataTable();

            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();

                var query_id_workshop_repair = "select * from tblCars_in_Repair";

                SqlCommand command_repair = new SqlCommand(query_id_workshop_repair, conn);
                SqlDataAdapter adapter_repair = new SqlDataAdapter(command_repair);
                DataTable data_table_repair = new DataTable();

                adapter_repair.Fill(data_table_repair);
                foreach (DataRow rows in data_table_repair.Rows)
                {
                    var query = "select * from tblCar where Id_Car = " + rows["IdCar"].ToString();

                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(table_r);
                }
                dgvCars_in_repair.DataSource = table_r;

                // ---------------------------------------------------------------------------------------------------------
                // ---------------------------------------------------------------------------------------------------------

                var query_id_workshop_maintenance = "select * from tblCars_in_Maintenance";

                SqlCommand command_maintenance = new SqlCommand(query_id_workshop_maintenance, conn);
                SqlDataAdapter adapter_maintenance = new SqlDataAdapter(command_maintenance);
                DataTable data_table_maintenance = new DataTable();

                adapter_maintenance.Fill(data_table_maintenance);


                foreach (DataRow rows in data_table_maintenance.Rows)
                {
                    var query = "select * from tblCar where Id_Car = " + rows["IdCar"].ToString();

                    command = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(table_m);
                }
                dgvCars_in_maintenance.DataSource = table_m;

                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al cargar los datos \nInfo: " + exception);
            }

            total_cars = dgvCars_in_repair.Rows.Count + dgvCars_in_maintenance.Rows.Count;
            lblTotal_Manteniance_Cars.Text = dgvCars_in_maintenance.Rows.Count.ToString();
            lblTotal_Repair_Cars.Text = dgvCars_in_repair.Rows.Count.ToString();
            lblTotal_Cars.Text = total_cars.ToString();


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();

                var query_car = "select Car_mark, Car_model from tblCar where Car_carriage_plate = '" + txtCar_Plate + "'";

                SqlCommand command_car = new SqlCommand(query_car, conn);
                SqlDataReader data_reader = command_car.ExecuteReader();

                if (data_reader.Read())
                {
                    lblCar_Mark.Text = data_reader["Car_mark"].ToString();
                    lblCar_Model.Text = data_reader["Car_model"].ToString();

                   // lblCar_Owner.Text = data_reader["Car_"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el ID, favor verificar");
                    lblCar_Mark.Text = "Not";
                    lblCar_Model.Text = "Not";
                    lblCar_Owner.Text = "Not";

                }

                DataBaseConnection.DataBase_Close_Connection(conn);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
