// Form1
using System;
using System.Windows.Forms;

namespace LFA2_Matei_Dragos_Catalin
{
    public partial class Form1 : Form
    {
        // Declaram o variabila globala pentru a stoca textul introdus
        public string motivInscriere;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificăm dacă s-a introdus un text în textBox1
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Introduceți un motiv pentru înscriere!");
                return;
            }

            // Stocăm textul introdus în variabila motivInscriere
            motivInscriere = textBox1.Text;

            // Închidem Form1
            this.Hide();

            // Trecem la următoarea stare (Form2), trimitând textul introdus
            Form2 form2 = new Form2(motivInscriere);
           
            form2.Show();
        }
    }
}
