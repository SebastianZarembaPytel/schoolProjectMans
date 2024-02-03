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
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class FormFormularz : Form
    {
        public FormFormularz()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DR-GAMING1\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Encrypt=False");
        private void buttun_backtomenu_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_rejestr_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Wprowadź dane użytkownika do bazy danych
               // string insertQuery = "INSERT INTO pacjentdata (name, surname, sex, DateOfBirth, pesel, telefon, email, miasto, ulica, kodpoczt) VALUES (@name, @surname, @sex, @DateOfBirth, @pesel)";


                string insertQuery = "INSERT INTO pacjentdata (name, surname, sex, DateOfBirth, pesel) VALUES (@name, @surname, @sex, @DateOfBirth, @pesel)";
                
                
                
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", text_imie.Text);
                cmd.Parameters.AddWithValue("@surname", text_nazwisko.Text);
                cmd.Parameters.AddWithValue("@sex", box_plec.Text);



                // Odczyt daty urodzenia z DateTimePicker
                cmd.Parameters.AddWithValue("@DateOfBirth", text_data.Value);

                cmd.Parameters.AddWithValue("@pesel", text_pesel.Text);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dodano nowego Pacjenta do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_imie.Clear();
                    text_nazwisko.Clear();
                    text_pesel.Clear();
                    text_numer.Clear();
                    text_miasto.Clear();
                    text_ulica.Clear();
                    text_kodpoczt.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać Pacjenta do bazy danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
