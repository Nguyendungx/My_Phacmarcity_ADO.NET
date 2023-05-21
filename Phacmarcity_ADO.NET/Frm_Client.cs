using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phacmarcity_ADO.NET.ENUM;
using Phacmarcity_ADO.NET.Class;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Client : Form
    {
        public Frm_Client()
        {
            InitializeComponent();
        }

        private void Frm_Client_Load(object sender, EventArgs e)
        {
            pnlControl.Enabled= false;
            pnlSearch.Enabled= false;   
        }
        private void picNCC_Click(object sender, EventArgs e)
        {
            Form form = new Frm_Supplier();
            form.ShowDialog();
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            Form form1 = new Frm_Employees();
            form1.ShowDialog();
        }

        private void picHangSX_Click(object sender, EventArgs e)
        {
            Form form2 = new Frm_Manufacturer();
            form2.ShowDialog();
        }

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form form = new Frm_Medicine();
            form.ShowDialog();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

    }
}
