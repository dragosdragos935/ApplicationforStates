using System;
using System.Windows.Forms;

namespace LFA2_Matei_Dragos_Catalin
{
    public partial class Form3 : Form
    {
        // Declaram o variabila globala pentru a stoca starea checkbox-urilor
        public string[] checkBoxSelectat = new String[3];

        // Adăugăm variabilele pentru a primi valori de la celelalte formulare
        private string motivInscriereForm1;
        private string optiuneSelectataForm2;

        public Form3(string motivInscriereForm1, string optiuneSelectataForm2)
        {
            InitializeComponent();

            // Salvăm valorile primite de la celelalte formulare
            this.motivInscriereForm1 = motivInscriereForm1;
            this.optiuneSelectataForm2 = optiuneSelectataForm2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Aici poți adăuga orice inițializare necesară când formularul se încarcă
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificăm dacă cel puțin un checkbox este selectat
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Selectați cel puțin o opțiune!");
                return;
            }

            // Stocăm starea checkbox-urilor în variabila checkBoxSelectat
            // Stocăm numele checkbox-urilor selectate în variabila checkBoxSelectat
            if (checkBox1.Checked)
                checkBoxSelectat[0] = checkBox1.Text;
            if (checkBox2.Checked)
                checkBoxSelectat[1] = checkBox2.Text;
            if (checkBox3.Checked)
                checkBoxSelectat[2] = checkBox3.Text;



            // Trecem la următoarea stare (Form4) și trimitem datele primite de la celelalte formulare
            Form4 form4 = new Form4(motivInscriereForm1, optiuneSelectataForm2, checkBoxSelectat);
            form4.Show();

            // Închidem Form3
            this.Close();
        }
    }
}
