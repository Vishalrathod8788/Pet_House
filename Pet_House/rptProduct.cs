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
    public partial class rptProduct : Form
    {
        dbConnection db = new dbConnection();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public rptProduct()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Bill No.");
            }
            else
            {
                string id = textBox1.Text.ToString();
                string qry = @"select PB.bp_id, C.c_name, PB.bp_date, P.pro_name, PB.qty, PB.pro_mvp, PB.bp_total from tbl_bill_pro PB, tbl_product P, tbl_customer C WHERE PB.c_id = C.c_id AND PB.pro_id =P.pro_id  AND PB.bp_id  = " + id + "";
                SqlDataAdapter AD = new SqlDataAdapter(qry, cn);
                DataTable dt = new DataTable("product");
                AD.Fill(dt);
                dt.WriteXmlSchema("product.xml");
                Cryrptproduct r = new Cryrptproduct();
                r.SetDataSource(dt);
                crystalReportViewer1.ReportSource = r;
                crystalReportViewer1.RefreshReport();
            }
        }
    }
}
