using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_house
{
    public partial class pet_house : Form
    {
        public pet_house()
        {
            InitializeComponent();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCustomer().ShowDialog();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmService().ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProduct().ShowDialog();
        }

        private void servicePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rptService().ShowDialog();
        }

        private void productPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rptProduct().ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdmin().ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
