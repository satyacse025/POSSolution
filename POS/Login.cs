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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string conStr = ConfigurationManager.ConnectionStrings["PosConString"].ToString();
            SqlConnection connection = new SqlConnection(conStr);
            string query = "SELECT * FROM [user] WHERE username = '" + userName + "' AND password = '" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();


            SqlDataReader reader = command.ExecuteReader();

            int rowEffict = Convert.ToInt32(reader.Read());
            connection.Close();

            MainBody amainbody = new MainBody();
            if (rowEffict > 0)
            {

                amainbody.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Password or Username Invalid");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
