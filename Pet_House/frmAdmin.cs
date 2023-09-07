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
    public partial class frmAdmin : Form
    {
        dbConnection db = new dbConnection();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        
        string title = "Pet House Management System";
        public frmAdmin()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
        }

        private void tbPetInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            ProBind();
            petDelete();
            petUpdate();
            ProUpBind();
            cmbDelService1();
            cmbUpService1();
            ProUpRateBind();

        }

       
        //================================================= PetDelete ComboBind ===============================================================
        public void petDelete()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT pt_id, pt_name FROM tbl_pet_type", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbDelPet.DisplayMember = "pt_name";
            cmbDelPet.ValueMember = "pt_id";
            cmbDelPet.DataSource = dt;
            cmbUppet.DisplayMember = "pt_name";
            cmbUppet.ValueMember = "pt_id";
            cmbUppet.DataSource = dt;
            cn.Close();
        }

        public void petUpdate()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT pt_id, pt_name FROM tbl_pet_type", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbUppet.DisplayMember = "pt_name";
            cmbUppet.ValueMember = "pt_id";
            cmbUppet.DataSource = dt;
            cn.Close();
        }


        //================================================= Pet ComboBind ===============================================================
        public void ProBind()
        {

            cn.Open();
            cmd = new SqlCommand("SELECT pro_id, pro_name, pro_mvp FROM tbl_product", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbProDel.DisplayMember = "pro_name";
            
            cmbProDel.ValueMember = "pro_id";
           
            cmbProDel.DataSource = dt;
            
            cn.Close();
        }

        public void ProUpBind()
        {

            cn.Open();
            cmd = new SqlCommand("SELECT pro_id, pro_name, pro_mvp FROM tbl_product", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbProUpd.DisplayMember = "pro_name";
            cmbProUpd.ValueMember = "pro_id";
            cmbProUpd.DataSource = dt;
            cn.Close();
        }

        public void ProUpRateBind()
        {

            cn.Open();
            cmd = new SqlCommand("SELECT pro_name, pro_mvp FROM tbl_product", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbProUpd.DisplayMember = "pro_name";
            cmbProUpd.ValueMember = "pro_mvp";
            cmbProUpd.DataSource = dt;
            cn.Close();
        }

        public void cmbDelService1()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT s_id, s_name FROM tbl_service", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbDelService.DisplayMember = "s_name";
            cmbDelService.ValueMember = "s_id";
            cmbDelService.DataSource = dt;
            cn.Close();
        }

        public void cmbUpService1()
        {
            cn.Open();
            cmd = new SqlCommand("SELECT s_id, s_name, s_price FROM tbl_service", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbUpService.DisplayMember = "s_name";
            cmbUpService.ValueMember = "s_price";
            cmbUpService.DataSource = dt;
            cn.Close();
        }
        

        private void AddBrand_Click(object sender, EventArgs e)
        {
           
        }

        //===========================================================Insert Pet Type===========================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPetType.Text == "")
            {
                MessageBox.Show("Please Enter Pet Type Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPetType.Focus();
                return;
            }
            if (MessageBox.Show("Are You Sure you want to  Add this Pet Type ?", "Pet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String qry = "INSERT INTO tbl_pet_type (pt_name) VALUES (@pt_name)";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@pt_name", txtPetType.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Pet Type has been Successfully Add!", title);
            }
        }

        //===========================================================Delete Pet Type===========================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbDelPet.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Pet Type", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDelPet.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  Remove this Pet Type ?", "Pet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "DELETE FROM tbl_pet_type WHERE pt_id = @PetId";
                
                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@PetId", cmbDelPet.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Pet Type has been Successfully Remove!", title);
            }
        }

        //===========================================================Update Pet Type===========================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbUppet.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Pet Type", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDelPet.Focus();
                return;
            }

            if (txtNewPet.Text == "")
            {
                MessageBox.Show("Please Enter Pet Type Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPetType.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  Update this Pet Type ?", "Pet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string qry = "UPDATE tbl_pet_type SET pt_name = @NewPetName WHERE pt_id = @PetId";

                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@PetId", cmbUppet.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NewPetName", txtNewPet.Text);
                cmd.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("Pet Type has been Successfully Updated!", title);
            }
        }

        

        private void Add_Click(object sender, EventArgs e)
        {
            if (txtProAdd.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProAdd.Focus();
                return;
            }
            if (txtRate.Text == "")
            {
                MessageBox.Show("Please Enter Product Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRate.Focus();
                return;
            }
            if (MessageBox.Show("Are You Sure you want to  Add this Pet Type ?", "Pet Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String qry = "INSERT INTO tbl_product (pro_name, pro_mvp) VALUES (@pro_name, @pro_mvp)";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@pro_name", txtProAdd.Text);
                cmd.Parameters.AddWithValue("@pro_mvp", txtRate.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Pet Type has been Successfully Add!", title);
            }
        }

        private void cmbProUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                proRate.Text = cmbProUpd.SelectedValue.ToString();
            }
            catch (Exception)
            {
                proRate.Text = "";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
            if (cmbProDel.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Product", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProDel.Focus();
                return;
            }
            
            if (MessageBox.Show("Are You Sure you want to  Remove this Product ?", "Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "DELETE FROM tbl_product WHERE pro_id = @pro_id";

                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@pro_id", cmbProDel.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Product has been Successfully Remove!", title);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
           
            if (cmbProUpd.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Product", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProUpd.Focus();
                return;
            }

            if (txtProd.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProd.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please Enter Product Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrice.Focus();
                return;
            }


            if (MessageBox.Show("Are You Sure you want to  Update this Product ?", "Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string qry = "UPDATE tbl_product SET pro_name = @NewProName, pro_mvp = @NewProMvp WHERE pro_mvp = @ProId";

                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@ProId", cmbProUpd.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NewProName", txtProd.Text);
                cmd.Parameters.AddWithValue("@NewProMvp", txtPrice.Text);
                cmd.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("Product has been Successfully Updated!", title);
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtService.Text == "")
            {
                MessageBox.Show("Please Enter Service Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtService.Focus();
                return;
            }
            if (txtServicePrice.Text == "")
            {
                MessageBox.Show("Please Enter Service Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtServicePrice.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  Add this Service ?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "INSERT INTO tbl_service (s_name, s_price) values (@s_name, @s_price)";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@s_name", txtService.Text);
                cmd.Parameters.AddWithValue("@s_price", txtServicePrice.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Service has been Successfully Add!", title);
            }
        }

        private void cmbUpService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                servicePrice.Text = cmbUpService.SelectedValue.ToString();
            }
            catch (Exception)
            {
                proRate.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cmbDelService.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Service", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDelPet.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  Remove this Service ?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string qry = "DELETE FROM tbl_service WHERE s_id = @s_id";
                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@s_id", cmbDelService.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Service has been Successfully Remove!", title);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmbUpService.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any One Service", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbUpService.Focus();
                return;
            }

            if (newServiceprice.Text == "")
            {
                MessageBox.Show("Please Enter Service Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                newServiceprice.Focus();
                return;
            }

            if (txtUpService.Text == "")
            {
                MessageBox.Show("Please Enter Service Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUpService.Focus();
                return;
            }

            if (MessageBox.Show("Are You Sure you want to  Update this Product ?", "Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string qry = "UPDATE tbl_service SET s_name = @NewSname, s_price = @NewPrice WHERE s_price = @SId";

                cmd = new SqlCommand(qry, cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@SId", cmbUpService.SelectedValue);
                cmd.Parameters.AddWithValue("@NewSname", txtUpService.Text);
                cmd.Parameters.AddWithValue("@NewPrice", newServiceprice.Text);
                cmd.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Product has been Successfully Updated!", title);
            }
        }
    }
}
