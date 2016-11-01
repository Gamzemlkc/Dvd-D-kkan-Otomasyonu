using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDDUKKAN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmDvdGiris frmdvdgiris = new frmDvdGiris();
        frmSatis frmsatis = new frmSatis();
        private void btnDvd_Click(object sender, EventArgs e)
        {
            frmdvdgiris.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmsatis.Show();
        }
    }
}
