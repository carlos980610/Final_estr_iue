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

        private void dgvCars_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu context_menu_for_cars = new ContextMenu();
                context_menu_for_cars.MenuItems.Add(new MenuItem("Enviar al taller"));

                int currentMouseOverRow = dgvCars.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    context_menu_for_cars.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }
                context_menu_for_cars.Show(dgvCars, new Point(e.X, e.Y));

            }
        }

        private void MenuItems_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            var menuText = clickedMenuItem.Text;
            switch (menuText)
            {
                case "Enviar al taller":
                    Workshop_status new_form = new Workshop_status();
                    new_form.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
