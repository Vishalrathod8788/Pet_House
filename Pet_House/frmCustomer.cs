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
using System.Text.RegularExpressions;

namespace pet_house
{
    public partial class frmCustomer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnection dbCon = new dbConnection();
        static Regex email_check = email_validation();
        
        string title = "Pet House Management System";

        public frmCustomer()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.connection());
            LoadUser();
            btnUpdate.Enabled = false;
        }
        public void clear()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAdd.Clear();
            txtCity.Clear();
        }
        public void LoadUser()
        {
            string qry = "SELECT c_id, c_name, c_email, c_phone, c_add, c_city, c_date FROM tbl_customer WHERE c_id <> 1 ORDER BY c_id DESC;";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];
            cn.Close();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            String colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ID.Visible = true;
                btnUpdate.Enabled = false;
                lblUID.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAdd.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCity.Text = dgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();

                // Check if the date string is a valid DateTime format
                string dateString = dgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();
                DateTime dateValue;
                if (DateTime.TryParse(dateString, out dateValue))
                {
                    date.Text = dateValue.ToString(); // Set the valid DateTime value
                }
                else
                {

                }
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                
            }


            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are You Sure you want to Delete this user?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM tbl_customer WHERE c_id LIKE '" + dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User data has been successfully remove", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                }
            }

            LoadUser();
        }
        private static Regex email_validation()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Name is Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            
            if(email_check.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Email Not Valid","Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone Number Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }

            if (txtAdd.Text == "")
            {
                MessageBox.Show("Address Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdd.Focus();
                return;
            }

            if (txtCity.Text == "")
            {
                MessageBox.Show("City Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCity.Focus();
                return;
            }

            if (Text == "")
            {
                MessageBox.Show("City Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCity.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  register this user?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("INSERT INTO tbl_customer (c_name, c_email, c_phone, c_add, c_city, c_date) VALUES(@c_name, @c_email, @c_phone, @c_add, @c_city, @c_date)", cn);

                cmd.Parameters.AddWithValue("@c_name", txtName.Text);
                cmd.Parameters.AddWithValue("@c_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@c_phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@c_add", txtAdd.Text);
                cmd.Parameters.AddWithValue("@c_city", txtCity.Text);
                cmd.Parameters.AddWithValue("@c_date", date.Value.ToString("yyyy-MM-dd"));

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User has been Successfully Registerd!", title);
                LoadUser();
                clear();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }

            if (email_check.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Email Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone Number Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }

            if (txtAdd.Text == "")
            {
                MessageBox.Show("Address Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdd.Focus();
                return;
            }

            if (txtCity.Text == "")
            {
                MessageBox.Show("City Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCity.Focus();
                return;
            }

            if (Text == "")
            {
                MessageBox.Show("City Not be Blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCity.Focus();
                return;
            }
            if (MessageBox.Show("Are You Sure you want to Update this user?", "Edit Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE tbl_customer SET c_name=@c_name, c_email=@c_email, c_phone=@c_phone, c_add=@c_add, c_city=@c_city, c_date=@c_date WHERE c_id = @c_id", cn);
                cmd.Parameters.AddWithValue("@c_id", lblUID.Text);
                cmd.Parameters.AddWithValue("@c_name", txtName.Text);
                cmd.Parameters.AddWithValue("@c_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@c_phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@c_add", txtAdd.Text);
                cmd.Parameters.AddWithValue("@c_city", txtCity.Text);
                cmd.Parameters.AddWithValue("@c_date", date.Value.ToString("yyyy-MM-dd"));

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User has been Successfully Update !", title);
                LoadUser();
                clear();
                
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            ID.Visible = false;
        }

        private void txtPhone_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Focus();
                Error.SetError(txtPhone, "Phone Number is Not Valid");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(txtPhone, "");

            }
        }

        private void txtName_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Focus();
                Error.SetError(txtName, "Name not must be blank");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(txtName, "");
            }
        }

        private void txtEmail_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Focus();
                Error.SetError(txtEmail, "Enter Valid Email Address");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(txtEmail, "");
            }
        }

        private void txtAdd_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdd.Text))
            {
                txtAdd.Focus();
                Error.SetError(txtAdd, "Address not be blank");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(txtAdd, "");
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        
    }
}
