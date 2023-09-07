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
    public partial class frmService : Form
    {
        dbConnection db = new dbConnection();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public frmService()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPetTypes.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Pet Type", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPetTypes.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to Pet Information Add?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string QRY = "INSERT INTO tbl_pet (p_id, p_name, p_f_habit, pt_id, p_atmosphear, p_gender, p_age, p_vac) VALUES (";
                QRY += "(SELECT ISNULL(MAX(p_id), 0) + 1 from tbl_pet), ";
                QRY += "'" + txtName.Text + "', "; 
                QRY += rbtNonVeg.Checked ? "'NON-VEG', " : "'VEG', "; 
                QRY += cmbPetTypes.SelectedIndex + ", "; 
                QRY += rbtNonAC.Checked ? "'NON-A/C', " : "'A/C', "; 
                QRY += rbtFemale.Checked ? "'FEMALE', " : "'MALE', "; 
                QRY += int.Parse(txtAge.Text) + ", "; 
                QRY += rbtNo.Checked ? "'NO'" : "'YES'";
                QRY += ")";

                cn.Open();
                cmd = new SqlCommand(QRY, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                tbControl.SelectedIndex = 1;
            }

        }


        public void petTypeCmb()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT pt_id, pt_name FROM tbl_pet_type", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbPetTypes.DisplayMember = "pt_name";
            cmbPetTypes.ValueMember = "pt_id";
            cmbPetTypes.DataSource = dt;
            cn.Close();
        }

       

        public void Cutomers()
        {

            cn.Open();            
            cmd = new SqlCommand("SELECT c_id, c_name FROM tbl_customer", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbCustom.DisplayMember = "c_name";
            cmbCustom.ValueMember = "c_id";
            cmbCustom.DataSource = dt;
            cn.Close();
        }
        public void cmbPetType()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT pt_id, pt_name FROM tbl_pet_type", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbPtType.DisplayMember = "pt_name";
            cmbPtType.ValueMember = "pt_id";
            cmbPtType.DataSource = dt;
            cn.Close();
        }

        public void cmbService()
        {
            cn.Open();
            string qry = "SELECT s_id, s_name FROM tbl_service";
            cmd = new SqlCommand(qry, cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Servicecmb.DisplayMember = "s_name";
            Servicecmb.ValueMember = "s_id";
            Servicecmb.DataSource = dt;
            cn.Close();
        }

        
        private void frmService_Load(object sender, EventArgs e)
        {
            petTypeCmb();
            Cutomers();
            cmbPetType();
            cmbService();

        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rate = Convert.ToInt32(txtRate.Text);
                int day = Convert.ToInt32(txtDays.Text);

                int total = rate * day;
                txtTotal.Text = total.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbCustom.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCustom.Focus();
                return;
            }

            if (cmbPtType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Pet Type", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPtType.Focus();
                return;
            }

            if (Servicecmb.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Service", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Servicecmb.Focus();
                return;
            }
            if (txtDays.Text == "")
            {
                MessageBox.Show("Please Enter No. Of Days", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDays.Focus();
                return;
            }
           
            
            if (MessageBox.Show("Are You Sure you want to Pet Information Add?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "INSERT INTO tbl_bill_service (bs_id, bs_date, c_id, s_id, pt_id, s_price, no_of_day, bs_total) ";
                qry += "VALUES ((SELECT MAX(bs_id) + 1 FROM tbl_bill_service), ";
                qry += "'" + date.Value.ToString("yyyy-MM-dd") + "', ";
                qry += " " + cmbCustom.SelectedValue + ", ";
                qry += " " + Servicecmb.SelectedValue + ", ";
                qry += " " + cmbPtType.SelectedValue + ", ";
                qry += " " + txtRate.Text + ", ";
                qry += " " + txtDays.Text + ", ";
                qry += " " + txtTotal.Text + ")";

                cn.Open();
                cmd = new SqlCommand(qry, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                new rptService().ShowDialog();

                this.Hide();
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRate.Text = "0";
        }

        private void Servicecmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string qry = "select s_price from tbl_service where s_id = " + Servicecmb.SelectedValue;
            cn.Close();
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtRate.Text = dr["s_price"].ToString();
            }
            //MessageBox.Show(qry);
            dr.Close();
            cn.Close();
        }
    }
}
