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
    public partial class Part_add : Form
    {
        public Part_add()
        {
            InitializeComponent();
        }

        private void Part_add_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu_user new_from = new Menu_user();
            new_from.Show();
            Close();
        }
    }
}
