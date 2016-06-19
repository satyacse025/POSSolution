using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MainBody : Form
    {
        //private int childFormNumber = 0;

        public MainBody()
        {
            InitializeComponent();
        }

        private void itemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductSettingsBody frmprodsettings = new FormProductSettingsBody();
            frmprodsettings.MdiParent = this;
            frmprodsettings.Show();
        }

        private void itemAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProductBody frmaddproduct = new FormAddProductBody();
            frmaddproduct.MdiParent = this;
            frmaddproduct.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct viewpro = new ViewProduct();
            viewpro.MdiParent = this;
            viewpro.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPurchaseItemBody frmpurchaseitem = new FormPurchaseItemBody();
            frmpurchaseitem.MdiParent = this;
            frmpurchaseitem.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lin = new Login();
            lin.Show();
            Close();

        }
    }
}
