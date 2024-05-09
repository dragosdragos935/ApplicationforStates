// Form2
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LFA2_Matei_Dragos_Catalin
{
    public partial class Form2 : Form
    {
        // Declaram o variabila globala pentru a stoca optiunea selectata din ComboBox
        public string optiuneSelectata;
        private string motivInscriereForm1;

        // Adaugam un constructor care primeste textul de la Form1
        public Form2(string motivInscriereForm1)
        {
            InitializeComponent();

            // Salvam textul de la Form1
            this.motivInscriereForm1 = motivInscriereForm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectată o opțiune în ComboBox
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați o opțiune!");
                return;
            }

            // Stocăm opțiunea selectată în variabila optiuneSelectata
            optiuneSelectata = comboBox1.SelectedItem.ToString();

            // Trecem la următoarea stare (Form3), trimitând textul de la Form1 și opțiunea selectată
            Form3 form3 = new Form3(motivInscriereForm1, optiuneSelectata);
            
            form3.Show();

            // Închidem Form2
            this.Close();
        }
    }
}
