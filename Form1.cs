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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");
     

        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;



            try
            {
                String querry = "SELECT * FROM systemlogin WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0) 
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    //nastepna strona ktora bedzie zaladowana
                    MessageBox.Show("Success");
                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Twój Login jest Inwalidą", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                
                //skupienie na username
                txt_username.Focus();
                
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Czy chcesz opuścić Twierdzę Panie?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button_adminpanel_Click(object sender, EventArgs e)
        {
            adminpanel form3 = new adminpanel();
            form3.Show();
            this.Hide();
        }
    }
}
