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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet2.product_details' table. You can move, or remove it, as needed.
            this.product_detailsTableAdapter1.Fill(this.pOSDataSet2.product_details);
            // TODO: This line of code loads data into the 'pOSDataSet1.product_details' table. You can move, or remove it, as needed.
            this.product_detailsTableAdapter.Fill(this.pOSDataSet1.product_details);
            // TODO: This line of code loads data into the 'pOSDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pOSDataSet.product);

        }
    }
}
