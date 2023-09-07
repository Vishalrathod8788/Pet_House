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
    public partial class frmLogin : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //string title = "Pet House Management System";

        public frmLogin()
        {
            dbConnection db = new dbConnection();
            InitializeComponent();
            cn = new SqlConnection(db.connection());
        }

        dbConnection db = new dbConnection();

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass.Focus();
                return;
            }
            cn.Open();
            string qry = "SELECT username, password FROM tbl_login WHERE username = '" + txtName.Text.Trim() + "' AND password = '" + txtPass.Text.Trim() + "'";
            cmd = new SqlCommand(qry, cn);
            SqlDataReader DR;
            
            DR = cmd.ExecuteReader();
            if (DR.Read())
            {
                txtName.Text = DR["username"].ToString();
                txtPass.Text = DR["password"].ToString();
                new pet_house().ShowDialog();
                this.Dispose();
            }
            else MessageBox.Show("Invalid UserName or Password", "Login Authentication");
            DR.Close();
            cn.Close();
            clear();
        }
        
        public void clear()
        {
            txtName.Clear();
            txtPass.Clear();
        }
    }
}
