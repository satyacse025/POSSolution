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
using System.Configuration;

namespace POS
{
    public partial class FormProductSettingsBody : Form
    {
        public FormProductSettingsBody()
        {
            InitializeComponent();
            ShowTreeViewItem();
            string query = "SELECT * FROM maincategory";
            fillCombo(comboBoxMainCategory, query, "maincate_name", "maincate_id");
            fillCombo(comboBoxAddMain, query, "maincate_name", "maincate_id");
            fillCombo(comboBoxAddMainCateS4, query, "maincate_name", "maincate_id");
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

        private void buttonAddMainCategory_Click(object sender, EventArgs e)
        {
            if (textBoxAddMainCategory.Text == "")
            {
                MessageBox.Show("Please fill the textbox..");
            }
            else
            {

                string addMainCate = textBoxAddMainCategory.Text;
                //string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                SqlConnection connection = new SqlConnection(conStr);
                string query = "INSERT INTO maincategory VALUES('" + addMainCate + "')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowEffict = command.ExecuteNonQuery();
                connection.Close();
                if (rowEffict > 0)
                {
                    textBoxAddMainCategory.Text = string.Empty;
                    string query11 = "SELECT * FROM maincategory";
                    fillCombo(comboBoxMainCategory, query11, "maincate_name", "maincate_id");
                    ShowTreeViewItem();
                    MessageBox.Show("Main Category Insert Successfully !");
                }
            }
        }

        private void buttonAddCatecory_Click_1(object sender, EventArgs e)
        {
            if (textBoxAddCate.Text == "" && comboBoxMainCategory.SelectedText == "")
            {
                MessageBox.Show("Please fill the textbox..");
            }
            else
            {
                int val;
                Int32.TryParse(comboBoxMainCategory.SelectedValue.ToString(), out val);
                //MessageBox.Show(val.ToString());

                string addCate = textBoxAddCate.Text;
                //string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                SqlConnection connection = new SqlConnection(conStr);
                string query = "INSERT INTO category VALUES('" + val + "','" + addCate + "')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowEffict = command.ExecuteNonQuery();
                connection.Close();
                if (rowEffict > 0)
                {
                    ShowTreeViewItem();
                    textBoxAddCate.Text = string.Empty;
                    string query11 = "SELECT * FROM maincategory";
                    fillCombo(comboBoxAddMain, query11, "maincate_name", "maincate_id");
                    MessageBox.Show("Category Insert Successfully !");
                }
            }
        }

        private void comboBoxAddMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM category WHERE maincate_id = " + val;

            fillCombo(comboBoxAddCat, query, "cate_name", "cate_id");
        }

        private void btnAddSubCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtAddSubCate.Text == "")
                {
                    MessageBox.Show("Please Fill all information....");
                }
                else
                {
                    int val1;
                    Int32.TryParse(comboBoxAddMain.SelectedValue.ToString(), out val1);

                    int val2;
                    Int32.TryParse(comboBoxAddCat.SelectedValue.ToString(), out val2);

                    string addSubCate = txtAddSubCate.Text;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query11 = "INSERT INTO subcategory VALUES('" + val1 + "','" + val2 + "','" + addSubCate + "')";
                    SqlCommand command = new SqlCommand(query11, connection);
                    connection.Open();
                    int rowEffict = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict > 0)
                    {
                        ShowTreeViewItem();
                        txtAddSubCate.Text = string.Empty;
                        MessageBox.Show("Sub Category Insert Successfully !");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBoxAddMainCateS4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vals4;
            Int32.TryParse(comboBoxAddMainCateS4.SelectedValue.ToString(), out vals4);
            string query = "SELECT * FROM category WHERE maincate_id = " + vals4;

            fillCombo(comboBoxAddCateS4, query, "cate_name", "cate_id");
        }

        private void comboBoxAddCateS4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vals41;
            Int32.TryParse(comboBoxAddCateS4.SelectedValue.ToString(), out vals41);
            string query = "SELECT * FROM subcategory WHERE subcate_cateid = " + vals41;

            fillCombo(comboBoxAddSubCateS4, query, "subcate_name", "subcate_id");
        }

        private void buttonAddProductS4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddProductS4.Text == "")
                {
                    MessageBox.Show("Please Fill all information....");
                }
                else
                {
                    int val12;
                    Int32.TryParse(comboBoxAddMainCateS4.SelectedValue.ToString(), out val12);

                    int val22;
                    Int32.TryParse(comboBoxAddCateS4.SelectedValue.ToString(), out val22);

                    int val23;
                    Int32.TryParse(comboBoxAddSubCateS4.SelectedValue.ToString(), out val23);

                    string pro_name = textBoxAddProductS4.Text;
                    string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
                    SqlConnection connection = new SqlConnection(conStr);
                    string query112 = "INSERT INTO product VALUES('" + val12 + "','" + val22 + "','" + val23 + "','" + pro_name + "')";
                    SqlCommand command = new SqlCommand(query112, connection);
                    connection.Open();
                    int rowEffict = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowEffict > 0)
                    {
                        ShowTreeViewItem();
                        textBoxAddProductS4.Text = string.Empty;
                        MessageBox.Show("Product Insert Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
