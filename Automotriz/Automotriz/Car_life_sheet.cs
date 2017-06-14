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
    public partial class Car_life_sheet : Form
    {
        string car_plate = "", id_owner = "", service_type = "";
        int suma;
        public Car_life_sheet(string plate, string ced)
        {
            InitializeComponent();
            car_plate = plate;
            id_owner = ced;

            pgbEstatus.Maximum = 100;   //Define el valor maximo que puede contener la barra
            pgbEstatus.Minimum = 0;     //Define el valor minimo que puede contener la barra

            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                var query = "Select * from tblCar where Car_carriage_plate = '" + car_plate + "' and Car_owner_id = '" + id_owner + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader data_reader = command.ExecuteReader();

                if (data_reader.Read())
                {
                    lblId.Text = data_reader["Id_Car"].ToString();
                    lblCarriage.Text = data_reader["Car_carriage_plate"].ToString();
                    lblOwner.Text = "Nombre de cliente"; //TODO hacer query para traer cliente
                    lblMark.Text = data_reader["Car_mark"].ToString();
                    lblModel.Text = data_reader["Car_model"].ToString();
                    lblCylinder.Text = data_reader["Car_cylinder"].ToString();
                    lblKilometer.Text = data_reader["Car_kilometer"].ToString();
                }
                else
                {
                    MessageBox.Show("La placa no existe para este usuario, si no es así favor verificar");
                    Close();

                }
            }
            catch (Exception exception)
            {

                throw;
            }
            try

            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                var query = "select * from tblService where Id_Placa = '" + lblCarriage.Text + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table_s = new DataTable();
                adapter.Fill(table_s);

                dgvServicio.DataSource = table_s;

                service_type = dgvServicio.Rows[0].Cells[2].Value.ToString();
                service_type = service_type.Trim();
                MessageBox.Show(service_type);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }



            if (service_type == "Mantenimiento")
            {
                try
                {
                    SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                    var query = "select Porcent from tblCars_in_Maintenance";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader data_reader = command.ExecuteReader();

                    if (data_reader.Read())
                    {
                        pgbEstatus.Step = Convert.ToInt32(data_reader["Porcent"].ToString());
                        pgbEstatus.PerformStep();
                        lblPorcent.Text = data_reader["Porcent"].ToString() + "%";
                    }
                    else
                    {
                        MessageBox.Show("No se logró cargar el porcentaje del vehiculo en el taller");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (service_type == "Reparación")
            {
                try
                {
                    SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                    var query = "select Porcent from tblCars_in_Repair";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader data_reader = command.ExecuteReader();

                    if (data_reader.Read())
                    {
                        pgbEstatus.Step = Convert.ToInt32(data_reader["Porcent"].ToString());
                        pgbEstatus.PerformStep();
                        lblPorcent.Text = data_reader["Porcent"].ToString() + "%";
                    }
                    else
                    {
                        MessageBox.Show("No se logró cargar el porcentaje del vehiculo en el taller");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Fatal error, no existe porcentaje de avance en el vehiculo, comuniquese con el taller");
            }


        }


        private void Car_life_sheet_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
            var query = "Select Client_name from tblClient where Client_id_card = '" + id_owner + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader data_reader = command.ExecuteReader();

            if (data_reader.Read())
            {
                lblOwner.Text = data_reader["Client_name"].ToString();      
    }
            else
            {
                MessageBox.Show("No se recuperó el nombre del cliente, verifique e intentelo de nuevo de ser necesario");
            }
            lblVeces_taller.Text = (dgvServicio.RowCount - 1 ).ToString();

            for (int i = 0; i < dgvServicio.RowCount - 1; i++)
            {
                suma = Convert.ToInt32(dgvServicio.Rows[i].Cells[4].Value);
            }
            lblTotalCost.Text = suma.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
