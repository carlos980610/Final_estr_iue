using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Automotriz
{
    class DataBaseConnection
    {
        //Abrir conexion con la base de datos
        public static SqlConnection DataBase_Open_Connection()
        {
            string route = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\CarlosAndrés\\Documents\\Visual Studio 2017\\Projects\\Final_estructuras_iue\\Automotriz\\Automotriz\\DataBase\\dbAutomotriz.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(route);
            try
            {
                connection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se logró conectar la base de datos, intentelo de nuevo \n" + exception);
            }
            return connection;
        }
        //Cerrar conexion con la base de datos
        public static void DataBase_Close_Connection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se logró cerrar la conexión con la base de datos");
            }
        }
        public static bool Login(string user, string password, string user_type)
        {
            bool successful = false;
            SqlConnection connection = DataBase_Open_Connection();
            SqlCommand command;
            SqlDataAdapter Adapter;
            DataTable Table;

            if (user_type.Equals("Taller")) //Para los que trabajan en el taller
            {
                try
                {
                    var instruction = "Select User, Password from tblUser where User = '" + user + "' and Password = '" + password + "'";
                    command = new SqlCommand(instruction, connection);
                    Adapter = new SqlDataAdapter(command);
                    Table = new DataTable();

                    Adapter.Fill(Table);

                    if (Table.Rows.Count == 0)
                    {

                        
                        successful = true;

                    }
                    else
                    {
                        successful = true;
                    }
                    //Traer el Id del usuario
                    var instruction_id = "Select [IdUser] from tblUser where [User] = '" + user + "' and Password = '" + password + "'";
                    SqlCommand command_id = new SqlCommand(instruction_id, connection);
                    DataTable Table_id = new DataTable();
                    string id = Convert.ToString(command_id.ExecuteScalar());

                    //Enviar credenciales al formulario de Menu_user
                }
                catch (Exception exception)
                {
                    successful = false;
                }
            }
            else if (user_type.Equals("Cliente")) //Para los clientes
            {
                try
                {
                    var instruction = "Select Client_user, Client_password from tblClient where Client_user = '" + user + "' and Client_password = '" + password + "'";
                    command = new SqlCommand(instruction, connection);
                    Adapter = new SqlDataAdapter(command);
                    Table = new DataTable();

                    Adapter.Fill(Table);

                    if (Table.Rows.Count == 1)
                    {
                        successful = true;
                    }
                    else
                    {
                        successful = false;
                    }
                    //Traer el Id del usuario
                    var instruction_id = "Select IdClient from tblClient where Client_user = '" + user + "' and Client_password = '" + password + "'";
                    SqlCommand command_id = new SqlCommand(instruction_id, connection);
                    DataTable Table_id = new DataTable();
                    string id = Convert.ToString(command_id.ExecuteScalar());

                    //Enviar credenciales al formulario de Menu_Client
                }
                catch (Exception exception)
                {
                    successful = false;
                }
            }
            else
            {
                successful = false;
            }

            DataBase_Close_Connection(connection); // Cerrar conexion con la base de datos
            return successful;
        }

        //Credenciales en MENU_user
        public static string Credentials_in_menu(string user, string password, string user_type)
        {
            SqlConnection connection = DataBase_Open_Connection();
            string id = "";
            if (user_type.Equals("Taller"))
            {
                try
                {
                    var instruction_id = "Select IdUser from tblUser where [User] = '" + user + "' and Password = '" + password + "'";
                    SqlCommand command_id = new SqlCommand(instruction_id, connection);
                    DataTable Table_id = new DataTable();
                    id = Convert.ToString(command_id.ExecuteScalar());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error trayendo credenciales" + exception);
                }
            }
            else if (user_type.Equals("Cliente"))
            {
                try
                {
                    var instruction_id = "Select IdClient from tblClient where Client_user = '" + user + "' and Client_password = '" + password + "'";
                    SqlCommand command_id = new SqlCommand(instruction_id, connection);
                    DataTable Table_id = new DataTable();
                    id = Convert.ToString(command_id.ExecuteScalar());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error trayendo credenciales" + exception);
                }
            }
            return id;
            
        }


    }
}
