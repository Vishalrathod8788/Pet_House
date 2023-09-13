using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_house
{
    public partial class frmLoading : Form
    {
        private Timer animationTimer = new Timer();

        public frmLoading()
        {
            InitializeComponent();
            timer1.Start();
        }
        int starP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starP += 5;
            progressBar1.Value = starP;
            lblPorcentaje.Text = starP + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                frmLogin obj = new frmLogin();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
