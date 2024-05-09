using System;
using System.Windows.Forms;

namespace LFA2_Matei_Dragos_Catalin
{
    public partial class Form4 : Form
    {
        // Declaram o variabila globala pentru a stoca optiunea selectata din RadioButton
        public int radioButtonSelectat = -1;
        public string radioButtonSelectat_string = " ";
        // Adăugăm variabilele suplimentare pentru a primi valori de la celelalte formulare
        private string motivInscriereForm1;
        private string optiuneSelectataForm2;
        private string[] checkBoxSelectatForm3 = new string[3]; // Modificăm tipul de la bool[] la string[]

        public Form4(string motivInscriereForm1, string optiuneSelectataForm2, string[] checkBoxSelectatForm3)
        {
            InitializeComponent();

            // Salvăm valorile suplimentare de la celelalte formulare
            this.motivInscriereForm1 = motivInscriereForm1;
            this.optiuneSelectataForm2 = optiuneSelectataForm2;
            this.checkBoxSelectatForm3 = checkBoxSelectatForm3; // Actualizăm tipul de date
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectată o opțiune în RadioButton
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Selectați o opțiune!");
                return;
            }

            // Determinăm care RadioButton este selectat și stocăm indicele acestuia
            if (radioButton1.Checked)
            {
                radioButtonSelectat = 1;
                radioButtonSelectat_string = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                radioButtonSelectat = 2;
                radioButtonSelectat_string = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                radioButtonSelectat_string = radioButton3.Text;
                radioButtonSelectat = 3;
            }

            // Trecem la următoarea stare (Form5), trimitând datele de la Form1, Form2, Form3 și Form4
            Form5 form5 = new Form5(motivInscriereForm1, optiuneSelectataForm2, checkBoxSelectatForm3, radioButtonSelectat, radioButtonSelectat_string);
            form5.Show();

            // Închidem Form4
            this.Close();
        }
    }
}
