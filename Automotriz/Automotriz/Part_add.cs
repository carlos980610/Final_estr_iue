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
    public partial class Part_add : Form
    {
        public Part_add()
        {
            InitializeComponent();
        }

        private void Part_add_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
                var query = "Select * from tblPart";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();
                adapter.Fill(data_table);

                dgvParts.DataSource = data_table;

                DataBaseConnection.DataBase_Close_Connection(conn);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al consultar las partes del vehiculo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            try
            {
             SqlConnection conn = DataBaseConnection.DataBase_Open_Connection();
             SqlCommand command;
                var request = "insert into tblPart (Part_name, Part_price) values ('"+ txtName_R.Text+"','"+txtPrecio_R.Text +"')";
                command = new SqlCommand(request, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Se añadío con exito la parte");
               

            }
            catch(Exception)
            {
                MessageBox.Show("No se Añadio");
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
