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
        string car_plate = "", id_owner = "";
        public Car_life_sheet(string plate, string ced)
        {
            InitializeComponent();
            car_plate = plate;
            id_owner = ced;

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

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
