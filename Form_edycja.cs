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
    public partial class Form_edycja : Form
    {
        public Form_edycja()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");
        private void button_menu_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void Form_edycja_Load(object sender, EventArgs e)
        {

        }

        private void button_zapiszzmiany_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wprowadź dane użytkownika do bazy danych
                string updateQuery = "UPDATE pacjentdata SET name = @name, surname = @surname, sex = @sex, DateOfBirth = @DateOfBirth, telefon = @telefon, email = @email, miasto = @miasto, ulica = @ulica, kodpoczt = @kodpoczt WHERE pesel = '" + text_pesel.Text + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@name", text_imie.Text);
                cmd.Parameters.AddWithValue("@surname", text_nazwisko.Text);
                cmd.Parameters.AddWithValue("@sex", box_plec.Text);
                cmd.Parameters.AddWithValue("@telefon", text_numer.Text);
                cmd.Parameters.AddWithValue("@email", text_email.Text);
                cmd.Parameters.AddWithValue("@miasto", text_miasto.Text);
                cmd.Parameters.AddWithValue("@ulica", text_ulica.Text);
                cmd.Parameters.AddWithValue("@kodpoczt", text_kodpoczt.Text);

                // Odczyt daty urodzenia z DateTimePicker
                cmd.Parameters.AddWithValue("@DateOfBirth", text_data.Value);

                cmd.Parameters.AddWithValue("@pesel", text_pesel.Text);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Zmieniono dane Pacjenta w bazie danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_imie.Clear();
                    text_nazwisko.Clear();
                    text_pesel.Clear();
                    text_numer.Clear();
                    text_miasto.Clear();
                    text_ulica.Clear();
                    text_kodpoczt.Clear();
                    text_email.Clear();

                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić danych Pacjenta w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void text_loadpacjent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_loaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wczytaj dane Pacjenta na podstawie PESEL
                string selectQuery = "SELECT * FROM pacjentdata WHERE pesel = '" + text_loadpacjent.Text + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Ustaw dane Pacjenta w formularzu
                    text_imie.Text = reader["name"].ToString();
                    text_nazwisko.Text = reader["surname"].ToString();
                    text_pesel.Text = reader["pesel"].ToString();
                    text_numer.Text = reader["telefon"].ToString();
                    text_email.Text = reader["email"].ToString();
                    text_miasto.Text = reader["miasto"].ToString();
                    text_ulica.Text = reader["ulica"].ToString();
                    text_kodpoczt.Text = reader["kodpoczt"].ToString();
                    box_plec.Text = reader["sex"].ToString();

                    // Odczyt daty urodzenia z DateTimePicker
                    text_data.Value = Convert.ToDateTime(reader["DateOfBirth"]);

                    text_loadpacjent.Text = reader["pesel"].ToString();
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
