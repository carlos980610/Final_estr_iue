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
    public partial class SingUp_client : Form
    {
        public SingUp_client()
        {
            InitializeComponent();
        }

        private void SingUp_client_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Operation_Click(object sender, EventArgs e)
        {
            SingUp_car new_form = new SingUp_car();
            new_form.Show();
            Close();
        }
    }
}
