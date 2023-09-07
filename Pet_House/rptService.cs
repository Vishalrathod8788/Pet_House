using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pet_house
{
    public partial class rptService : Form
    {
        dbConnection db = new dbConnection();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public rptService()
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
                string id = textBox1.Text;
                string qry = @"select B.bs_id, B.bs_date, C.c_name, S.s_name, PT.pt_name,S.s_price, B.no_of_day, B.bs_total from tbl_bill_service B, tbl_service S, tbl_customer C, tbl_pet_type PT WHERE B.bs_id = "+ id +" AND B.c_id=C.c_id AND S.s_id=B.s_id AND B.pt_id=PT.pt_id";
                SqlDataAdapter AD = new SqlDataAdapter(qry, cn);
                DataTable dt = new DataTable("monthreport");
                AD.Fill(dt);
                dt.WriteXmlSchema("monthreport.xml");
                //MessageBox.Show("schema written ! ");


                CrystalReport1 r = new CrystalReport1();
                r.SetDataSource(dt);
                crystalReportViewer1.ReportSource = r;
                crystalReportViewer1.RefreshReport();
            }
        }
    }
}
