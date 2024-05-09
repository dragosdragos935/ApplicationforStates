using System;
using System.Windows.Forms;

namespace LFA2_Matei_Dragos_Catalin
{
    public partial class Form5 : Form
    {
        // Variabilele pentru a stoca valorile salvate anterior
        private string motivInscriere;
        private bool[] checkBoxSelectat = new bool[3];
        private int radioButtonSelectat;

        // Adăugăm variabilele suplimentare pentru a primi valori de la celelalte formulare
        private string motivInscriereForm1;
        private string optiuneSelectataForm2;
        private string[] checkBoxSelectatForm3 = new string[3];
        private int radioButtonSelectatForm4;
        private string radioString4;

        public Form5(string motivInscriere, string optiuneSelectataForm2, string[] checkBoxSelectatForm3, int radioButtonSelectatForm4,string radiostring)
        {
            InitializeComponent();

            // Salvăm valorile din parametrii în variabilele locale ale Form5
            this.motivInscriere = motivInscriere;
            this.optiuneSelectataForm2 = optiuneSelectataForm2;
            this.checkBoxSelectatForm3 = checkBoxSelectatForm3;
            this.radioButtonSelectatForm4 = radioButtonSelectatForm4;
            this.radioString4 = radiostring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificăm dacă a fost selectată opțiunea "Da" în ComboBox
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Da")
            {
                // Construim un mesaj cu toate variabilele salvate
                string mesaj = "Motivul înscrierii(Form1): " + motivInscriere + " (de la Form1)\n\n";
                mesaj += "Opțiunea selectată din ComboBox(Form2): " + optiuneSelectataForm2 + "\n\n";
                // Iterăm prin array-ul checkBoxSelectatForm3 și adăugăm numele checkbox-urilor selectate în mesaj
                for (int i = 0; i < checkBoxSelectatForm3.Length; i++)
                {
                    if (!string.IsNullOrEmpty(checkBoxSelectatForm3[i]))
                    {
                        mesaj += "Form3: " + (i + 1) + ": " + checkBoxSelectatForm3[i] + "\n";
                    }
                }

                mesaj += "Opțiunea selectată din RadioButton(Form4): " + radioButtonSelectatForm4 +" "+radioString4  +"\n\n";
                // mesaj += "Opțiunea selectată din RadioButton din Form5: " + radioButtonSelectatForm5 + "\n\n"; // radioButtonSelectatForm5 nu este disponibilă aici
                mesaj += "Opțiunea selectată din ComboBox(Form5):"+comboBox1.Text;
                
               
      
                // Afișăm mesajul într-un MessageBox
                MessageBox.Show(mesaj, "Informații salvate");
            }
            else
            {
                // Dacă nu a fost selectată opțiunea "Da", afișăm un mesaj de atenționare
                MessageBox.Show("Selectați opțiunea 'Da' din ComboBox pentru a afișa informațiile.", "Atenție");
            }
        }
    }
}
