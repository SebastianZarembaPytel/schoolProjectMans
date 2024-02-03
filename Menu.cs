using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_formularz_Click(object sender, EventArgs e)
        {
            FormFormularz form3 = new FormFormularz();
            form3.Show();
            this.Hide();
        }

        private void button_listpacjent_Click(object sender, EventArgs e)
        {
            Form_edycja form5 = new Form_edycja();
            form5.Show();
            this.Hide();
        }

        private void button_zapis_Click(object sender, EventArgs e)
        {
            Form_zapis form4 = new Form_zapis();
            form4.Show();
            this.Hide();
        }

        private void button_lista_Click(object sender, EventArgs e)
        {
            Form3 form6 = new Form3();
            form6.Show();
            this.Hide();
        }
    }
}
