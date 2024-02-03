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
    public partial class Form_zapis : Form
    {
        public Form_zapis()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");
        private void button2_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

              
                string insertQuery = "INSERT INTO zapisydata (name, surname, pesel, lekarz, data_wizyty) VALUES (@name, @surname, @pesel, @lekarz, @data_wizyty)";



                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", text_imie.Text);
                cmd.Parameters.AddWithValue("@surname", text_nazwisko.Text);
                
                               
                cmd.Parameters.AddWithValue("@data_wizyty", text_data_wizyty.Value);
                cmd.Parameters.AddWithValue("@lekarz", box_lekarz.Text);
                cmd.Parameters.AddWithValue("@pesel", text_pesel.Text);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Zarejestrowano wizytę", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_imie.Clear();
                    text_nazwisko.Clear();
                    text_pesel.Clear();
                    

                }
                else
                {
                    MessageBox.Show("Nie udało się zapisać wizyty do bazy danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_loadpacjent_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wczytaj dane Pacjenta na podstawie PESEL
                string selectQuery = "SELECT * FROM pacjentdata WHERE pesel = '" + text_pesel.Text + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Ustaw dane Pacjenta w formularzu
                    text_imie.Text = reader["name"].ToString();
                    text_nazwisko.Text = reader["surname"].ToString();
                    
                    
                    
                    text_pesel.Text = reader["pesel"].ToString();
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
