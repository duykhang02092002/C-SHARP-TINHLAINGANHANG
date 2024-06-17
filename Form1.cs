using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SHARP_TINHLAINGANHANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbTinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double Laisuat= double.Parse(txtLaisuat.Text.Replace("%",""))/100;
            double sotien = double.Parse(txtSotien.Text);
            int sonam = int.Parse(txtSonam.Text);
            sotien = Convert.ToDouble(txtSotien.Text);
            for(int i = 1; i <= sonam; i++)
            {
                tienlai = sotien * Laisuat;
                lbx.Items.Add("Năm" +i  + "   " + sotien + "        " + tienlai);
                sotien += Laisuat;
            }
           
        }
    }
}
