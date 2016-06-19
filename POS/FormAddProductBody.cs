using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FormAddProductBody : Form
    {
        public FormAddProductBody()
        {
            InitializeComponent();
            ShowTreeViewItem();
            string query = "SELECT * FROM maincategory";
            fillCombo(comboBoxAddMain, query, "maincate_name", "maincate_id");
        }
        SqlConnection con = new SqlConnection("SERVER = Kamrul-PC; DATABASE =pos; user id = sa; password = 123");
        //string con11 = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            //combo.Items.Clear();
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }
        private void FormAddProductBody_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxAddMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM category WHERE maincate_id = " + val;

            fillCombo(comboBoxAddCat, query, "cate_name", "cate_id");
        }

        private void comboBoxAddCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxAddCat.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM subcategory WHERE subcate_cateid = " + val;

            fillCombo(comboBoxAddSubCate, query, "subcate_name", "subcate_id");
        }

       

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int main_cateid;
            Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out main_cateid);
            int cateid;
            Int32.TryParse(comboBoxAddCat.SelectedValue.ToString(), out cateid);
            int sub_cateid;
            Int32.TryParse(comboBoxAddSubCate.SelectedValue.ToString(), out sub_cateid);
            int pro_name;
            Int32.TryParse(comboBoxProductName.SelectedValue.ToString(), out pro_name);

            int purchase_price = Convert.ToInt32(textBoxPurchasePrice.Text);
            int sale_price = Convert.ToInt32(textBoxSalePrice.Text);
            int product_stock = Convert.ToInt32(textBoxProductStock.Text);
            
            string product_description = textBoxProductDiscription.Text;
            

            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "INSERT INTO product_details VALUES('" + main_cateid + "','" + cateid + "','" + sub_cateid + "','" + pro_name + "','" + purchase_price + "','" + sale_price + "','" + product_stock + "','" + product_description + "',1)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffict = command.ExecuteNonQuery();
            connection.Close();
            if (rowEffict > 0)
            {
               textBoxPurchasePrice.Text = textBoxSalePrice.Text = textBoxProductStock.Text = string.Empty;
               textBoxProductDiscription.Text = string.Empty;
                ShowTreeViewItem();
                MessageBox.Show("Product Add Successfully !");
            }


        }
        public void ShowTreeViewItem()
        {
            treeViewCategory.Nodes.Clear();
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM maincategory";
            SqlCommand command1 = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command1.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                treeViewCategory.Nodes.Add(reader["maincate_name"].ToString());
                FirstChild(Convert.ToInt32(reader["maincate_id"]), i);
                i++;


            }
            reader.Close();
            connection.Close();


        }

        string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();



        public void FirstChild(int mainID, int i)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection1 = new SqlConnection(conStr);
            string query1 = "SELECT * FROM category WHERE maincate_id = '" + mainID + "'";
            SqlCommand command11 = new SqlCommand(query1, connection1);

            connection1.Open();
            SqlDataReader reader1 = command11.ExecuteReader();
            int j = 0;
            while (reader1.Read())
            {
                treeViewCategory.Nodes[i].Nodes.Add(reader1["cate_name"].ToString());
                SecondChild(Convert.ToInt32(reader1["cate_id"]), i, j);
                j++;
            }
            reader1.Close();
            connection1.Close();
        }

        public void SecondChild(int catID, int i, int j)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection12 = new SqlConnection(conStr);
            string query12 = "SELECT * FROM subcategory WHERE subcate_cateid = '" + catID + "'";
            SqlCommand command112 = new SqlCommand(query12, connection12);

            connection12.Open();
            SqlDataReader reader12 = command112.ExecuteReader();
            int k = 0;
            while (reader12.Read())
            {
                treeViewCategory.Nodes[i].Nodes[j].Nodes.Add(reader12["subcate_name"].ToString());
                ThirdChild(Convert.ToInt32(reader12["subcate_id"]), i, j, k);
                k++;
            }
            reader12.Close();
            connection12.Close();
        }
        public void ThirdChild(int SubcatID, int i, int j, int k)
        {
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection12 = new SqlConnection(conStr);
            string query12 = "SELECT * FROM product WHERE pro_subcate_id = '" + SubcatID + "'";
            SqlCommand command112 = new SqlCommand(query12, connection12);

            connection12.Open();
            SqlDataReader reader12 = command112.ExecuteReader();

            while (reader12.Read())
            {
                treeViewCategory.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(reader12["pro_name"].ToString());
            }
            reader12.Close();
            connection12.Close();
        }

        private void comboBoxAddSubCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val111;
            Int32.TryParse(comboBoxAddSubCate.SelectedValue.ToString(), out val111);
            string query = "SELECT * FROM product WHERE pro_subcate_id = " + val111;

            fillCombo(comboBoxProductName, query, "pro_name", "pro_id");
        }
    }
}
