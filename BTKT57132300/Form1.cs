using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKT57132300
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cẬPNHẬPXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmUpdateCars frm = new frmUpdateCars();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cẬPNHẬPCHUYẾNXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmUpdateTrip frm = new frmUpdateTrip();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
