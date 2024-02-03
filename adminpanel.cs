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

namespace WindowsFormsApp2
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button_pa_login_Click(object sender, EventArgs e)
        {
            String username, user_password, usertype;

            username = text_admin_username.Text;
            user_password = text_admin_password.Text;
            



            try
            {
                String querry = "SELECT * FROM systemlogin WHERE username = '" + text_admin_username.Text + "' AND password = '" + text_admin_password.Text + "' AND usertype = 'Admin'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = text_admin_username.Text;
                    user_password = text_admin_password.Text;
                    
                    //nastepna strona ktora bedzie zaladowana
                    MessageBox.Show("Success");
                    pamenu form2 = new pamenu();
                    form2.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Twój Login jest Inwalidą", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_admin_username.Clear();
                    text_admin_password.Clear();

                    //skupienie na username
                    text_admin_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}