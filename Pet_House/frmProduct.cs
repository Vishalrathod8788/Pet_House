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
    public partial class frmProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnection dbCon = new dbConnection();


        string title = "Pet House Management System";

        public frmProduct()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.connection());
        }

        //================================================= Product ComboBind ==============================================================
        public void Product()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT pro_id, pro_name FROM tbl_product", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbProduct.DisplayMember = "pro_name";
            cmbProduct.ValueMember = "pro_id";
            cmbProduct.DataSource = dt;
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


        private void frmProduct_Load(object sender, EventArgs e)
        {
            Product();
            Cutomers();
        }

        

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (cmbCustom.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCustom.Focus();
                return;
            }

            if (cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Product Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProduct.Focus();
                return;
            }

            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQty.Focus();
                return;
            }

            string[] arr = new string[7];
            arr[0] = cmbCustom.Text;
            arr[1] = date.Text;
            arr[2] = cmbProduct.Text;
            arr[3] = txtQty.Text;
            arr[4] = txtRate.Text;
            arr[5] = txtTotal.Text;


            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            try
            {
                int subValue = Convert.ToInt16(txt_sub.Text);
                int totalValue = Convert.ToInt16(txtTotal.Text);

                int result = subValue + totalValue;

                txt_sub.Text = result.ToString();
            }
            catch (FormatException)
            {
                // Handle the case where the input strings are not valid integers.
                // You can show an error message or take other appropriate action.
            }

            

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int proRate = Convert.ToInt32(txtRate.Text);
                int qty = Convert.ToInt32(txtQty.Text);

                int total = qty * proRate;
                txtTotal.Text = total.ToString();
            }
            catch (FormatException)
            {
                // Handle the case where the input is not a valid integer
                txtTotal.Text = "Invalid input";
            }
        }



        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[5].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Any Select Items", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (listView1.Items.Count > 0)
            {
                if (MessageBox.Show("Are You Sure you want to Items Add?", "Product Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Qry;
                    Qry = "insert into tbl_bill_pro (bp_id, c_id, bp_date, pro_id, qty, pro_mvp, bp_total)";
                    Qry += "VALUES((SELECT ISNULL(MAX(bp_id), 0) + 1 from tbl_bill_pro) ,";
                    Qry += " ' " + cmbCustom.SelectedValue + " ', ";
                    Qry += " ' " + date.Value.ToString("yyyy-MM-dd") + " ', ";
                    Qry += " ' " + cmbProduct.SelectedValue + " ', ";
                    Qry += " " + txtQty.Text + ", ";
                    Qry += " " + txtRate.Text + ", ";
                    Qry += " " + txtTotal.Text + ") ";

                    cn.Open();
                    foreach (ListViewItem ListItem in listView1.Items)
                    {
                        cmd = new SqlCommand(Qry, cn);
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();

                    MessageBox.Show("Record Insertd...", title);

                    new rptProduct().ShowDialog();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Must Add an Item in the List", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "select pro_mvp from tbl_product where pro_id = " + cmbProduct.SelectedValue;
            cn.Close();
            cn.Open();
            cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtRate.Text = dr["pro_mvp"].ToString();
            }
            dr.Close();
            cn.Close();
        }
    }
}
