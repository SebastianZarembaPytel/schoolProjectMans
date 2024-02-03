using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class pausers : Form
    {
        public pausers()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False";
        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");
        private void button_backpa_Click(object sender, EventArgs e)
        {
            pamenu form3 = new pamenu();
            form3.Show();
            this.Hide();
        }

        private void button_ref_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM systemlogin", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button_addnew_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                
                string insertQuery = "INSERT INTO systemlogin (username, password, usertype, name, surname) VALUES (@username, @password, @usertype, @name, @surname)";



                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@username", text_login.Text);
                cmd.Parameters.AddWithValue("@password", text_pass.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@name", text_name.Text);
                cmd.Parameters.AddWithValue("@surname", text_surname.Text);



                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dodano nowego użytkownika do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_login.Clear();
                    text_pass.Clear();
                    text_name.Clear();
                    text_surname.Clear();
                    

                }
                else
                {
                    MessageBox.Show("Nie udało się dodać użytkownika do bazy danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wczytaj dane Pacjenta na podstawie PESEL
                string selectQuery = "SELECT * FROM systemlogin WHERE username = '" + text_login.Text + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Ustaw dane Pacjenta w formularzu
                    
                    text_pass.Text = reader["password"].ToString();
                    text_name.Text = reader["name"].ToString();
                    text_surname.Text = reader["surname"].ToString();
                    comboBox1.Text = reader["usertype"].ToString();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wprowadź dane użytkownika do bazy danych
                string updateQuery = "UPDATE systemlogin SET name = @name, surname = @surname, password = @password, usertype = @usertype WHERE username = '" + text_login.Text + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@password", text_pass.Text);
                cmd.Parameters.AddWithValue("@name", text_name.Text);
                cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@surname", text_surname.Text);



                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Zmieniono dane użytkownika w bazie danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_name.Clear();
                    text_surname.Clear();
                    text_pass.Clear();
                    text_login.Clear();


                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić danych użytkownika w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wprowadź dane użytkownika do bazy danych
                string updateQuery = "DELETE FROM systemlogin WHERE username = '" + text_logintodelete.Text + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("usunięto dane użytkownika w bazie danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    


                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić danych użytkownika w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
