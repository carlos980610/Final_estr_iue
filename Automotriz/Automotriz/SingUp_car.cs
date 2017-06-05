using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotriz
{
    public partial class SingUp_car : Form
    {
        public SingUp_car()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu_user new_form = new Menu_user();
            new_form.Show();
            Close();
        }

        private void btnNew_Client_Click(object sender, EventArgs e)
        {
            SingUp_client new_form = new SingUp_client();
            new_form.ShowDialog();
            
        }
    }
}
